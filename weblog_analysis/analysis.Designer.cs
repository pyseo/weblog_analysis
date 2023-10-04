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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Server");
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUpdateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIncludePattern = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbExcludePattern = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxAnalysisTerm = new System.Windows.Forms.ComboBox();
            this.mnsMain.SuspendLayout();
            this.ctxmServerTree.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.tvServerList.Location = new System.Drawing.Point(18, 61);
            this.tvServerList.Name = "tvServerList";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode1.Name = "root";
            treeNode1.Text = "Server";
            treeNode1.ToolTipText = "root";
            this.tvServerList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvServerList.Size = new System.Drawing.Size(218, 184);
            this.tvServerList.TabIndex = 45;
            this.tvServerList.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvServerList_AfterLabelEdit);
            this.tvServerList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvServerList_AfterSelect);
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
            this.lvLogFile.CheckBoxes = true;
            this.lvLogFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.colFileName,
            this.colFilePath,
            this.colFileSize,
            this.colCreateTime,
            this.colUpdateTime});
            this.lvLogFile.FullRowSelect = true;
            this.lvLogFile.GridLines = true;
            this.lvLogFile.HideSelection = false;
            this.lvLogFile.Location = new System.Drawing.Point(241, 61);
            this.lvLogFile.Name = "lvLogFile";
            this.lvLogFile.OwnerDraw = true;
            this.lvLogFile.Size = new System.Drawing.Size(768, 184);
            this.lvLogFile.TabIndex = 46;
            this.lvLogFile.UseCompatibleStateImageBehavior = false;
            this.lvLogFile.View = System.Windows.Forms.View.Details;
            this.lvLogFile.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLogFile_ColumnClick);
            this.lvLogFile.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvLogFile_DrawColumnHeader);
            this.lvLogFile.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvLogFile_DrawItem);
            this.lvLogFile.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvLogFile_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 30;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "[Server Log Files]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "파일추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSearchFilePath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "제거";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(943, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "분석";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.tableLayoutPanel2.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(104, 54);
            this.label3.TabIndex = 44;
            this.label3.Text = "df";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIncludePattern
            // 
            this.tbIncludePattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIncludePattern.Location = new System.Drawing.Point(223, 64);
            this.tbIncludePattern.Name = "tbIncludePattern";
            this.tbIncludePattern.Size = new System.Drawing.Size(380, 21);
            this.tbIncludePattern.TabIndex = 50;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.cbxAnalysisTerm, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbIncludePattern, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbExcludePattern, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(991, 184);
            this.tableLayoutPanel2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.tableLayoutPanel2.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(104, 54);
            this.label4.TabIndex = 51;
            this.label4.Text = "Content Pattern";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "Analysis Term";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "Include Pattern";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 12);
            this.label9.TabIndex = 54;
            this.label9.Text = "Exclude Pattern";
            // 
            // tbExcludePattern
            // 
            this.tbExcludePattern.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbExcludePattern.Location = new System.Drawing.Point(223, 94);
            this.tbExcludePattern.Name = "tbExcludePattern";
            this.tbExcludePattern.Size = new System.Drawing.Size(380, 21);
            this.tbExcludePattern.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "[Option]";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(943, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 23);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxAnalysisTerm
            // 
            this.cbxAnalysisTerm.FormattingEnabled = true;
            this.cbxAnalysisTerm.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "60"});
            this.cbxAnalysisTerm.Location = new System.Drawing.Point(223, 33);
            this.cbxAnalysisTerm.Name = "cbxAnalysisTerm";
            this.cbxAnalysisTerm.Size = new System.Drawing.Size(61, 20);
            this.cbxAnalysisTerm.TabIndex = 54;
            // 
            // analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 629);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvLogFile);
            this.Controls.Add(this.tvServerList);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "analysis";
            this.Text = "Web Log Analysis";
            this.Load += new System.EventHandler(this.analysis_Load);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ctxmServerTree.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.ColumnHeader colFileSize;
        private System.Windows.Forms.ColumnHeader colCreateTime;
        private System.Windows.Forms.ColumnHeader colUpdateTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbIncludePattern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbExcludePattern;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxAnalysisTerm;
    }
}

