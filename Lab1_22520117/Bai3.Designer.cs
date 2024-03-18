namespace Lab1_22520117
{
    partial class Bai3
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
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btdoc = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(635, 204);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 13;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(635, 128);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 12;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btdoc
            // 
            this.btdoc.Location = new System.Drawing.Point(635, 50);
            this.btdoc.Name = "btdoc";
            this.btdoc.Size = new System.Drawing.Size(75, 23);
            this.btdoc.TabIndex = 11;
            this.btdoc.Text = "Đọc ";
            this.btdoc.UseVisualStyleBackColor = true;
            this.btdoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết quả ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập sô nguyên từ 0 đến 9 ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btdoc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btdoc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}