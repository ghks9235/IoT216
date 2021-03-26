
namespace DBManager
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbPanel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sbPannel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMygration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDBOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditColAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRowAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExecsql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelsql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnterKey = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.tbsql = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mnuNewTable = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPanel1,
            this.sbButton1,
            this.sbPannel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(986, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbPanel1
            // 
            this.sbPanel1.Name = "sbPanel1";
            this.sbPanel1.Size = new System.Drawing.Size(45, 17);
            this.sbPanel1.Text = "DB File";
            // 
            // sbButton1
            // 
            this.sbButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbButton1.Name = "sbButton1";
            this.sbButton1.Size = new System.Drawing.Size(84, 20);
            this.sbButton1.Text = "Table Name";
            this.sbButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.sbButton1_DropDownItemClicked);
            // 
            // sbPannel2
            // 
            this.sbPannel2.Name = "sbPannel2";
            this.sbPannel2.Size = new System.Drawing.Size(53, 17);
            this.sbPannel2.Text = "Message";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.mnuMygration,
            this.toolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.mnuDBOpen,
            this.mnuDBClose,
            this.mnuUpdate,
            this.mnuNewTable,
            this.toolStripMenuItem3,
            this.종료ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // mnuMygration
            // 
            this.mnuMygration.Name = "mnuMygration";
            this.mnuMygration.Size = new System.Drawing.Size(180, 22);
            this.mnuMygration.Text = "Mygration";
            this.mnuMygration.Click += new System.EventHandler(this.mnuMygration_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as..";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuDBOpen
            // 
            this.mnuDBOpen.Name = "mnuDBOpen";
            this.mnuDBOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuDBOpen.Text = "Database 열기";
            this.mnuDBOpen.Click += new System.EventHandler(this.mnuDBOpen_Click);
            // 
            // mnuDBClose
            // 
            this.mnuDBClose.Name = "mnuDBClose";
            this.mnuDBClose.Size = new System.Drawing.Size(180, 22);
            this.mnuDBClose.Text = "Database 닫기";
            this.mnuDBClose.Click += new System.EventHandler(this.mnuDBClose_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdate.Text = "DB Update";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditColAdd,
            this.mnuEditRowAdd});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuEditColAdd
            // 
            this.mnuEditColAdd.Name = "mnuEditColAdd";
            this.mnuEditColAdd.Size = new System.Drawing.Size(145, 22);
            this.mnuEditColAdd.Text = "Column 추가";
            this.mnuEditColAdd.Click += new System.EventHandler(this.mnuEditColAdd_Click);
            // 
            // mnuEditRowAdd
            // 
            this.mnuEditRowAdd.Name = "mnuEditRowAdd";
            this.mnuEditRowAdd.Size = new System.Drawing.Size(145, 22);
            this.mnuEditRowAdd.Text = "Row 추가";
            this.mnuEditRowAdd.Click += new System.EventHandler(this.mnuEditRowAdd_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExecsql,
            this.mnuSelsql,
            this.mnuEnterKey});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // mnuExecsql
            // 
            this.mnuExecsql.Name = "mnuExecsql";
            this.mnuExecsql.ShortcutKeyDisplayString = "";
            this.mnuExecsql.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuExecsql.Size = new System.Drawing.Size(164, 22);
            this.mnuExecsql.Text = "Execute sql";
            this.mnuExecsql.Click += new System.EventHandler(this.mnuExecsql_Click);
            // 
            // mnuSelsql
            // 
            this.mnuSelsql.Name = "mnuSelsql";
            this.mnuSelsql.Size = new System.Drawing.Size(164, 22);
            this.mnuSelsql.Text = "exec selected sql";
            this.mnuSelsql.Click += new System.EventHandler(this.mnuSelsql_Click);
            // 
            // mnuEnterKey
            // 
            this.mnuEnterKey.Checked = true;
            this.mnuEnterKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuEnterKey.Name = "mnuEnterKey";
            this.mnuEnterKey.Size = new System.Drawing.Size(164, 22);
            this.mnuEnterKey.Text = "Excute for Enter";
            this.mnuEnterKey.Click += new System.EventHandler(this.mnuEnterKey_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(14, 14);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(879, 231);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellEndEdit);
            // 
            // tbsql
            // 
            this.tbsql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbsql.Location = new System.Drawing.Point(14, 15);
            this.tbsql.Multiline = true;
            this.tbsql.Name = "tbsql";
            this.tbsql.Size = new System.Drawing.Size(879, 138);
            this.tbsql.TabIndex = 3;
            this.tbsql.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbsql_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ValidateNames = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 474);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(39, 51);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbsql);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(913, 426);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 5;
            // 
            // mnuNewTable
            // 
            this.mnuNewTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuNewTable.Name = "mnuNewTable";
            this.mnuNewTable.Size = new System.Drawing.Size(180, 22);
            this.mnuNewTable.Text = "신규 Table 저장";
            this.mnuNewTable.Click += new System.EventHandler(this.mnuNewTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 520);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DBManager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMygration;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox tbsql;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDBOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel1;
        private System.Windows.Forms.ToolStripStatusLabel sbPannel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExecsql;
        private System.Windows.Forms.ToolStripMenuItem mnuSelsql;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripDropDownButton sbButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditColAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRowAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEnterKey;
        private System.Windows.Forms.ToolStripMenuItem mnuDBClose;
        public System.Windows.Forms.ToolStripMenuItem mnuNewTable;
    }
}

