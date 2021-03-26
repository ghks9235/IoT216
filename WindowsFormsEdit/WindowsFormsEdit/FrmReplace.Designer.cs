
namespace WindowsFormsEdit
{
    partial class FrmReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRepalce = new System.Windows.Forms.Button();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 문자열";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "바꿀 문자열";
            // 
            // btnRepalce
            // 
            this.btnRepalce.Location = new System.Drawing.Point(330, 83);
            this.btnRepalce.Name = "btnRepalce";
            this.btnRepalce.Size = new System.Drawing.Size(75, 23);
            this.btnRepalce.TabIndex = 2;
            this.btnRepalce.Text = "바꾸기";
            this.btnRepalce.UseVisualStyleBackColor = true;
            this.btnRepalce.Click += new System.EventHandler(this.btnRepalce_Click);
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(180, 78);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(100, 21);
            this.tbOrigin.TabIndex = 3;
            // 
            // tbDest
            // 
            this.tbDest.Location = new System.Drawing.Point(180, 110);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(100, 21);
            this.tbDest.TabIndex = 3;
            // 
            // FrmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 179);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.tbOrigin);
            this.Controls.Add(this.btnRepalce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReplace";
            this.Text = "FrmReplace";
            this.Load += new System.EventHandler(this.FrmReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRepalce;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.TextBox tbDest;
    }
}