namespace WinTest01_Base
{
    partial class frmTest
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
            this.btnTest = new System.Windows.Forms.Button();
            this.TBox01 = new System.Windows.Forms.TextBox();
            this.TBox02 = new System.Windows.Forms.TextBox();
            this.TBox03 = new System.Windows.Forms.TextBox();
            this.TBox04 = new System.Windows.Forms.TextBox();
            this.PopUp1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLower = new System.Windows.Forms.ToolStripMenuItem();
            this.CTest01 = new System.Windows.Forms.CheckBox();
            this.CTest02 = new System.Windows.Forms.CheckBox();
            this.CTest03 = new System.Windows.Forms.CheckBox();
            this.CMTest01 = new System.Windows.Forms.ComboBox();
            this.CMTest02 = new System.Windows.Forms.ComboBox();
            this.CMTest03 = new System.Windows.Forms.ComboBox();
            this.CMTest04 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSep = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CTest04 = new System.Windows.Forms.CheckBox();
            this.btnSel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileLabel = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.PopUp1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(548, 61);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(102, 21);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // TBox01
            // 
            this.TBox01.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBox01.Location = new System.Drawing.Point(138, 49);
            this.TBox01.Name = "TBox01";
            this.TBox01.Size = new System.Drawing.Size(80, 23);
            this.TBox01.TabIndex = 3;
            // 
            // TBox02
            // 
            this.TBox02.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBox02.Location = new System.Drawing.Point(138, 81);
            this.TBox02.Name = "TBox02";
            this.TBox02.Size = new System.Drawing.Size(80, 23);
            this.TBox02.TabIndex = 3;
            // 
            // TBox03
            // 
            this.TBox03.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBox03.Location = new System.Drawing.Point(138, 113);
            this.TBox03.Name = "TBox03";
            this.TBox03.Size = new System.Drawing.Size(80, 23);
            this.TBox03.TabIndex = 3;
            // 
            // TBox04
            // 
            this.TBox04.ContextMenuStrip = this.PopUp1;
            this.TBox04.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBox04.Location = new System.Drawing.Point(138, 176);
            this.TBox04.Multiline = true;
            this.TBox04.Name = "TBox04";
            this.TBox04.Size = new System.Drawing.Size(183, 169);
            this.TBox04.TabIndex = 3;
            // 
            // PopUp1
            // 
            this.PopUp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUpper,
            this.MnuLower});
            this.PopUp1.Name = "contextMenuStrip1";
            this.PopUp1.Size = new System.Drawing.Size(107, 48);
            // 
            // MnuUpper
            // 
            this.MnuUpper.Name = "MnuUpper";
            this.MnuUpper.Size = new System.Drawing.Size(106, 22);
            this.MnuUpper.Text = "Upper";
            this.MnuUpper.Click += new System.EventHandler(this.MnuUpper_Click);
            // 
            // MnuLower
            // 
            this.MnuLower.Name = "MnuLower";
            this.MnuLower.Size = new System.Drawing.Size(106, 22);
            this.MnuLower.Text = "Lower";
            this.MnuLower.Click += new System.EventHandler(this.MnuLower_Click);
            // 
            // CTest01
            // 
            this.CTest01.AutoSize = true;
            this.CTest01.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CTest01.Location = new System.Drawing.Point(46, 52);
            this.CTest01.Name = "CTest01";
            this.CTest01.Size = new System.Drawing.Size(61, 16);
            this.CTest01.TabIndex = 4;
            this.CTest01.Text = "Test01";
            this.CTest01.UseVisualStyleBackColor = true;
            this.CTest01.CheckedChanged += new System.EventHandler(this.CTest01_CheckedChanged);
            // 
            // CTest02
            // 
            this.CTest02.AutoSize = true;
            this.CTest02.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CTest02.Location = new System.Drawing.Point(46, 84);
            this.CTest02.Name = "CTest02";
            this.CTest02.Size = new System.Drawing.Size(61, 16);
            this.CTest02.TabIndex = 4;
            this.CTest02.Text = "Test02";
            this.CTest02.UseVisualStyleBackColor = true;
            this.CTest02.CheckedChanged += new System.EventHandler(this.CTest02_CheckedChanged);
            // 
            // CTest03
            // 
            this.CTest03.AutoSize = true;
            this.CTest03.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CTest03.Location = new System.Drawing.Point(46, 116);
            this.CTest03.Name = "CTest03";
            this.CTest03.Size = new System.Drawing.Size(61, 16);
            this.CTest03.TabIndex = 4;
            this.CTest03.Text = "Test03";
            this.CTest03.UseVisualStyleBackColor = true;
            this.CTest03.CheckedChanged += new System.EventHandler(this.CTest03_CheckedChanged);
            // 
            // CMTest01
            // 
            this.CMTest01.Enabled = false;
            this.CMTest01.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CMTest01.FormattingEnabled = true;
            this.CMTest01.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.CMTest01.Location = new System.Drawing.Point(224, 51);
            this.CMTest01.Name = "CMTest01";
            this.CMTest01.Size = new System.Drawing.Size(97, 21);
            this.CMTest01.TabIndex = 5;
            this.CMTest01.SelectedIndexChanged += new System.EventHandler(this.CMTest01_SelectedIndexChanged);
            // 
            // CMTest02
            // 
            this.CMTest02.Enabled = false;
            this.CMTest02.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CMTest02.FormattingEnabled = true;
            this.CMTest02.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.CMTest02.Location = new System.Drawing.Point(224, 83);
            this.CMTest02.Name = "CMTest02";
            this.CMTest02.Size = new System.Drawing.Size(97, 21);
            this.CMTest02.TabIndex = 5;
            // 
            // CMTest03
            // 
            this.CMTest03.Enabled = false;
            this.CMTest03.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CMTest03.FormattingEnabled = true;
            this.CMTest03.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.CMTest03.Location = new System.Drawing.Point(224, 115);
            this.CMTest03.Name = "CMTest03";
            this.CMTest03.Size = new System.Drawing.Size(97, 21);
            this.CMTest03.TabIndex = 5;
            // 
            // CMTest04
            // 
            this.CMTest04.Enabled = false;
            this.CMTest04.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CMTest04.FormattingEnabled = true;
            this.CMTest04.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "a",
            "b",
            "c",
            "d",
            "안녕하세요",
            "반갑습니다"});
            this.CMTest04.Location = new System.Drawing.Point(224, 144);
            this.CMTest04.Name = "CMTest04";
            this.CMTest04.Size = new System.Drawing.Size(97, 21);
            this.CMTest04.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNew,
            this.MnuOpen,
            this.MnuSave,
            this.MnuSep,
            this.MnuExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(37, 20);
            this.MnuFile.Text = "File";
            // 
            // MnuNew
            // 
            this.MnuNew.Name = "MnuNew";
            this.MnuNew.Size = new System.Drawing.Size(180, 22);
            this.MnuNew.Text = "New";
            // 
            // MnuOpen
            // 
            this.MnuOpen.Name = "MnuOpen";
            this.MnuOpen.Size = new System.Drawing.Size(180, 22);
            this.MnuOpen.Text = "Open";
            this.MnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // MnuSave
            // 
            this.MnuSave.Name = "MnuSave";
            this.MnuSave.Size = new System.Drawing.Size(180, 22);
            this.MnuSave.Text = "Save";
            // 
            // MnuSep
            // 
            this.MnuSep.Name = "MnuSep";
            this.MnuSep.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "Exit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // CTest04
            // 
            this.CTest04.AutoSize = true;
            this.CTest04.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CTest04.Location = new System.Drawing.Point(46, 147);
            this.CTest04.Name = "CTest04";
            this.CTest04.Size = new System.Drawing.Size(61, 16);
            this.CTest04.TabIndex = 4;
            this.CTest04.Text = "Test04";
            this.CTest04.UseVisualStyleBackColor = true;
            this.CTest04.CheckedChanged += new System.EventHandler(this.CTest04_CheckedChanged);
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(548, 98);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(102, 21);
            this.btnSel.TabIndex = 1;
            this.btnSel.Text = "Select";
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(47, 361);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(60, 12);
            this.FileLabel.TabIndex = 7;
            this.FileLabel.Text = "SelectFile";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(138, 358);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(553, 21);
            this.tbFileName.TabIndex = 8;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.CMTest04);
            this.Controls.Add(this.CMTest03);
            this.Controls.Add(this.CMTest02);
            this.Controls.Add(this.CMTest01);
            this.Controls.Add(this.CTest04);
            this.Controls.Add(this.CTest03);
            this.Controls.Add(this.CTest02);
            this.Controls.Add(this.CTest01);
            this.Controls.Add(this.TBox04);
            this.Controls.Add(this.TBox03);
            this.Controls.Add(this.TBox02);
            this.Controls.Add(this.TBox01);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTest";
            this.Text = "Form1";
            this.PopUp1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox TBox01;
        private System.Windows.Forms.TextBox TBox02;
        private System.Windows.Forms.TextBox TBox03;
        private System.Windows.Forms.TextBox TBox04;
        private System.Windows.Forms.CheckBox CTest01;
        private System.Windows.Forms.CheckBox CTest02;
        private System.Windows.Forms.CheckBox CTest03;
        private System.Windows.Forms.ComboBox CMTest01;
        private System.Windows.Forms.ComboBox CMTest02;
        private System.Windows.Forms.ComboBox CMTest03;
        private System.Windows.Forms.ComboBox CMTest04;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuNew;
        private System.Windows.Forms.ToolStripMenuItem MnuOpen;
        private System.Windows.Forms.ToolStripMenuItem MnuSave;
        private System.Windows.Forms.ToolStripSeparator MnuSep;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.CheckBox CTest04;
        private System.Windows.Forms.ContextMenuStrip PopUp1;
        private System.Windows.Forms.ToolStripMenuItem MnuUpper;
        private System.Windows.Forms.ToolStripMenuItem MnuLower;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox tbFileName;
    }
}

