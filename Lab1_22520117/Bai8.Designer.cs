namespace Lab1_22520117
{
    partial class Bai8
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
            this.txteat = new System.Windows.Forms.Label();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btadd = new System.Windows.Forms.Button();
            this.txtthem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txteat
            // 
            this.txteat.Location = new System.Drawing.Point(93, 76);
            this.txteat.Name = "txteat";
            this.txteat.Size = new System.Drawing.Size(132, 26);
            this.txteat.TabIndex = 0;
            this.txteat.Text = "Nhập món ăn";
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "bánh mì ",
            "Bún bò",
            "trứng ốp la",
            "xôi",
            "bánh ướt"});
            this.lst1.Location = new System.Drawing.Point(529, 76);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 95);
            this.lst1.TabIndex = 1;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(340, 132);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(91, 23);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "Thêm";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txtthem
            // 
            this.txtthem.Location = new System.Drawing.Point(210, 76);
            this.txtthem.Name = "txtthem";
            this.txtthem.Size = new System.Drawing.Size(157, 20);
            this.txtthem.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm món ăn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(261, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Món ăn hôm nay là: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(237, 312);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(250, 20);
            this.txtkq.TabIndex = 8;
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtthem);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txteat);
            this.Name = "Bai8";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txteat;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txtthem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkq;
    }
}

