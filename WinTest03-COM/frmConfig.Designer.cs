namespace WinTest03_COM
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbBacR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBacG = new System.Windows.Forms.TextBox();
            this.tbBacB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbForR = new System.Windows.Forms.TextBox();
            this.tbForG = new System.Windows.Forms.TextBox();
            this.tbForB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFntName = new System.Windows.Forms.TextBox();
            this.bnFnt = new System.Windows.Forms.Button();
            this.btBac = new System.Windows.Forms.Button();
            this.btFor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(215, 377);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 359);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbStop);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbData);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbPari);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbBaud);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbPort);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Port Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop Bit";
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "0 - None",
            "1 - One",
            "2 - Two"});
            this.cbStop.Location = new System.Drawing.Point(207, 191);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 20);
            this.cbStop.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Bit";
            // 
            // cbData
            // 
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbData.Location = new System.Drawing.Point(207, 164);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 20);
            this.cbData.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // cbPari
            // 
            this.cbPari.FormattingEnabled = true;
            this.cbPari.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbPari.Location = new System.Drawing.Point(207, 137);
            this.cbPari.Name = "cbPari";
            this.cbPari.Size = new System.Drawing.Size(121, 20);
            this.cbPari.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "576000",
            "115200",
            "57600",
            "38400",
            "19200",
            "9600"});
            this.cbBaud.Location = new System.Drawing.Point(207, 108);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 20);
            this.cbBaud.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(207, 81);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 20);
            this.cbPort.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btFor);
            this.tabPage2.Controls.Add(this.btBac);
            this.tabPage2.Controls.Add(this.bnFnt);
            this.tabPage2.Controls.Add(this.tbForB);
            this.tabPage2.Controls.Add(this.tbBacB);
            this.tabPage2.Controls.Add(this.tbFntName);
            this.tabPage2.Controls.Add(this.tbForG);
            this.tabPage2.Controls.Add(this.tbForR);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbBacG);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tbBacR);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbBacR
            // 
            this.tbBacR.Location = new System.Drawing.Point(191, 100);
            this.tbBacR.Name = "tbBacR";
            this.tbBacR.Size = new System.Drawing.Size(56, 21);
            this.tbBacR.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Background Colour";
            // 
            // tbBacG
            // 
            this.tbBacG.Location = new System.Drawing.Point(253, 100);
            this.tbBacG.Name = "tbBacG";
            this.tbBacG.Size = new System.Drawing.Size(56, 21);
            this.tbBacG.TabIndex = 1;
            // 
            // tbBacB
            // 
            this.tbBacB.Location = new System.Drawing.Point(315, 100);
            this.tbBacB.Name = "tbBacB";
            this.tbBacB.Size = new System.Drawing.Size(56, 21);
            this.tbBacB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Foreground Colour";
            // 
            // tbForR
            // 
            this.tbForR.Location = new System.Drawing.Point(191, 127);
            this.tbForR.Name = "tbForR";
            this.tbForR.Size = new System.Drawing.Size(56, 21);
            this.tbForR.TabIndex = 1;
            // 
            // tbForG
            // 
            this.tbForG.Location = new System.Drawing.Point(253, 127);
            this.tbForG.Name = "tbForG";
            this.tbForG.Size = new System.Drawing.Size(56, 21);
            this.tbForG.TabIndex = 1;
            // 
            // tbForB
            // 
            this.tbForB.Location = new System.Drawing.Point(315, 127);
            this.tbForB.Name = "tbForB";
            this.tbForB.Size = new System.Drawing.Size(56, 21);
            this.tbForB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Font";
            // 
            // tbFntName
            // 
            this.tbFntName.Location = new System.Drawing.Point(191, 154);
            this.tbFntName.Name = "tbFntName";
            this.tbFntName.Size = new System.Drawing.Size(180, 21);
            this.tbFntName.TabIndex = 1;
            // 
            // bnFnt
            // 
            this.bnFnt.Location = new System.Drawing.Point(377, 154);
            this.bnFnt.Name = "bnFnt";
            this.bnFnt.Size = new System.Drawing.Size(37, 21);
            this.bnFnt.TabIndex = 2;
            this.bnFnt.Text = "...";
            this.bnFnt.UseVisualStyleBackColor = true;
            // 
            // btBac
            // 
            this.btBac.Location = new System.Drawing.Point(377, 100);
            this.btBac.Name = "btBac";
            this.btBac.Size = new System.Drawing.Size(37, 21);
            this.btBac.TabIndex = 2;
            this.btBac.Text = "...";
            this.btBac.UseVisualStyleBackColor = true;
            // 
            // btFor
            // 
            this.btFor.Location = new System.Drawing.Point(377, 127);
            this.btFor.Name = "btFor";
            this.btFor.Size = new System.Drawing.Size(37, 21);
            this.btFor.TabIndex = 2;
            this.btFor.Text = "...";
            this.btFor.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "myPutty Configuration";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBacR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bnFnt;
        private System.Windows.Forms.TextBox tbForB;
        private System.Windows.Forms.TextBox tbBacB;
        private System.Windows.Forms.TextBox tbFntName;
        private System.Windows.Forms.TextBox tbForG;
        private System.Windows.Forms.TextBox tbForR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBacG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btFor;
        private System.Windows.Forms.Button btBac;
        public System.Windows.Forms.ComboBox cbPari;
        public System.Windows.Forms.ComboBox cbStop;
        public System.Windows.Forms.ComboBox cbData;
        public System.Windows.Forms.ComboBox cbBaud;
        public System.Windows.Forms.ComboBox cbPort;
    }
}