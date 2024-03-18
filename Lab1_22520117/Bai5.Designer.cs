namespace Lab1_22520117
{
    partial class Bai5
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
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.bttinh = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbkq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(119, 48);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(532, 48);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.cb1.Location = new System.Drawing.Point(294, 110);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 4;
            // 
            // bttinh
            // 
            this.bttinh.Location = new System.Drawing.Point(119, 206);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(117, 23);
            this.bttinh.TabIndex = 5;
            this.bttinh.Text = "Tính các giá trị";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(339, 205);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa ";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(532, 205);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // lbkq
            // 
            this.lbkq.Location = new System.Drawing.Point(177, 254);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(430, 187);
            this.lbkq.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.bttinh);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbkq;
    }
}