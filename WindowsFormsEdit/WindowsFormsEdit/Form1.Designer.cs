
namespace WindowsFormsEdit
{
    partial class Form1
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditContinue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFont = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.MnuEdit,
            this.mnuView,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(773, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(103, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(103, 22);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // MnuEdit
            // 
            this.MnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditSearch,
            this.mnuEditContinue,
            this.mnuEditReplace});
            this.MnuEdit.Name = "MnuEdit";
            this.MnuEdit.Size = new System.Drawing.Size(39, 20);
            this.MnuEdit.Text = "Edit";
            // 
            // mnuEditSearch
            // 
            this.mnuEditSearch.Name = "mnuEditSearch";
            this.mnuEditSearch.ShortcutKeyDisplayString = "";
            this.mnuEditSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEditSearch.Size = new System.Drawing.Size(197, 22);
            this.mnuEditSearch.Text = "찾기";
            this.mnuEditSearch.ToolTipText = "현재의 문서에서 특정한 문자열을 찾습니다";
            this.mnuEditSearch.Click += new System.EventHandler(this.mnuEditSearch_Click);
            // 
            // mnuEditContinue
            // 
            this.mnuEditContinue.Name = "mnuEditContinue";
            this.mnuEditContinue.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuEditContinue.Size = new System.Drawing.Size(197, 22);
            this.mnuEditContinue.Text = "다음 찾기";
            this.mnuEditContinue.Click += new System.EventHandler(this.mnuEditContinue_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewFont});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(45, 20);
            this.mnuView.Text = "View";
            // 
            // mnuViewFont
            // 
            this.mnuViewFont.Name = "mnuViewFont";
            this.mnuViewFont.Size = new System.Drawing.Size(180, 22);
            this.mnuViewFont.Text = "Font";
            this.mnuViewFont.Click += new System.EventHandler(this.mnuViewFont_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tbMemo
            // 
            this.tbMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMemo.Location = new System.Drawing.Point(12, 36);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMemo.Size = new System.Drawing.Size(737, 362);
            this.tbMemo.TabIndex = 3;
            this.tbMemo.TextChanged += new System.EventHandler(this.tbMemo_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbLabel1,
            this.sbLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbLabel1
            // 
            this.sbLabel1.Name = "sbLabel1";
            this.sbLabel1.Size = new System.Drawing.Size(65, 17);
            this.sbLabel1.Text = "Font name";
            this.sbLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // sbLabel2
            // 
            this.sbLabel2.Name = "sbLabel2";
            this.sbLabel2.Size = new System.Drawing.Size(27, 17);
            this.sbLabel2.Text = "size";
            // 
            // mnuEditReplace
            // 
            this.mnuEditReplace.Name = "mnuEditReplace";
            this.mnuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.mnuEditReplace.Size = new System.Drawing.Size(197, 22);
            this.mnuEditReplace.Text = "찾기 및 바꾸기";
            this.mnuEditReplace.Click += new System.EventHandler(this.mnuEditReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Form1";
            this.Text = "YourEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem MnuEdit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFont;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sbLabel2;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuEditContinue;
        private System.Windows.Forms.ToolStripMenuItem mnuEditReplace;
    }
}

