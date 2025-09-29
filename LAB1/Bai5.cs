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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        private void Bai5_Load(object sender, EventArgs e)
        {
            cListchucnang.Items.Add("Bảng cửu chương");
            cListchucnang.Items.Add("Tính toán giá trị");
        }

        private void cListchucnang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cTinh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cNumber1.Text.Trim(), out int A) || !int.TryParse(cNumber2.Text.Trim(), out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }
            if (cListchucnang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức năng");
                return;
            }
            
            if (cListchucnang.SelectedItem.ToString() == "Bảng cửu chương")
            {
                cKetqua.Clear();
                int a = A - B;
                if (a < 0)
                {
                    MessageBox.Show("Vui lòng nhập số thứ hai lớn hơn số thứ nhất");
                    return;
                }
                else
                {
                    for (int i=1; i<=10; i++)
                    {
                        cKetqua.AppendText($"{a} x {i} = {a * i}\r\n");
                    }
                }
            }
            if(cListchucnang.SelectedItem.ToString() == "Tính toán giá trị")
            {
                cKetqua.Clear();
                
                long a = A - B;
                long giaithua = 1;
                for (long i = 1; i <= a; i++) giaithua *= i;
                cKetqua.AppendText($"(A - B)! = {giaithua}");
                
                int S = 0;
                for (int i=1; i<=B; i++)
                {
                    S += A * i;
                }
                cKetqua.AppendText($"\r\nS = A^1 + A^2 + … + A^B  = {S}");
            }
        }

        private void cXoa_Click(object sender, EventArgs e)
        {
            cNumber1.Clear();
            cNumber2.Clear();
            cKetqua.Clear();
            cListchucnang.SelectedItem = null;
            cNumber1.Focus();
        }

        private void cThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
