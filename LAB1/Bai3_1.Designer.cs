namespace LAB1
{
    partial class Bai3_1
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
            this.Cketqua.Location = new System.Drawing.Point(95, 164);
            this.Cketqua.Multiline = true;
            this.Cketqua.Name = "Cketqua";
            this.Cketqua.ReadOnly = true;
            this.Cketqua.Size = new System.Drawing.Size(355, 37);
            this.Cketqua.TabIndex = 20;
            this.Cketqua.TextChanged += new System.EventHandler(this.Cketqua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kết quả: ";
            // 
            // Cthoat
            // 
            this.Cthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cthoat.Location = new System.Drawing.Point(487, 125);
            this.Cthoat.Name = "Cthoat";
            this.Cthoat.Size = new System.Drawing.Size(75, 23);
            this.Cthoat.TabIndex = 18;
            this.Cthoat.Text = "Thoát";
            this.Cthoat.UseVisualStyleBackColor = true;
            this.Cthoat.Click += new System.EventHandler(this.Cthoat_Click);
            // 
            // Cxoa
            // 
            this.Cxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cxoa.Location = new System.Drawing.Point(487, 82);
            this.Cxoa.Name = "Cxoa";
            this.Cxoa.Size = new System.Drawing.Size(75, 23);
            this.Cxoa.TabIndex = 17;
            this.Cxoa.Text = "Xóa";
            this.Cxoa.UseVisualStyleBackColor = true;
            this.Cxoa.Click += new System.EventHandler(this.Cxoa_Click);
            // 
            // Cdoc
            // 
            this.Cdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cdoc.Location = new System.Drawing.Point(487, 43);
            this.Cdoc.Name = "Cdoc";
            this.Cdoc.Size = new System.Drawing.Size(75, 23);
            this.Cdoc.TabIndex = 16;
            this.Cdoc.Text = "Đọc";
            this.Cdoc.UseVisualStyleBackColor = true;
            this.Cdoc.Click += new System.EventHandler(this.Cdoc_Click);
            // 
            // Cso1
            // 
            this.Cso1.Location = new System.Drawing.Point(279, 46);
            this.Cso1.Name = "Cso1";
            this.Cso1.Size = new System.Drawing.Size(171, 20);
            this.Cso1.TabIndex = 15;
            this.Cso1.TextChanged += new System.EventHandler(this.Cso1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhập vào số nguyên có 12 chữ số: ";
            // 
            // Bai3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 252);
            this.Controls.Add(this.Cketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cthoat);
            this.Controls.Add(this.Cxoa);
            this.Controls.Add(this.Cdoc);
            this.Controls.Add(this.Cso1);
            this.Controls.Add(this.label1);
            this.Name = "Bai3_1";
            this.Text = "Bài 3.1 – Đọc số nâng cao";
            this.Load += new System.EventHandler(this.Bai3_1_Load);
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