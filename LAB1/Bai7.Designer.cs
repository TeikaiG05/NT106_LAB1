namespace LAB1
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
            this.cMang = new System.Windows.Forms.TextBox();
            this.cTinh = new System.Windows.Forms.Button();
            this.cKiemtra = new System.Windows.Forms.Label();
            this.cKetqua = new System.Windows.Forms.TextBox();
            this.Kq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào danh sách điểm của sinh viên: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cMang
            // 
            this.cMang.Location = new System.Drawing.Point(85, 44);
            this.cMang.Name = "cMang";
            this.cMang.Size = new System.Drawing.Size(328, 20);
            this.cMang.TabIndex = 1;
            this.cMang.TextChanged += new System.EventHandler(this.cMang_TextChanged);
            // 
            // cTinh
            // 
            this.cTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cTinh.Location = new System.Drawing.Point(212, 108);
            this.cTinh.Name = "cTinh";
            this.cTinh.Size = new System.Drawing.Size(75, 23);
            this.cTinh.TabIndex = 2;
            this.cTinh.Text = "Tính";
            this.cTinh.UseVisualStyleBackColor = true;
            this.cTinh.Click += new System.EventHandler(this.cTinh_Click);
            // 
            // cKiemtra
            // 
            this.cKiemtra.AutoSize = true;
            this.cKiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cKiemtra.ForeColor = System.Drawing.Color.Red;
            this.cKiemtra.Location = new System.Drawing.Point(85, 76);
            this.cKiemtra.Name = "cKiemtra";
            this.cKiemtra.Size = new System.Drawing.Size(19, 16);
            this.cKiemtra.TabIndex = 3;
            this.cKiemtra.Text = "...";
            this.cKiemtra.Click += new System.EventHandler(this.cKiemtra_Click);
            // 
            // cKetqua
            // 
            this.cKetqua.Location = new System.Drawing.Point(88, 150);
            this.cKetqua.Multiline = true;
            this.cKetqua.Name = "cKetqua";
            this.cKetqua.Size = new System.Drawing.Size(325, 272);
            this.cKetqua.TabIndex = 4;
            this.cKetqua.TextChanged += new System.EventHandler(this.cKetqua_TextChanged);
            // 
            // Kq
            // 
            this.Kq.AutoSize = true;
            this.Kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Kq.Location = new System.Drawing.Point(354, 151);
            this.Kq.Name = "Kq";
            this.Kq.Size = new System.Drawing.Size(59, 16);
            this.Kq.TabIndex = 5;
            this.Kq.Text = "Kết quả";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Kq);
            this.Controls.Add(this.cKetqua);
            this.Controls.Add(this.cKiemtra);
            this.Controls.Add(this.cTinh);
            this.Controls.Add(this.cMang);
            this.Controls.Add(this.label1);
            this.Name = "Bai7";
            this.Text = "Bài 7 - Xử lý mảng";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cMang;
        private System.Windows.Forms.Button cTinh;
        private System.Windows.Forms.Label cKiemtra;
        private System.Windows.Forms.TextBox cKetqua;
        private System.Windows.Forms.Label Kq;
    }
}