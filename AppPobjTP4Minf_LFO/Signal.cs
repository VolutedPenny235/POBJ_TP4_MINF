using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace AppCsTp2Pwm
{
    public class Signal
    {
        //attributs
        //-Privates-//
        protected ushort m_amplitude;
        protected ushort m_frequence;
        protected short m_offset;
        protected string[] m_tb_signal = { "S", "T", "D", "C" };
        protected ushort m_Forme_signal_index;

        //-Public-//

        //méthodes
        //-Privates-//

        //-Public-//
        public virtual int EnvoieSignal() {
            int test = 10;
                return test;
        }
        public virtual int ReceptionSignal() {
            int test = 10;

            return test;
        }

        public void UpdateAmplitude(ushort value)
        {
            m_amplitude = value;
        }

        public void UpdateFrequence(ushort value)
        {
            m_frequence = value;
        }

        public void UpdateOffset(short value)
        {
            m_offset = value;
        }
        
        public void UpdateForme(ushort value)
        {
            m_Forme_signal_index = value;
        }
    }

    public class Send_Signal : Signal
    {
        //attributs
        //-Privates-//
        private bool m_sauvegarde;
        private char[] m_tb_trameSend;
        //-Public-//

        //méthodes
        //-Privates-//
        //-Public-//
        public bool EnvoieSignal(ref SerialPort serialPort)
        {
            int nbCharMess;

            // Envoie le message si le port est ouvert
            if (serialPort.IsOpen)
            {

                // Compose et envoie le message canal 1
                nbCharMess = CodageTrame(ref m_tb_trameSend);

                try
                {
                    serialPort.Write(m_tb_trameSend, 0, nbCharMess);
                }
                catch (Exception ex)
                {

                    //serialPort1.DiscardInBuffer();
                    serialPort.DiscardOutBuffer();

                    //MessageBox.Show(ex.ToString(), "Erreur à l'envoi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (serialPort.CtsHolding == true) //ctrl de flux autorise émission ? 
                        MessageBox.Show("Erreur à l'émission !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Le contrôle de flux HW bloque l'émission !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Port non ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public int CodageTrame(ref char[] msg)
        {
            //définir si offset est + ou -
            string Stroffset = m_offset < 0 ? m_offset.ToString("D2") : "+" + m_offset.ToString("D2");
            //création du message avec qui correspond à la trame :
            msg = string.Format("!S={0}F={1:D2}A={2:D2}O={3}W={4}#",
                                         m_tb_signal[m_Forme_signal_index],
                                         m_frequence,
                                         m_amplitude,
                                         Stroffset,
                                         m_sauvegarde ? 1 : 0).ToCharArray();

            return msg.Length;
        }
        public void UpdateSauvegarde()
        {
            m_sauvegarde = !m_sauvegarde;
        }

        public string GetTrametoSend()
        {
            return new string(m_tb_trameSend);
        }
    }

    public class Recieve_Signal : Signal
    {
        //attributs
        //-Privates-//
        string m_tb_tramRecieved;
        //-Public-//

        //méthodes
        //-Privates-//

        //-Public-//
        public string ReceptionSignal(ref SerialPort serialPort)
        {
            if (serialPort.BytesToRead > 0)
            {
                byte[] buffer = new byte[serialPort.BytesToRead];
                int bytesRead = serialPort.Read(buffer, 0, buffer.Length);

                // On transforme le tableau d'octets en texte
                return Encoding.ASCII.GetString(buffer, 0, bytesRead);
            }
            return string.Empty;
        }
        public virtual bool DecodageTrame(string trame)
        {
            // On définit un "masque" qui correspond à la trame :
            // !S=(forme)F=(frequence)A=(amplitude)O=(offset)W(sauvegarde)#
            var match = Regex.Match(trame, @"S=(?<S>.*)F=(?<F>\d+)A=(?<A>\d+)O=(?<O>[+-]?\d+)WP=(?<W>\d+)");

            if (match.Success)
            {
                // On récupère les groupes nommés
                string formeCode = match.Groups["S"].Value;
                m_frequence = ushort.Parse(match.Groups["F"].Value);
                m_amplitude = ushort.Parse(match.Groups["A"].Value);
                m_offset = short.Parse(match.Groups["O"].Value);

                // On retrouve l'index de la forme ("S", "C", "T"...)
                m_Forme_signal_index = (ushort)Array.IndexOf(m_tb_signal, formeCode);

                return true; // Succès
            }
            return false; // Échec
        }

        public void SaveNewRxDatas(string trame)
        {
            m_tb_tramRecieved = trame;
        }

        public ushort GetFrequency()
        {
            return m_frequence;
        }
        public ushort GetAmplitude()
        {
            return m_amplitude;
        }

        public short GetOffset()
        {
            return m_offset;
        }
        public string GetForme()
        {
            return m_tb_signal[m_Forme_signal_index];
        }
    }
}
