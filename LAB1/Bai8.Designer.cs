namespace LAB1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cKetqua = new System.Windows.Forms.TextBox();
            this.cThem = new System.Windows.Forms.Button();
            this.cTim = new System.Windows.Forms.Button();
            this.cXoa = new System.Windows.Forms.Button();
            this.cThoat = new System.Windows.Forms.Button();
            this.cMonan = new System.Windows.Forms.TextBox();
            this.cDanhsachmon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập món ăn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(177, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Món hôm nay ăn là:";
            // 
            // cKetqua
            // 
            this.cKetqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cKetqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cKetqua.Location = new System.Drawing.Point(133, 315);
            this.cKetqua.Name = "cKetqua";
            this.cKetqua.ReadOnly = true;
            this.cKetqua.Size = new System.Drawing.Size(229, 22);
            this.cKetqua.TabIndex = 3;
            this.cKetqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cThem
            // 
            this.cThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cThem.Location = new System.Drawing.Point(197, 67);
            this.cThem.Name = "cThem";
            this.cThem.Size = new System.Drawing.Size(75, 23);
            this.cThem.TabIndex = 4;
            this.cThem.Text = "Thêm";
            this.cThem.UseVisualStyleBackColor = true;
            this.cThem.Click += new System.EventHandler(this.cThem_Click);
            // 
            // cTim
            // 
            this.cTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cTim.Location = new System.Drawing.Point(76, 247);
            this.cTim.Name = "cTim";
            this.cTim.Size = new System.Drawing.Size(107, 23);
            this.cTim.TabIndex = 5;
            this.cTim.Text = "Tìm món ăn";
            this.cTim.UseVisualStyleBackColor = true;
            this.cTim.Click += new System.EventHandler(this.cTim_Click);
            // 
            // cXoa
            // 
            this.cXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cXoa.Location = new System.Drawing.Point(229, 247);
            this.cXoa.Name = "cXoa";
            this.cXoa.Size = new System.Drawing.Size(75, 23);
            this.cXoa.TabIndex = 6;
            this.cXoa.Text = "Xóa";
            this.cXoa.UseVisualStyleBackColor = true;
            this.cXoa.Click += new System.EventHandler(this.cXoa_Click);
            // 
            // cThoat
            // 
            this.cThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cThoat.Location = new System.Drawing.Point(350, 247);
            this.cThoat.Name = "cThoat";
            this.cThoat.Size = new System.Drawing.Size(75, 23);
            this.cThoat.TabIndex = 7;
            this.cThoat.Text = "Thoát";
            this.cThoat.UseVisualStyleBackColor = true;
            this.cThoat.Click += new System.EventHandler(this.cThoat_Click);
            // 
            // cMonan
            // 
            this.cMonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cMonan.Location = new System.Drawing.Point(112, 41);
            this.cMonan.Name = "cMonan";
            this.cMonan.Size = new System.Drawing.Size(160, 22);
            this.cMonan.TabIndex = 8;
            // 
            // cDanhsachmon
            // 
            this.cDanhsachmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cDanhsachmon.FormattingEnabled = true;
            this.cDanhsachmon.ItemHeight = 16;
            this.cDanhsachmon.Location = new System.Drawing.Point(315, 44);
            this.cDanhsachmon.Name = "cDanhsachmon";
            this.cDanhsachmon.Size = new System.Drawing.Size(154, 148);
            this.cDanhsachmon.TabIndex = 9;
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 352);
            this.Controls.Add(this.cDanhsachmon);
            this.Controls.Add(this.cMonan);
            this.Controls.Add(this.cThoat);
            this.Controls.Add(this.cXoa);
            this.Controls.Add(this.cTim);
            this.Controls.Add(this.cThem);
            this.Controls.Add(this.cKetqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai8";
            this.Text = "Bài 08 – Hôm nay ăn gì? ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cKetqua;
        private System.Windows.Forms.Button cThem;
        private System.Windows.Forms.Button cTim;
        private System.Windows.Forms.Button cXoa;
        private System.Windows.Forms.Button cThoat;
        private System.Windows.Forms.TextBox cMonan;
        private System.Windows.Forms.ListBox cDanhsachmon;
    }
}