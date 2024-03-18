namespace Lab1_22520117
{
    partial class Bai4
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbphim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbve = new System.Windows.Forms.ComboBox();
            this.ckseet = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.Label();
            this.btxuat = new System.Windows.Forms.Button();
            this.btload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ tên KH";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(177, 42);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // cbphim
            // 
            this.cbphim.FormattingEnabled = true;
            this.cbphim.Items.AddRange(new object[] {
            "Đào, phở và piano",
            "Mai",
            "Gặp lại chị bầu",
            "Tarot"});
            this.cbphim.Location = new System.Drawing.Point(511, 39);
            this.cbphim.Name = "cbphim";
            this.cbphim.Size = new System.Drawing.Size(121, 21);
            this.cbphim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phim muốn xem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn loại vé";
            // 
            // cbve
            // 
            this.cbve.FormattingEnabled = true;
            this.cbve.Items.AddRange(new object[] {
            "vé vớt",
            "vé thường",
            "vé VIP"});
            this.cbve.Location = new System.Drawing.Point(193, 102);
            this.cbve.Name = "cbve";
            this.cbve.Size = new System.Drawing.Size(121, 21);
            this.cbve.TabIndex = 5;
            // 
            // ckseet
            // 
            this.ckseet.FormattingEnabled = true;
            this.ckseet.Location = new System.Drawing.Point(511, 89);
            this.ckseet.Name = "ckseet";
            this.ckseet.Size = new System.Drawing.Size(120, 94);
            this.ckseet.TabIndex = 6;
            this.ckseet.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn chỗ ngồi";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(109, 186);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(591, 194);
            this.txtkq.TabIndex = 9;
            this.txtkq.Click += new System.EventHandler(this.txtkq_Click);
            // 
            // btxuat
            // 
            this.btxuat.Location = new System.Drawing.Point(12, 206);
            this.btxuat.Name = "btxuat";
            this.btxuat.Size = new System.Drawing.Size(75, 23);
            this.btxuat.TabIndex = 10;
            this.btxuat.Text = "Xuất";
            this.btxuat.UseVisualStyleBackColor = true;
            this.btxuat.Click += new System.EventHandler(this.btxuat_Click);
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(12, 146);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 23);
            this.btload.TabIndex = 11;
            this.btload.Text = "Load";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btload);
            this.Controls.Add(this.btxuat);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckseet);
            this.Controls.Add(this.cbve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbphim);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbphim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbve;
        private System.Windows.Forms.CheckedListBox ckseet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.Button btxuat;
        private System.Windows.Forms.Button btload;
    }
}