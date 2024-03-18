namespace Lab1_22520117
{
    partial class Bai6
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
            this.label3 = new System.Windows.Forms.Label();
            this.btzodiac = new System.Windows.Forms.Button();
            this.txtzodiac = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(68, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm";
            // 
            // btzodiac
            // 
            this.btzodiac.Location = new System.Drawing.Point(204, 188);
            this.btzodiac.Name = "btzodiac";
            this.btzodiac.Size = new System.Drawing.Size(399, 23);
            this.btzodiac.TabIndex = 6;
            this.btzodiac.Text = "Cung hoàng đạo của bạn là ";
            this.btzodiac.UseVisualStyleBackColor = true;
            this.btzodiac.Click += new System.EventHandler(this.btzodiac_Click);
            // 
            // txtzodiac
            // 
            this.txtzodiac.Location = new System.Drawing.Point(321, 259);
            this.txtzodiac.Name = "txtzodiac";
            this.txtzodiac.Size = new System.Drawing.Size(193, 20);
            this.txtzodiac.TabIndex = 7;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(120, 97);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(100, 20);
            this.txtd.TabIndex = 8;
            this.txtd.TextChanged += new System.EventHandler(this.txtd_TextChanged);
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(387, 96);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 20);
            this.txtm.TabIndex = 9;
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(655, 96);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(100, 20);
            this.txty.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txtzodiac);
            this.Controls.Add(this.btzodiac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btzodiac;
        private System.Windows.Forms.TextBox txtzodiac;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txty;
    }
}