
namespace DBManagerEX
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileMygration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.dropColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.excuteForEnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sbPanel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.excuteToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileMygration,
            this.mnuFileSave,
            this.toolStripMenuItem1,
            this.openDataBaseToolStripMenuItem,
            this.closeDataBaseToolStripMenuItem,
            this.toolStripMenuItem2,
            this.createTableToolStripMenuItem,
            this.updateTableToolStripMenuItem,
            this.toolStripMenuItem5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(180, 22);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileMygration
            // 
            this.mnuFileMygration.Name = "mnuFileMygration";
            this.mnuFileMygration.Size = new System.Drawing.Size(180, 22);
            this.mnuFileMygration.Text = "Open (Mygration)";
            this.mnuFileMygration.Click += new System.EventHandler(this.mnuFileMygration_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save(CSV)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // openDataBaseToolStripMenuItem
            // 
            this.openDataBaseToolStripMenuItem.Name = "openDataBaseToolStripMenuItem";
            this.openDataBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openDataBaseToolStripMenuItem.Text = "Open DataBase";
            // 
            // closeDataBaseToolStripMenuItem
            // 
            this.closeDataBaseToolStripMenuItem.Name = "closeDataBaseToolStripMenuItem";
            this.closeDataBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeDataBaseToolStripMenuItem.Text = "Close DataBase";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createTableToolStripMenuItem.Text = "Create Table";
            // 
            // updateTableToolStripMenuItem
            // 
            this.updateTableToolStripMenuItem.Name = "updateTableToolStripMenuItem";
            this.updateTableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateTableToolStripMenuItem.Text = "Update Table";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem,
            this.addRowToolStripMenuItem,
            this.toolStripMenuItem3,
            this.dropColumnToolStripMenuItem,
            this.dropRowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addColumnToolStripMenuItem.Text = "Add Column";
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            this.addRowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addRowToolStripMenuItem.Text = "Add Row";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // dropColumnToolStripMenuItem
            // 
            this.dropColumnToolStripMenuItem.Name = "dropColumnToolStripMenuItem";
            this.dropColumnToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dropColumnToolStripMenuItem.Text = "Drop Column";
            // 
            // dropRowToolStripMenuItem
            // 
            this.dropRowToolStripMenuItem.Name = "dropRowToolStripMenuItem";
            this.dropRowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dropRowToolStripMenuItem.Text = "Drop Row";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // excuteToolStripMenuItem
            // 
            this.excuteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSqlToolStripMenuItem,
            this.toolStripMenuItem4,
            this.excuteForEnterToolStripMenuItem});
            this.excuteToolStripMenuItem.Name = "excuteToolStripMenuItem";
            this.excuteToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excuteToolStripMenuItem.Text = "Excute";
            // 
            // runSqlToolStripMenuItem
            // 
            this.runSqlToolStripMenuItem.Name = "runSqlToolStripMenuItem";
            this.runSqlToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.runSqlToolStripMenuItem.Text = "Run Sql";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(156, 6);
            // 
            // excuteForEnterToolStripMenuItem
            // 
            this.excuteForEnterToolStripMenuItem.Checked = true;
            this.excuteForEnterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excuteForEnterToolStripMenuItem.Name = "excuteForEnterToolStripMenuItem";
            this.excuteForEnterToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.excuteForEnterToolStripMenuItem.Text = "Excute for Enter";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPanel1,
            this.sbPanel2,
            this.sbPanel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(800, 404);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.Size = new System.Drawing.Size(794, 236);
            this.dataGrid.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(794, 152);
            this.textBox1.TabIndex = 0;
            // 
            // sbPanel1
            // 
            this.sbPanel1.Name = "sbPanel1";
            this.sbPanel1.Size = new System.Drawing.Size(121, 17);
            this.sbPanel1.Text = "toolStripStatusLabel1";
            // 
            // sbPanel3
            // 
            this.sbPanel3.Name = "sbPanel3";
            this.sbPanel3.Size = new System.Drawing.Size(121, 17);
            this.sbPanel3.Text = "toolStripStatusLabel2";
            // 
            // sbPanel2
            // 
            this.sbPanel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sbPanel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbPanel2.Name = "sbPanel2";
            this.sbPanel2.Size = new System.Drawing.Size(168, 20);
            this.sbPanel2.Text = "toolStripDropDownButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DBManager v2.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileMygration;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excuteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dropColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem excuteForEnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel1;
        private System.Windows.Forms.ToolStripDropDownButton sbPanel2;
        private System.Windows.Forms.ToolStripStatusLabel sbPanel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}

