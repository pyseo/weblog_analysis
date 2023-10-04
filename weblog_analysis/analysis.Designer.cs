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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Server");
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbLogFiles = new System.Windows.Forms.Label();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로그파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그패턴정의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvServerList = new System.Windows.Forms.TreeView();
            this.ctxmServerTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lvLogFile = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.colCreateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUpdateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.ctxmServerTree.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.btnSearchFilePath.Click += new System.EventHandler(this.btnSearchFilePath_Click);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 578);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 184);
            this.tableLayoutPanel1.TabIndex = 43;
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(174, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 21);
            this.textBox1.TabIndex = 48;
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
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.옵션ToolStripMenuItem,
            this.기타ToolStripMenuItem});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1076, 24);
            this.mnsMain.TabIndex = 44;
            this.mnsMain.Text = "menuStrip1";
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
            this.새로그파일열기ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.새로그파일열기ToolStripMenuItem.Text = "새 로그파일 열기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.닫기ToolStripMenuItem.Text = "닫기";
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
            this.로그패턴정의ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
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
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // tvServerList
            // 
            this.tvServerList.AllowDrop = true;
            this.tvServerList.Location = new System.Drawing.Point(18, 162);
            this.tvServerList.Name = "tvServerList";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode3.Name = "root";
            treeNode3.Text = "Server";
            treeNode3.ToolTipText = "root";
            this.tvServerList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvServerList.Size = new System.Drawing.Size(232, 184);
            this.tvServerList.TabIndex = 45;
            this.tvServerList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvServerList_NodeMouseClick);
            this.tvServerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvServerList_MouseDown);
            // 
            // ctxmServerTree
            // 
            this.ctxmServerTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmiAdd,
            this.ctxmiModify,
            this.ctxmiDelete});
            this.ctxmServerTree.Name = "ctxmServerTree";
            this.ctxmServerTree.Size = new System.Drawing.Size(99, 70);
            // 
            // ctxmiAdd
            // 
            this.ctxmiAdd.Name = "ctxmiAdd";
            this.ctxmiAdd.Size = new System.Drawing.Size(98, 22);
            this.ctxmiAdd.Text = "추가";
            this.ctxmiAdd.Click += new System.EventHandler(this.ctxmiAdd_Click);
            // 
            // ctxmiModify
            // 
            this.ctxmiModify.Name = "ctxmiModify";
            this.ctxmiModify.Size = new System.Drawing.Size(98, 22);
            this.ctxmiModify.Text = "수정";
            this.ctxmiModify.Click += new System.EventHandler(this.ctxmiModify_Click);
            // 
            // ctxmiDelete
            // 
            this.ctxmiDelete.Name = "ctxmiDelete";
            this.ctxmiDelete.Size = new System.Drawing.Size(98, 22);
            this.ctxmiDelete.Text = "삭제";
            this.ctxmiDelete.Click += new System.EventHandler(this.ctxmiDelete_Click);
            // 
            // lvLogFile
            // 
            this.lvLogFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colFilePath,
            this.colFileSize,
            this.colCreateTime,
            this.colUpdateTime});
            this.lvLogFile.HideSelection = false;
            this.lvLogFile.Location = new System.Drawing.Point(256, 162);
            this.lvLogFile.Name = "lvLogFile";
            this.lvLogFile.Size = new System.Drawing.Size(753, 184);
            this.lvLogFile.TabIndex = 46;
            this.lvLogFile.UseCompatibleStateImageBehavior = false;
            this.lvLogFile.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Text = "FileName";
            this.colFileName.Width = 107;
            // 
            // colFilePath
            // 
            this.colFilePath.Text = "FilePath";
            this.colFilePath.Width = 300;
            // 
            // colFileSize
            // 
            this.colFileSize.Text = "FileSize";
            this.colFileSize.Width = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "[Server Structure]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "추가";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "제거";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(801, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "분석";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.42466F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.57534F));
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 359);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(730, 184);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.Location = new System.Drawing.Point(174, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 21);
            this.textBox4.TabIndex = 50;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox5.Location = new System.Drawing.Point(174, 34);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(239, 21);
            this.textBox5.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "ㅇㄹㄹ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "Server Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "Instance Name";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.Location = new System.Drawing.Point(174, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(239, 21);
            this.textBox6.TabIndex = 48;
            // 
            // colCreateTime
            // 
            this.colCreateTime.Text = "CreateTime";
            this.colCreateTime.Width = 105;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Text = "UpdateTime";
            this.colUpdateTime.Width = 103;
            // 
            // analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 774);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvLogFile);
            this.Controls.Add(this.tvServerList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxResultDirectoryPath);
            this.Controls.Add(this.btnSearchFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOriginalFilePath);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "analysis";
            this.Text = "Web Log Analysis";
            this.Load += new System.EventHandler(this.analysis_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ctxmServerTree.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로그파일열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그패턴정의ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.TreeView tvServerList;
        private System.Windows.Forms.ContextMenuStrip ctxmServerTree;
        private System.Windows.Forms.ToolStripMenuItem ctxmiModify;
        private System.Windows.Forms.ToolStripMenuItem ctxmiDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxmiAdd;
        private System.Windows.Forms.ListView lvLogFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colCreateTime;
        private System.Windows.Forms.ColumnHeader colUpdateTime;
    }
}

