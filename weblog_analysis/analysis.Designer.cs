namespace weblog_analysis
{
    partial class analysis
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
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxResultDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnSearchFilePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOriginalFilePath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbSiteNm = new System.Windows.Forms.Label();
            this.lbServerNm = new System.Windows.Forms.Label();
            this.lbInstanceNm = new System.Windows.Forms.Label();
            this.lbLogFiles = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로그파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그패턴정의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(652, 65);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(66, 23);
            this.btnSelectDirectory.TabIndex = 42;
            this.btnSelectDirectory.Text = "폴더지정";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "결과폴더경로";
            // 
            // tbxResultDirectoryPath
            // 
            this.tbxResultDirectoryPath.Location = new System.Drawing.Point(110, 64);
            this.tbxResultDirectoryPath.Name = "tbxResultDirectoryPath";
            this.tbxResultDirectoryPath.Size = new System.Drawing.Size(536, 21);
            this.tbxResultDirectoryPath.TabIndex = 40;
            // 
            // btnSearchFilePath
            // 
            this.btnSearchFilePath.Location = new System.Drawing.Point(652, 35);
            this.btnSearchFilePath.Name = "btnSearchFilePath";
            this.btnSearchFilePath.Size = new System.Drawing.Size(66, 23);
            this.btnSearchFilePath.TabIndex = 39;
            this.btnSearchFilePath.Text = "파일찾기";
            this.btnSearchFilePath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "로그파일경로";
            // 
            // tbxOriginalFilePath
            // 
            this.tbxOriginalFilePath.Location = new System.Drawing.Point(110, 34);
            this.tbxOriginalFilePath.Name = "tbxOriginalFilePath";
            this.tbxOriginalFilePath.Size = new System.Drawing.Size(536, 21);
            this.tbxOriginalFilePath.TabIndex = 37;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42466F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.57534F));
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbSiteNm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbServerNm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbInstanceNm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLogFiles, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 184);
            this.tableLayoutPanel1.TabIndex = 43;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox3.Location = new System.Drawing.Point(174, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 21);
            this.textBox3.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(174, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 21);
            this.textBox2.TabIndex = 49;
            // 
            // lbSiteNm
            // 
            this.lbSiteNm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSiteNm.AutoSize = true;
            this.lbSiteNm.Location = new System.Drawing.Point(3, 9);
            this.lbSiteNm.Name = "lbSiteNm";
            this.lbSiteNm.Size = new System.Drawing.Size(64, 12);
            this.lbSiteNm.TabIndex = 44;
            this.lbSiteNm.Text = "Site Name";
            // 
            // lbServerNm
            // 
            this.lbServerNm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbServerNm.AutoSize = true;
            this.lbServerNm.Location = new System.Drawing.Point(3, 39);
            this.lbServerNm.Name = "lbServerNm";
            this.lbServerNm.Size = new System.Drawing.Size(79, 12);
            this.lbServerNm.TabIndex = 45;
            this.lbServerNm.Text = "Server Name";
            // 
            // lbInstanceNm
            // 
            this.lbInstanceNm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbInstanceNm.AutoSize = true;
            this.lbInstanceNm.Location = new System.Drawing.Point(3, 69);
            this.lbInstanceNm.Name = "lbInstanceNm";
            this.lbInstanceNm.Size = new System.Drawing.Size(91, 12);
            this.lbInstanceNm.TabIndex = 46;
            this.lbInstanceNm.Text = "Instance Name";
            // 
            // lbLogFiles
            // 
            this.lbLogFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLogFiles.AutoSize = true;
            this.lbLogFiles.Location = new System.Drawing.Point(3, 146);
            this.lbLogFiles.Name = "lbLogFiles";
            this.lbLogFiles.Size = new System.Drawing.Size(57, 12);
            this.lbLogFiles.TabIndex = 47;
            this.lbLogFiles.Text = "Log Files";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(174, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 48;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.옵션ToolStripMenuItem,
            this.기타ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로그파일열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.닫기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로그파일열기ToolStripMenuItem
            // 
            this.새로그파일열기ToolStripMenuItem.Name = "새로그파일열기ToolStripMenuItem";
            this.새로그파일열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새로그파일열기ToolStripMenuItem.Text = "새 로그파일 열기";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그패턴정의ToolStripMenuItem});
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.옵션ToolStripMenuItem.Text = "옵션";
            // 
            // 로그패턴정의ToolStripMenuItem
            // 
            this.로그패턴정의ToolStripMenuItem.Name = "로그패턴정의ToolStripMenuItem";
            this.로그패턴정의ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.로그패턴정의ToolStripMenuItem.Text = "로그 패턴 정의";
            // 
            // 기타ToolStripMenuItem
            // 
            this.기타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정보ToolStripMenuItem});
            this.기타ToolStripMenuItem.Name = "기타ToolStripMenuItem";
            this.기타ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.기타ToolStripMenuItem.Text = "기타";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.닫기ToolStripMenuItem.Text = "닫기";
            // 
            // analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxResultDirectoryPath);
            this.Controls.Add(this.btnSearchFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOriginalFilePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "analysis";
            this.Text = "Web Log Analysis";
            this.Load += new System.EventHandler(this.analysis_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxResultDirectoryPath;
        private System.Windows.Forms.Button btnSearchFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOriginalFilePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbSiteNm;
        private System.Windows.Forms.Label lbServerNm;
        private System.Windows.Forms.Label lbInstanceNm;
        private System.Windows.Forms.Label lbLogFiles;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로그파일열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그패턴정의ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
    }
}

