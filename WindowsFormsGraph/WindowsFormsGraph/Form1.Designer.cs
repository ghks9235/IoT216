
namespace WindowsFormsGraph
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDrew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawPen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawArc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuErase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpction = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbPanal1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanal2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanal3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPanal4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CanvasDrew = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDrew)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrew,
            this.mnuDrawStop,
            this.mnuErase,
            this.mnuOpction});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 92);
            // 
            // mnuDrew
            // 
            this.mnuDrew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDrawPen,
            this.mnuDrawCircle,
            this.mnuDrawArc,
            this.mnuDrawLine});
            this.mnuDrew.Name = "mnuDrew";
            this.mnuDrew.Size = new System.Drawing.Size(138, 22);
            this.mnuDrew.Text = "그리기";
            // 
            // mnuDrawPen
            // 
            this.mnuDrawPen.Name = "mnuDrawPen";
            this.mnuDrawPen.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawPen.Text = "연필 그리기";
            this.mnuDrawPen.Click += new System.EventHandler(this.mnuDrawPen_Click);
            // 
            // mnuDrawCircle
            // 
            this.mnuDrawCircle.Name = "mnuDrawCircle";
            this.mnuDrawCircle.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawCircle.Text = "원 그리기";
            this.mnuDrawCircle.Click += new System.EventHandler(this.mnuDrawCircle_Click);
            // 
            // mnuDrawArc
            // 
            this.mnuDrawArc.Name = "mnuDrawArc";
            this.mnuDrawArc.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawArc.Text = "호(Arc) 그리기";
            this.mnuDrawArc.Click += new System.EventHandler(this.mnuDrawArc_Click);
            // 
            // mnuDrawLine
            // 
            this.mnuDrawLine.Name = "mnuDrawLine";
            this.mnuDrawLine.Size = new System.Drawing.Size(180, 22);
            this.mnuDrawLine.Text = "Line 그리기";
            this.mnuDrawLine.Click += new System.EventHandler(this.mnuDrawLine_Click);
            // 
            // mnuDrawStop
            // 
            this.mnuDrawStop.Name = "mnuDrawStop";
            this.mnuDrawStop.Size = new System.Drawing.Size(138, 22);
            this.mnuDrawStop.Text = "그리기 중지";
            this.mnuDrawStop.Click += new System.EventHandler(this.mnuDrawStop_Click);
            // 
            // mnuErase
            // 
            this.mnuErase.Name = "mnuErase";
            this.mnuErase.Size = new System.Drawing.Size(138, 22);
            this.mnuErase.Text = "모두 지우기";
            this.mnuErase.Click += new System.EventHandler(this.mnuErase_Click);
            // 
            // mnuOpction
            // 
            this.mnuOpction.Name = "mnuOpction";
            this.mnuOpction.Size = new System.Drawing.Size(138, 22);
            this.mnuOpction.Text = "옵션";
            this.mnuOpction.Click += new System.EventHandler(this.mnuOpction_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbPanal1,
            this.sbPanal2,
            this.sbPanal3,
            this.sbPanal4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(862, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbPanal1
            // 
            this.sbPanal1.Name = "sbPanal1";
            this.sbPanal1.Size = new System.Drawing.Size(24, 17);
            this.sbPanal1.Text = "0,0";
            // 
            // sbPanal2
            // 
            this.sbPanal2.Name = "sbPanal2";
            this.sbPanal2.Size = new System.Drawing.Size(0, 17);
            // 
            // sbPanal3
            // 
            this.sbPanal3.Name = "sbPanal3";
            this.sbPanal3.Size = new System.Drawing.Size(0, 17);
            // 
            // sbPanal4
            // 
            this.sbPanal4.Name = "sbPanal4";
            this.sbPanal4.Size = new System.Drawing.Size(0, 17);
            // 
            // CanvasDrew
            // 
            this.CanvasDrew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasDrew.ContextMenuStrip = this.contextMenuStrip1;
            this.CanvasDrew.Location = new System.Drawing.Point(28, 41);
            this.CanvasDrew.Name = "CanvasDrew";
            this.CanvasDrew.Size = new System.Drawing.Size(755, 506);
            this.CanvasDrew.TabIndex = 2;
            this.CanvasDrew.TabStop = false;
            this.CanvasDrew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CanvasDrew_MouseDown);
            this.CanvasDrew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CanvasDrew_MouseMove);
            this.CanvasDrew.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CanvasDrew_MouseUp);
            this.CanvasDrew.Resize += new System.EventHandler(this.CanvasDrew_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 591);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.CanvasDrew);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "그림판";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CanvasDrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDrew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox CanvasDrew;
        private System.Windows.Forms.ToolStripMenuItem mnuErase;
        private System.Windows.Forms.ToolStripMenuItem mnuOpction;
        private System.Windows.Forms.ToolStripStatusLabel sbPanal1;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawPen;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawCircle;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawArc;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawLine;
        private System.Windows.Forms.ToolStripStatusLabel sbPanal2;
        private System.Windows.Forms.ToolStripStatusLabel sbPanal3;
        private System.Windows.Forms.ToolStripStatusLabel sbPanal4;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawStop;
    }
}

