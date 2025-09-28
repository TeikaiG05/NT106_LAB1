namespace LAB1
{
    partial class Bai6
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
            this.cXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cKetqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cInput = new System.Windows.Forms.MaskedTextBox();
            this.cXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cXem
            // 
            this.cXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cXem.Location = new System.Drawing.Point(104, 87);
            this.cXem.Name = "cXem";
            this.cXem.Size = new System.Drawing.Size(75, 23);
            this.cXem.TabIndex = 0;
            this.cXem.Text = "Xem";
            this.cXem.UseVisualStyleBackColor = true;
            this.cXem.Click += new System.EventHandler(this.cXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập vào ngày/tháng sinh (dd/mm):";
            // 
            // cKetqua
            // 
            this.cKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cKetqua.Location = new System.Drawing.Point(232, 144);
            this.cKetqua.Name = "cKetqua";
            this.cKetqua.ReadOnly = true;
            this.cKetqua.Size = new System.Drawing.Size(112, 20);
            this.cKetqua.TabIndex = 3;
            this.cKetqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cKetqua.TextChanged += new System.EventHandler(this.cKetqua_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cung hoàng đạo của bạn là: ";
            // 
            // cInput
            // 
            this.cInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cInput.Location = new System.Drawing.Point(280, 39);
            this.cInput.Mask = "00/00";
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(64, 22);
            this.cInput.TabIndex = 5;
            this.cInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cInput.ValidatingType = typeof(System.DateTime);
            this.cInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cInput_MaskInputRejected);
            // 
            // cXoa
            // 
            this.cXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cXoa.Location = new System.Drawing.Point(199, 87);
            this.cXoa.Name = "cXoa";
            this.cXoa.Size = new System.Drawing.Size(75, 23);
            this.cXoa.TabIndex = 6;
            this.cXoa.Text = "Xóa";
            this.cXoa.UseVisualStyleBackColor = true;
            this.cXoa.Click += new System.EventHandler(this.cXoa_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 204);
            this.Controls.Add(this.cXoa);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cKetqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cXem);
            this.Name = "Bai6";
            this.Text = "Bài 6 - Xem cung hoàng đạo";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cKetqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cInput;
        private System.Windows.Forms.Button cXoa;
    }
}