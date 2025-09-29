using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }
        private static string[] donvi = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        string[] hang = { "", " nghìn", " triệu", " tỷ" };
        private static string Doc3So(long n)
        {
            long tram = n / 100;
            long chuc = (n % 100) / 10;
            long dv = n % 10;
            string kq = "";

            if (tram > 0) {
                kq += donvi[tram] + " trăm";
                if (chuc == 0 && dv > 0) kq += " lẻ";
            }

            if (chuc > 1)
            {
                kq += " " + donvi[chuc] + " mươi";
                if (dv == 1) kq += " mốt";
                else if (dv == 5) kq += " lăm";
                else if (dv > 0) kq += " " + donvi[dv];
            }

            else if (chuc == 1)
            {
                kq += " mười";
                if (dv == 1) kq += " một";
                else if (dv == 5) kq += " lăm";
                else if (dv > 0) kq += " " + donvi[dv];
            }

            else if (chuc == 0 && dv > 0) kq += " " + donvi[dv];
            return kq.Trim();
        }

        private void Cdoc_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(Cso1.Text.Trim(), out long a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(a.ToString().Length > 12)
            {
                MessageBox.Show("Vui lòng nhập số nguyên không quá 12 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(a==0)
            {
                Cketqua.Text = "Không"; 
                return;
            }
            

            string kq = "";
            int i = 0;
            while (a > 0)
            {
                long n = a % 1000;
                if (n != 0)
                {
                    string s = Doc3So(n);
                    if (i == 0 && n < 100 && n > 0)
                    {
                        s = "không trăm " + s;
                    }
                    if (i > 0) s += hang[i];
                    if (kq == "")
                        kq = s;
                    else
                        kq = s + ", " + kq;

                }
                a /= 1000;
                i++;
            }
            kq = kq.Trim().TrimEnd(',');
            kq = char.ToUpper(kq[0]) + kq.Substring(1) + ".";
            Cketqua.Text = kq;
        }

        private void Cketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cxoa_Click(object sender, EventArgs e)
        {
            Cso1.Clear();
            Cketqua.Clear();
            Cso1.Focus();
        }

        private void Cthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai3_1_Load(object sender, EventArgs e)
        {

        }

        private void Cso1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
