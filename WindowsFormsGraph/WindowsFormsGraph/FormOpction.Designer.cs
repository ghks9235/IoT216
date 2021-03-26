
namespace WindowsFormsGraph
{
    partial class FormOpction
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbThick = new System.Windows.Forms.TextBox();
            this.tbYasis = new System.Windows.Forms.TextBox();
            this.tbXasis = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "X-Asis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbThick);
            this.groupBox1.Controls.Add(this.tbYasis);
            this.groupBox1.Controls.Add(this.tbXasis);
            this.groupBox1.Location = new System.Drawing.Point(48, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "원그리기";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thickness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y-Asis";
            // 
            // tbThick
            // 
            this.tbThick.Location = new System.Drawing.Point(94, 70);
            this.tbThick.Name = "tbThick";
            this.tbThick.Size = new System.Drawing.Size(100, 21);
            this.tbThick.TabIndex = 0;
            // 
            // tbYasis
            // 
            this.tbYasis.Location = new System.Drawing.Point(94, 43);
            this.tbYasis.Name = "tbYasis";
            this.tbYasis.Size = new System.Drawing.Size(100, 21);
            this.tbYasis.TabIndex = 0;
            // 
            // tbXasis
            // 
            this.tbXasis.Location = new System.Drawing.Point(94, 10);
            this.tbXasis.Name = "tbXasis";
            this.tbXasis.Size = new System.Drawing.Size(100, 21);
            this.tbXasis.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(196, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(302, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.tbColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(302, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Color";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(66, 29);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 21);
            this.tbColor.TabIndex = 1;
            this.tbColor.Text = "ff0000";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(172, 31);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(32, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // FormOpction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 250);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOpction";
            this.Text = "FormOpction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOpction_FormClosing);
            this.Load += new System.EventHandler(this.FormOpction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYasis;
        private System.Windows.Forms.TextBox tbXasis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbThick;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}