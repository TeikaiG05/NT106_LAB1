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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
       
        private void number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ctinh_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!Int32.TryParse(number1.Text.Trim(), out a) || !Int32.TryParse(number2.Text.Trim(), out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int sum = a + b;
            Csum.Text = sum.ToString();
            return;
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
