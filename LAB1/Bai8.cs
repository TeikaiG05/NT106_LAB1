using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Bai8 : Form
    {
        List<string> dsMon = new List<string>() {"Bún riêu", "Bún thịt nướng", "Cơm tấm sườn trứng", "Phở", "Gỏi cuốn"};

        public Bai8()
        {
            InitializeComponent();
            cDanhsachmon.DataSource = dsMon;
        }

        private void cThem_Click(object sender, EventArgs e)
        {
            if(cMonan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập món ăn","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mon = cMonan.Text.Trim();
            if (!string.IsNullOrEmpty(mon))
            {
                dsMon.Add(mon);
                cDanhsachmon.DataSource = new BindingSource(dsMon, null);
                cMonan.Clear();
                cMonan.Focus();
            }
        }

        private void cDanhsachmon_TextChanged(object sender, EventArgs e)
        {
        }

        private void cTim_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            if(dsMon.Count>0) cKetqua.Text = dsMon[rdn.Next(dsMon.Count)];
            else MessageBox.Show("Danh sách món ăn trống, vui lòng thêm món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cXoa_Click(object sender, EventArgs e)
        {
            dsMon.Clear();
            cDanhsachmon.DataSource = new BindingSource(dsMon, null);
            cKetqua.Clear();
            cMonan.Focus();
        }

        private void cThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
