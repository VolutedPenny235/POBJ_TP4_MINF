// *************************************************
//
// Form1.cs
//
// Appli CS de pilotage du TP2 MINF
//
// 13.03.2025 SCA@etml-es
//
// *************************************************


using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace AppCsTp2Pwm
{
    public partial class Form1 : Form
    {
  //      int ctsCount = 0;
  //      int m_SendCount = 0;
  //      int m_DispCount = 0;
        byte[] Mess1 = new byte[5];

        Send_Signal SignalTx;
        Recieve_Signal SignalRx;
        private string tempBuffer = ""; // Accumulateur de texte

        public Form1()
        {
            InitializeComponent();
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            //Array.Sort(ports);
            cboPortNames.Items.AddRange(ports);
            cboPortNames.SelectedIndex = 0;
            lstDataIn.Items.Clear();

            //Instanciation
            SignalTx = new Send_Signal();
            SignalRx = new Recieve_Signal();

            // ---- VALEUR PAR DÉFAUT ICI ----
            // Sélectionne le tout premier élément de la liste (ex: "S")
            FormeSlct.SelectedIndex = 0;

        }

        private void btOpenClose_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)    //ouverture du port
            {
                // Paramètres de communication
                serialPort1.PortName = (string)cboPortNames.SelectedItem;

                try
                {
                    serialPort1.Open();

                    btOpenClose.Text = "Close";
                    gbTx.Enabled = true;
                    gbRx.Enabled = true;
                    cboPortNames.Enabled = false;
                    btnRefreshCom.Enabled = false;
                    lstDataOut.Items.Clear();
                    lstDataIn.Items.Clear();
                    txtForme.Clear();
                    txtFrequence.Clear();
                    txtAmplitude.Clear();
                    txtOffset.Clear();
                }
                catch (Exception ex)
                {
                    if (!serialPort1.IsOpen)
                        //MessageBox.Show(ex.ToString(), "Erreur à l'ouverture du port !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Erreur à l'ouverture du port !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
            else //fermeture
            {

                btOpenClose.Text = "Open";
                gbTx.Enabled = false;
                gbRx.Enabled = false;
                cboPortNames.Enabled = true;
                btnRefreshCom.Enabled = true;
            }
        } // end btOpenClose_Click

        //event datareceived du port série
        // Attention : avec certains types de port série, il arrive que cet event survienne
        //  alors qu'il n'y a aucune data reçue
        // De plus, cet event ne peut pas modifier des élement de la GUI (dans un thread différent)
        //  => utilisation d'un delegate qui s'exécute dans le thread de la GUI
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Attention xx.Invoke() peut créer bloquage à la fermeture du port série
            // https://web.archive.org/web/20111210024101/https://connect.microsoft.com/VisualStudio/feedback/details/202137/serialport-close-hangs-the-application
            // http://stackoverflow.com/a/3176959/146622
            //lstDataIn.Invoke(myDelegate); 
            // 1. On récupère les nouveaux caractères sous forme de string
            string newData = SignalRx.ReceptionSignal(ref serialPort1);

            // 2. On les ajoute à notre accumulateur
            tempBuffer += newData;

            // 3. On vérifie si on a une trame complète (qui finit par #)
            if (tempBuffer.Contains("#"))
            {
                SignalRx.SaveNewRxDatas(tempBuffer);
                // On extrait la partie entre ! et #
                int indexDebut = tempBuffer.IndexOf('!');
                int indexFin = tempBuffer.IndexOf('#');

                if (indexDebut != -1 && indexFin > indexDebut)
                {
                    string trameComplete = tempBuffer.Substring(indexDebut, indexFin - indexDebut + 1);

                    // On nettoie le buffer pour la suite (on garde ce qui dépasse après le # au cas où)
                    tempBuffer = tempBuffer.Substring(indexFin + 1);

                    // On envoie à l'interface graphique
                    this.BeginInvoke(new MethodInvoker(() => {
                        UpdateUI(trameComplete);
                    }));
                }
            }
        }

        private void UpdateUI(string trame)
        {
            // Ici tu appelles ta fonction de décodage que je t'ai donnée avant
            if (SignalRx.DecodageTrame(trame))
            {
                lstDataIn.Items.Add(trame);
                if(lstDataIn.Items.Count > 3)
                {
                    lstDataIn.Items.RemoveAt(0);
                }

                //Forcer la ListBox à faire défiler la vue vers le bas
                lstDataIn.TopIndex = lstDataIn.Items.Count - 1;

                //maj de l'affichage
                txtForme.Text = SignalRx.GetForme();
                txtFrequence.Text = SignalRx.GetFrequency().ToString();
                txtAmplitude.Text = SignalRx.GetAmplitude().ToString();
                txtOffset.Text = SignalRx.GetOffset().ToString();
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //mise à jour des paramètres
            SignalTx.UpdateForme((ushort)FormeSlct.SelectedIndex);
            SignalTx.UpdateFrequence((ushort)nudFrequence.Value);
            SignalTx.UpdateAmplitude((ushort)nudAmplitude.Value);
            SignalTx.UpdateOffset((short)nudOffset.Value);

            //envoie du message
           if(!SignalTx.EnvoieSignal(ref serialPort1))
            {   //si l'envoie à échouer
                lstDataOut.Items.Clear();
                btOpenClose.Text = "Open";
                gbTx.Enabled = false;
                gbRx.Enabled = false;
                cboPortNames.Enabled = true;
                btnRefreshCom.Enabled = true;
                RefreshCom();
            }

            //affichage dans l'app de la trame complète
            lstDataOut.Items.Add(SignalTx.GetTrametoSend());
            if (lstDataOut.Items.Count > 3)
            {
                lstDataOut.Items.RemoveAt(0);
            }

            //Forcer la ListBox à faire défiler la vue vers le bas
            lstDataOut.TopIndex = lstDataOut.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCom();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SignalTx.UpdateSauvegarde();
            if (Savestate.Text == "Disabled")
            {
                Savestate.Text = "Enabled";
            }
            else
            {
                Savestate.Text = "Disabled";
            }
        }

        private void FormeSlct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SignalTx.UpdateForme((ushort)FormeSlct.SelectedIndex);
        }

        private void nudAngle_ValueChanged(object sender, EventArgs e)
        {
            SignalTx.UpdateFrequence((ushort)nudFrequence.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SignalTx.UpdateAmplitude((ushort)nudAmplitude.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SignalTx.UpdateOffset((short)nudOffset.Value);
        }

        private void RefreshCom()
        {
            cboPortNames.Items.Clear();
            // Get a list of serial port names.
            
            string[] ports = SerialPort.GetPortNames();
            cboPortNames.Items.AddRange(ports);
            cboPortNames.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtVitesse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lstDataOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
