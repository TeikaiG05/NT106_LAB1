namespace LAB1
{
    partial class Bai1
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
            this.Csum = new System.Windows.Forms.TextBox();
            this.Ctinh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Csum
            // 
            this.Csum.Location = new System.Drawing.Point(247, 250);
            this.Csum.Name = "Csum";
            this.Csum.ReadOnly = true;
            this.Csum.Size = new System.Drawing.Size(90, 20);
            this.Csum.TabIndex = 15;
            // 
            // Ctinh
            // 
            this.Ctinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Ctinh.Location = new System.Drawing.Point(199, 197);
            this.Ctinh.Name = "Ctinh";
            this.Ctinh.Size = new System.Drawing.Size(75, 23);
            this.Ctinh.TabIndex = 14;
            this.Ctinh.Text = "Tính";
            this.Ctinh.UseVisualStyleBackColor = true;
            this.Ctinh.Click += new System.EventHandler(this.Ctinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng: ";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(247, 141);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(90, 20);
            this.number2.TabIndex = 12;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(247, 93);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(90, 20);
            this.number1.TabIndex = 11;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số thứ hai: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số thứ nhất: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(80, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 328);
            this.Controls.Add(this.Csum);
            this.Controls.Add(this.Ctinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Bài 1 - Tính tổng 2 số nguyên";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Csum;
        private System.Windows.Forms.Button Ctinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}