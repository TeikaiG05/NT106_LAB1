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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void Ctim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;
            if (!Double.TryParse(number1.Text, out num1) || !Double.TryParse(number2.Text, out num2) || !Double.TryParse(number3.Text, out num3))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            num1 = double.Parse(number1.Text);
            num2 = double.Parse(number2.Text);
            num3 = double.Parse(number3.Text);
            double max = Math.Max(num1, Math.Max(num2, num3));
            double min = Math.Min(num1, Math.Min(num2, num3));
            Cmax.Text = max.ToString();
            Cmin.Text = min.ToString();
            return;
        }

        private void Cxoa_Click(object sender, EventArgs e)
        {
            number1.Clear();
            number2.Clear();
            number3.Clear();
            Cmax.Clear();
            Cmin.Clear();
            number1.Focus();
        }

        private void Cthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
