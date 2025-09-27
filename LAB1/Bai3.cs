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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Cdoc_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(Cso1.Text.Trim(), out a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a = Int32.Parse(Cso1.Text.Trim());

            switch (a)
            {
                case 0: Cketqua.Text = "Không"; break;
                case 1: Cketqua.Text = "Một"; break;
                case 2: Cketqua.Text = "Hai"; break;
                case 3: Cketqua.Text = "Ba"; break;
                case 4: Cketqua.Text = "Bốn"; break;
                case 5: Cketqua.Text = "Năm"; break;
                case 6: Cketqua.Text = "Sáu"; break;
                case 7: Cketqua.Text = "Bảy"; break;
                case 8: Cketqua.Text = "Tám"; break;
                case 9: Cketqua.Text = "Chín"; break;
                default:
                    MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Cxoa_Click(object sender, EventArgs e)
        {
            Cketqua.Clear();
            Cso1.Clear();
            Cso1.Focus();
        }

        private void Cthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
