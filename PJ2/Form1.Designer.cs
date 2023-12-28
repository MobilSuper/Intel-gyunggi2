namespace PJ2
{
    partial class Address
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.주소록에서삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPhoneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewAddressTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새주소록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.주소록저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주소록122정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.findName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.findPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.findAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "주소록 1.22";
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataView.Location = new System.Drawing.Point(12, 222);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 23;
            this.dataView.Size = new System.Drawing.Size(776, 192);
            this.dataView.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주소록에서삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 26);
            // 
            // 주소록에서삭제ToolStripMenuItem
            // 
            this.주소록에서삭제ToolStripMenuItem.Name = "주소록에서삭제ToolStripMenuItem";
            this.주소록에서삭제ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.주소록에서삭제ToolStripMenuItem.Text = "주소록에서 삭제";
            // 
            // NewNameTB
            // 
            this.NewNameTB.Location = new System.Drawing.Point(116, 111);
            this.NewNameTB.Name = "NewNameTB";
            this.NewNameTB.Size = new System.Drawing.Size(126, 21);
            this.NewNameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "전화번호";
            // 
            // NewPhoneTB
            // 
            this.NewPhoneTB.Location = new System.Drawing.Point(116, 148);
            this.NewPhoneTB.Name = "NewPhoneTB";
            this.NewPhoneTB.Size = new System.Drawing.Size(126, 21);
            this.NewPhoneTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "주소";
            // 
            // NewAddressTB
            // 
            this.NewAddressTB.Location = new System.Drawing.Point(116, 183);
            this.NewAddressTB.Name = "NewAddressTB";
            this.NewAddressTB.Size = new System.Drawing.Size(126, 21);
            this.NewAddressTB.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(29, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "신규";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(260, 185);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(63, 19);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "추가";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.관리ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새주소록ToolStripMenuItem,
            this.mnuLoad,
            this.주소록저장ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새주소록ToolStripMenuItem
            // 
            this.새주소록ToolStripMenuItem.Name = "새주소록ToolStripMenuItem";
            this.새주소록ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.새주소록ToolStripMenuItem.Text = "새 주소록";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(162, 22);
            this.mnuLoad.Text = "주소록 불러오기";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // 주소록저장ToolStripMenuItem
            // 
            this.주소록저장ToolStripMenuItem.Name = "주소록저장ToolStripMenuItem";
            this.주소록저장ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.주소록저장ToolStripMenuItem.Text = "주소록 저장";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(162, 22);
            this.mnuExit.Text = "종료";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDelete});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(180, 22);
            this.mnuDelete.Text = "주소 삭제";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주소록122정보ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 주소록122정보ToolStripMenuItem
            // 
            this.주소록122정보ToolStripMenuItem.Name = "주소록122정보ToolStripMenuItem";
            this.주소록122정보ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.주소록122정보ToolStripMenuItem.Text = "주소록 1.22 정보";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stLabel1
            // 
            this.stLabel1.AutoSize = false;
            this.stLabel1.Name = "stLabel1";
            this.stLabel1.Size = new System.Drawing.Size(200, 17);
            this.stLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(414, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "찾기";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ValidateNames = false;
            // 
            // findName
            // 
            this.findName.Location = new System.Drawing.Point(499, 111);
            this.findName.Name = "findName";
            this.findName.Size = new System.Drawing.Size(126, 21);
            this.findName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "이름";
            // 
            // findPhone
            // 
            this.findPhone.Location = new System.Drawing.Point(499, 148);
            this.findPhone.Name = "findPhone";
            this.findPhone.Size = new System.Drawing.Size(126, 21);
            this.findPhone.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "전화번호";
            // 
            // findAddress
            // 
            this.findAddress.Location = new System.Drawing.Point(499, 183);
            this.findAddress.Name = "findAddress";
            this.findAddress.Size = new System.Drawing.Size(126, 21);
            this.findAddress.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "주소";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(651, 185);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(63, 19);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "찾기";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.findAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewAddressTB);
            this.Controls.Add(this.findPhone);
            this.Controls.Add(this.NewPhoneTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findName);
            this.Controls.Add(this.NewNameTB);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Address";
            this.Text = "주소록 1.22";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox NewNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPhoneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewAddressTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새주소록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem 주소록저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주소록122정보ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stLabel1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox findName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox findPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox findAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 주소록에서삭제ToolStripMenuItem;
    }
}

