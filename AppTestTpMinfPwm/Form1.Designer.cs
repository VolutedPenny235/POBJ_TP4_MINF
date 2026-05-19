namespace AppCsTp2Pwm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.btOpenClose = new System.Windows.Forms.Button();
            this.cboPortNames = new System.Windows.Forms.ComboBox();
            this.gbTx = new System.Windows.Forms.GroupBox();
            this.Savestate = new System.Windows.Forms.Label();
            this.FormeSlct = new System.Windows.Forms.ComboBox();
            this.btSave = new System.Windows.Forms.Button();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.nudAmplitude = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDataOut = new System.Windows.Forms.ListBox();
            this.btSend = new System.Windows.Forms.Button();
            this.nudFrequence = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRx = new System.Windows.Forms.GroupBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDataIn = new System.Windows.Forms.ListBox();
            this.txtFrequence = new System.Windows.Forms.TextBox();
            this.txtForme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefreshCom = new System.Windows.Forms.Button();
            this.gbCom.SuspendLayout();
            this.gbTx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequence)).BeginInit();
            this.gbRx.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.btnRefreshCom);
            this.gbCom.Controls.Add(this.btOpenClose);
            this.gbCom.Controls.Add(this.cboPortNames);
            this.gbCom.Location = new System.Drawing.Point(12, 12);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(515, 70);
            this.gbCom.TabIndex = 20;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Réglages communication";
            // 
            // btOpenClose
            // 
            this.btOpenClose.Location = new System.Drawing.Point(16, 30);
            this.btOpenClose.Name = "btOpenClose";
            this.btOpenClose.Size = new System.Drawing.Size(75, 23);
            this.btOpenClose.TabIndex = 19;
            this.btOpenClose.Text = "Open";
            this.btOpenClose.UseVisualStyleBackColor = true;
            this.btOpenClose.Click += new System.EventHandler(this.btOpenClose_Click);
            // 
            // cboPortNames
            // 
            this.cboPortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortNames.FormattingEnabled = true;
            this.cboPortNames.Location = new System.Drawing.Point(114, 32);
            this.cboPortNames.Margin = new System.Windows.Forms.Padding(2);
            this.cboPortNames.Name = "cboPortNames";
            this.cboPortNames.Size = new System.Drawing.Size(98, 21);
            this.cboPortNames.Sorted = true;
            this.cboPortNames.TabIndex = 17;
            // 
            // gbTx
            // 
            this.gbTx.Controls.Add(this.Savestate);
            this.gbTx.Controls.Add(this.FormeSlct);
            this.gbTx.Controls.Add(this.btSave);
            this.gbTx.Controls.Add(this.nudOffset);
            this.gbTx.Controls.Add(this.nudAmplitude);
            this.gbTx.Controls.Add(this.label7);
            this.gbTx.Controls.Add(this.label4);
            this.gbTx.Controls.Add(this.lstDataOut);
            this.gbTx.Controls.Add(this.btSend);
            this.gbTx.Controls.Add(this.nudFrequence);
            this.gbTx.Controls.Add(this.label3);
            this.gbTx.Controls.Add(this.label2);
            this.gbTx.Enabled = false;
            this.gbTx.Location = new System.Drawing.Point(12, 88);
            this.gbTx.Name = "gbTx";
            this.gbTx.Size = new System.Drawing.Size(250, 251);
            this.gbTx.TabIndex = 21;
            this.gbTx.TabStop = false;
            this.gbTx.Text = "TX";
            // 
            // Savestate
            // 
            this.Savestate.AutoSize = true;
            this.Savestate.Enabled = false;
            this.Savestate.Location = new System.Drawing.Point(144, 176);
            this.Savestate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Savestate.Name = "Savestate";
            this.Savestate.Size = new System.Drawing.Size(48, 13);
            this.Savestate.TabIndex = 69;
            this.Savestate.Text = "Disabled";
            this.Savestate.Click += new System.EventHandler(this.label10_Click);
            // 
            // FormeSlct
            // 
            this.FormeSlct.FormattingEnabled = true;
            this.FormeSlct.Items.AddRange(new object[] {
            "Sinus",
            "Triangle",
            "Dent de scie",
            "Carrée"});
            this.FormeSlct.Location = new System.Drawing.Point(86, 24);
            this.FormeSlct.Name = "FormeSlct";
            this.FormeSlct.Size = new System.Drawing.Size(74, 21);
            this.FormeSlct.TabIndex = 68;
            this.FormeSlct.SelectedIndexChanged += new System.EventHandler(this.FormeSlct_SelectedIndexChanged);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(127, 150);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 23);
            this.btSave.TabIndex = 67;
            this.btSave.Text = "Sauvegarder";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // nudOffset
            // 
            this.nudOffset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudOffset.Location = new System.Drawing.Point(86, 110);
            this.nudOffset.Margin = new System.Windows.Forms.Padding(2);
            this.nudOffset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(56, 20);
            this.nudOffset.TabIndex = 66;
            this.nudOffset.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudAmplitude
            // 
            this.nudAmplitude.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAmplitude.Location = new System.Drawing.Point(86, 81);
            this.nudAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.nudAmplitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmplitude.Name = "nudAmplitude";
            this.nudAmplitude.Size = new System.Drawing.Size(56, 20);
            this.nudAmplitude.TabIndex = 64;
            this.nudAmplitude.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Amplitude";
            // 
            // lstDataOut
            // 
            this.lstDataOut.FormattingEnabled = true;
            this.lstDataOut.Location = new System.Drawing.Point(16, 201);
            this.lstDataOut.Margin = new System.Windows.Forms.Padding(2);
            this.lstDataOut.Name = "lstDataOut";
            this.lstDataOut.Size = new System.Drawing.Size(221, 43);
            this.lstDataOut.TabIndex = 56;
            this.lstDataOut.SelectedIndexChanged += new System.EventHandler(this.lstDataOut_SelectedIndexChanged);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(16, 150);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(94, 23);
            this.btSend.TabIndex = 52;
            this.btSend.Text = "Envoi ";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // nudFrequence
            // 
            this.nudFrequence.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFrequence.Location = new System.Drawing.Point(86, 52);
            this.nudFrequence.Margin = new System.Windows.Forms.Padding(2);
            this.nudFrequence.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFrequence.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFrequence.Name = "nudFrequence";
            this.nudFrequence.Size = new System.Drawing.Size(56, 20);
            this.nudFrequence.TabIndex = 29;
            this.nudFrequence.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFrequence.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fréquence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Forme";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gbRx
            // 
            this.gbRx.Controls.Add(this.txtOffset);
            this.gbRx.Controls.Add(this.txtAmplitude);
            this.gbRx.Controls.Add(this.label8);
            this.gbRx.Controls.Add(this.label1);
            this.gbRx.Controls.Add(this.lstDataIn);
            this.gbRx.Controls.Add(this.txtFrequence);
            this.gbRx.Controls.Add(this.txtForme);
            this.gbRx.Controls.Add(this.label6);
            this.gbRx.Controls.Add(this.label5);
            this.gbRx.Enabled = false;
            this.gbRx.Location = new System.Drawing.Point(277, 88);
            this.gbRx.Name = "gbRx";
            this.gbRx.Size = new System.Drawing.Size(250, 251);
            this.gbRx.TabIndex = 22;
            this.gbRx.TabStop = false;
            this.gbRx.Text = "RX";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(94, 110);
            this.txtOffset.Margin = new System.Windows.Forms.Padding(2);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.ReadOnly = true;
            this.txtOffset.Size = new System.Drawing.Size(61, 20);
            this.txtOffset.TabIndex = 63;
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.Location = new System.Drawing.Point(94, 81);
            this.txtAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.ReadOnly = true;
            this.txtAmplitude.Size = new System.Drawing.Size(61, 20);
            this.txtAmplitude.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Amplitude";
            // 
            // lstDataIn
            // 
            this.lstDataIn.FormattingEnabled = true;
            this.lstDataIn.Location = new System.Drawing.Point(17, 201);
            this.lstDataIn.Margin = new System.Windows.Forms.Padding(2);
            this.lstDataIn.Name = "lstDataIn";
            this.lstDataIn.Size = new System.Drawing.Size(221, 43);
            this.lstDataIn.TabIndex = 52;
            // 
            // txtFrequence
            // 
            this.txtFrequence.Location = new System.Drawing.Point(94, 52);
            this.txtFrequence.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrequence.Name = "txtFrequence";
            this.txtFrequence.ReadOnly = true;
            this.txtFrequence.Size = new System.Drawing.Size(61, 20);
            this.txtFrequence.TabIndex = 57;
            // 
            // txtForme
            // 
            this.txtForme.Location = new System.Drawing.Point(94, 24);
            this.txtForme.Margin = new System.Windows.Forms.Padding(2);
            this.txtForme.Name = "txtForme";
            this.txtForme.ReadOnly = true;
            this.txtForme.Size = new System.Drawing.Size(61, 20);
            this.txtForme.TabIndex = 56;
            this.txtForme.TextChanged += new System.EventHandler(this.txtVitesse_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Fréquence";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Forme";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnRefreshCom
            // 
            this.btnRefreshCom.AccessibleName = "BtnRefreshCom";
            this.btnRefreshCom.Location = new System.Drawing.Point(340, 30);
            this.btnRefreshCom.Name = "btnRefreshCom";
            this.btnRefreshCom.Size = new System.Drawing.Size(94, 23);
            this.btnRefreshCom.TabIndex = 70;
            this.btnRefreshCom.Text = "Refresh";
            this.btnRefreshCom.UseVisualStyleBackColor = true;
            this.btnRefreshCom.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 351);
            this.Controls.Add(this.gbRx);
            this.Controls.Add(this.gbTx);
            this.Controls.Add(this.gbCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MINF_TP4_LFO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCom.ResumeLayout(false);
            this.gbTx.ResumeLayout(false);
            this.gbTx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequence)).EndInit();
            this.gbRx.ResumeLayout(false);
            this.gbRx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.ComboBox cboPortNames;
        private System.Windows.Forms.GroupBox gbTx;
        private System.Windows.Forms.NumericUpDown nudFrequence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpenClose;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.GroupBox gbRx;
        private System.Windows.Forms.ListBox lstDataIn;
        private System.Windows.Forms.TextBox txtFrequence;
        private System.Windows.Forms.TextBox txtForme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDataOut;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.NumericUpDown nudAmplitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.TextBox txtAmplitude;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox FormeSlct;
        private System.Windows.Forms.Label Savestate;
        private System.Windows.Forms.Button btnRefreshCom;
    }
}

