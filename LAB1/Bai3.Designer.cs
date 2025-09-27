namespace LAB1
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
            this.Cketqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cthoat = new System.Windows.Forms.Button();
            this.Cxoa = new System.Windows.Forms.Button();
            this.Cdoc = new System.Windows.Forms.Button();
            this.Cso1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cketqua
            // 
            this.Cketqua.Location = new System.Drawing.Point(142, 159);
            this.Cketqua.Name = "Cketqua";
            this.Cketqua.ReadOnly = true;
            this.Cketqua.Size = new System.Drawing.Size(100, 20);
            this.Cketqua.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kết quả: ";
            // 
            // Cthoat
            // 
            this.Cthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cthoat.Location = new System.Drawing.Point(435, 138);
            this.Cthoat.Name = "Cthoat";
            this.Cthoat.Size = new System.Drawing.Size(75, 23);
            this.Cthoat.TabIndex = 11;
            this.Cthoat.Text = "Thoát";
            this.Cthoat.UseVisualStyleBackColor = true;
            this.Cthoat.Click += new System.EventHandler(this.Cthoat_Click);
            // 
            // Cxoa
            // 
            this.Cxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cxoa.Location = new System.Drawing.Point(435, 95);
            this.Cxoa.Name = "Cxoa";
            this.Cxoa.Size = new System.Drawing.Size(75, 23);
            this.Cxoa.TabIndex = 10;
            this.Cxoa.Text = "Xóa";
            this.Cxoa.UseVisualStyleBackColor = true;
            this.Cxoa.Click += new System.EventHandler(this.Cxoa_Click);
            // 
            // Cdoc
            // 
            this.Cdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cdoc.Location = new System.Drawing.Point(435, 56);
            this.Cdoc.Name = "Cdoc";
            this.Cdoc.Size = new System.Drawing.Size(75, 23);
            this.Cdoc.TabIndex = 9;
            this.Cdoc.Text = "Đọc";
            this.Cdoc.UseVisualStyleBackColor = true;
            this.Cdoc.Click += new System.EventHandler(this.Cdoc_Click);
            // 
            // Cso1
            // 
            this.Cso1.Location = new System.Drawing.Point(274, 58);
            this.Cso1.Name = "Cso1";
            this.Cso1.Size = new System.Drawing.Size(100, 20);
            this.Cso1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập vào số nguyên từ 0 đến 9: ";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 249);
            this.Controls.Add(this.Cketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cthoat);
            this.Controls.Add(this.Cxoa);
            this.Controls.Add(this.Cdoc);
            this.Controls.Add(this.Cso1);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bài 3 - Đọc số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cthoat;
        private System.Windows.Forms.Button Cxoa;
        private System.Windows.Forms.Button Cdoc;
        private System.Windows.Forms.TextBox Cso1;
        private System.Windows.Forms.Label label1;
    }
}