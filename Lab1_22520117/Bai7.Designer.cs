namespace Lab1_22520117
{
    partial class Bai7
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
            this.btkt = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbkq = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.lbnhap = new System.Windows.Forms.Label();
            this.btInmang = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập danh sách điẻm của sinh viên ";
            // 
            // btkt
            // 
            this.btkt.Location = new System.Drawing.Point(241, 128);
            this.btkt.Name = "btkt";
            this.btkt.Size = new System.Drawing.Size(75, 23);
            this.btkt.TabIndex = 2;
            this.btkt.Text = "Kiểm tra";
            this.btkt.UseVisualStyleBackColor = true;
            this.btkt.Click += new System.EventHandler(this.btnhap_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(230, 12);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(391, 20);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // lbkq
            // 
            this.lbkq.Location = new System.Drawing.Point(55, 177);
            this.lbkq.Name = "lbkq";
            this.lbkq.Size = new System.Drawing.Size(713, 209);
            this.lbkq.TabIndex = 4;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(46, 128);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "Thêm";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // lbnhap
            // 
            this.lbnhap.Location = new System.Drawing.Point(12, 49);
            this.lbnhap.Name = "lbnhap";
            this.lbnhap.Size = new System.Drawing.Size(609, 44);
            this.lbnhap.TabIndex = 6;
            this.lbnhap.Click += new System.EventHandler(this.lbnhap_Click);
            // 
            // btInmang
            // 
            this.btInmang.Location = new System.Drawing.Point(411, 128);
            this.btInmang.Name = "btInmang";
            this.btInmang.Size = new System.Drawing.Size(75, 23);
            this.btInmang.TabIndex = 7;
            this.btInmang.Text = "In mang";
            this.btInmang.UseVisualStyleBackColor = true;
            this.btInmang.Click += new System.EventHandler(this.btInmang_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(550, 128);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 8;
            this.btclear.Text = "clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btInmang);
            this.Controls.Add(this.lbnhap);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lbkq);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btkt);
            this.Controls.Add(this.label1);
            this.Name = "Bai7";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btkt;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbkq;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label lbnhap;
        private System.Windows.Forms.Button btInmang;
        private System.Windows.Forms.Button btclear;
    }
}