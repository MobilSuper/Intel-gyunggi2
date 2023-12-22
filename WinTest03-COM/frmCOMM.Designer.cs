namespace WinTest03_COM
{
    partial class frmCOMM
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTerminal = new System.Windows.Forms.TextBox();
            this.Popup1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Popup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTerminal
            // 
            this.tbTerminal.BackColor = System.Drawing.Color.Black;
            this.tbTerminal.ContextMenuStrip = this.Popup1;
            this.tbTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTerminal.ForeColor = System.Drawing.Color.White;
            this.tbTerminal.Location = new System.Drawing.Point(0, 0);
            this.tbTerminal.Multiline = true;
            this.tbTerminal.Name = "tbTerminal";
            this.tbTerminal.Size = new System.Drawing.Size(800, 450);
            this.tbTerminal.TabIndex = 0;
            // 
            // Popup1
            // 
            this.Popup1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSetup,
            this.MnuRestart});
            this.Popup1.Name = "Popup1";
            this.Popup1.Size = new System.Drawing.Size(111, 48);
            // 
            // MnuSetup
            // 
            this.MnuSetup.Name = "MnuSetup";
            this.MnuSetup.Size = new System.Drawing.Size(110, 22);
            this.MnuSetup.Text = "Setup";
            this.MnuSetup.Click += new System.EventHandler(this.MnuSetup_Click);
            // 
            // MnuRestart
            // 
            this.MnuRestart.Name = "MnuRestart";
            this.MnuRestart.Size = new System.Drawing.Size(110, 22);
            this.MnuRestart.Text = "Restart";
            this.MnuRestart.Click += new System.EventHandler(this.MnuRestart_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frmCOMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTerminal);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmCOMM";
            this.Text = "myPutty ver2.3";
            this.Popup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTerminal;
        private System.Windows.Forms.ContextMenuStrip Popup1;
        private System.Windows.Forms.ToolStripMenuItem MnuSetup;
        private System.Windows.Forms.ToolStripMenuItem MnuRestart;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

