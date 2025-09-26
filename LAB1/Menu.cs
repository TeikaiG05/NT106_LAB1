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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosed += Menu_FormClosed;
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            this.Hide();
            bai1.ShowDialog();
            this.Show();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            this.Hide();
            bai2.ShowDialog();
            this.Show();
        }
    }
}
