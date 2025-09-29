namespace LAB1
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
            this.cNumber1 = new System.Windows.Forms.TextBox();
            this.cNumber2 = new System.Windows.Forms.TextBox();
            this.cListchucnang = new System.Windows.Forms.ComboBox();
            this.cTinh = new System.Windows.Forms.Button();
            this.cXoa = new System.Windows.Forms.Button();
            this.cThoat = new System.Windows.Forms.Button();
            this.cKetqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(285, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B:";
            // 
            // cNumber1
            // 
            this.cNumber1.Location = new System.Drawing.Point(140, 48);
            this.cNumber1.Name = "cNumber1";
            this.cNumber1.Size = new System.Drawing.Size(100, 20);
            this.cNumber1.TabIndex = 2;
            // 
            // cNumber2
            // 
            this.cNumber2.Location = new System.Drawing.Point(353, 47);
            this.cNumber2.Name = "cNumber2";
            this.cNumber2.Size = new System.Drawing.Size(100, 20);
            this.cNumber2.TabIndex = 3;
            // 
            // cListchucnang
            // 
            this.cListchucnang.FormattingEnabled = true;
            this.cListchucnang.Location = new System.Drawing.Point(229, 98);
            this.cListchucnang.Name = "cListchucnang";
            this.cListchucnang.Size = new System.Drawing.Size(121, 21);
            this.cListchucnang.TabIndex = 4;
            this.cListchucnang.SelectedIndexChanged += new System.EventHandler(this.cListchucnang_SelectedIndexChanged);
            // 
            // cTinh
            // 
            this.cTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cTinh.Location = new System.Drawing.Point(67, 149);
            this.cTinh.Name = "cTinh";
            this.cTinh.Size = new System.Drawing.Size(134, 33);
            this.cTinh.TabIndex = 5;
            this.cTinh.Text = "Tính các giá trị";
            this.cTinh.UseVisualStyleBackColor = true;
            this.cTinh.Click += new System.EventHandler(this.cTinh_Click);
            // 
            // cXoa
            // 
            this.cXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cXoa.Location = new System.Drawing.Point(252, 149);
            this.cXoa.Name = "cXoa";
            this.cXoa.Size = new System.Drawing.Size(75, 33);
            this.cXoa.TabIndex = 6;
            this.cXoa.Text = "Xóa";
            this.cXoa.UseVisualStyleBackColor = true;
            this.cXoa.Click += new System.EventHandler(this.cXoa_Click);
            // 
            // cThoat
            // 
            this.cThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cThoat.Location = new System.Drawing.Point(377, 149);
            this.cThoat.Name = "cThoat";
            this.cThoat.Size = new System.Drawing.Size(75, 33);
            this.cThoat.TabIndex = 7;
            this.cThoat.Text = "Thoát";
            this.cThoat.UseVisualStyleBackColor = true;
            this.cThoat.Click += new System.EventHandler(this.cThoat_Click);
            // 
            // cKetqua
            // 
            this.cKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cKetqua.Location = new System.Drawing.Point(67, 204);
            this.cKetqua.Multiline = true;
            this.cKetqua.Name = "cKetqua";
            this.cKetqua.ReadOnly = true;
            this.cKetqua.Size = new System.Drawing.Size(385, 160);
            this.cKetqua.TabIndex = 8;
            this.cKetqua.TextChanged += new System.EventHandler(this.cKetqua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(393, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cKetqua);
            this.Controls.Add(this.cThoat);
            this.Controls.Add(this.cXoa);
            this.Controls.Add(this.cTinh);
            this.Controls.Add(this.cListchucnang);
            this.Controls.Add(this.cNumber2);
            this.Controls.Add(this.cNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bài 5 - Bảng cửu chương, tính giá trị";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cNumber1;
        private System.Windows.Forms.TextBox cNumber2;
        private System.Windows.Forms.ComboBox cListchucnang;
        private System.Windows.Forms.Button cTinh;
        private System.Windows.Forms.Button cXoa;
        private System.Windows.Forms.Button cThoat;
        private System.Windows.Forms.TextBox cKetqua;
        private System.Windows.Forms.Label label3;
    }
}