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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void cXem_Click(object sender, EventArgs e)
        {
            cKetqua.Clear();
            string input = cInput.Text.Trim();
            string[]ngaytrongthang = { "", "31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31" };
            string[]parsts=input.Split('/');
            if (!int.TryParse(parsts[0], out int day) || !int.TryParse(parsts[1], out int month))
            {
                MessageBox.Show("Vui lòng nhập ngày tháng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (parsts.Length != 2)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng ngày/tháng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Tháng phải từ 1 đến 12!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maxDay = int.Parse(ngaytrongthang[month]);
            if( month == 2 && DateTime.IsLeapYear(DateTime.Now.Year))
            {
                maxDay = 29;
            }
            if (day < 1 || day > maxDay)
            {
                MessageBox.Show($"Ngày sinh không phù hợp với tháng sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            cKetqua.Text= cCungHoangDao(day, month);

        }

        private string cCungHoangDao(int day, int month)
        {
            switch (month)
            {
                case 1: return (day>=21) ? "Bảo Bình" : "Ma Kết";
                case 2: return (day >= 20) ? "Song Ngư" : "Bảo Bình";
                case 3: return (day>=21) ? "Bạch Dương" : "Song Ngư";
                case 4: return (day >= 21) ? "Kim Ngưu" : "Bạch Dương";
                case 5: return (day >= 22) ? "Song Tử" : "Kim Ngưu";
                case 6: return (day >= 22) ? "Cự Giải" : "Song Tử";
                case 7: return (day >= 23) ? "Sư Tử" : "Cự Giải";
                case 8: return (day >= 23) ? "Xử Nữ" : "Sư Tử";
                case 9: return (day >= 24) ? "Thiên Bình" : "Xử Nữ";
                case 10: return (day >= 24) ? "Thần Nông" : "Thiên Bình";
                case 11: return (day >= 23) ? "Nhân Mã" : "Thần Nông";
                case 12: return (day >= 22) ? "Ma Kết" : "Nhân Mã";
                default: return "Không hợp lệ";
            }
        }

        private void cInput_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cKetqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void cXoa_Click(object sender, EventArgs e)
        {
            cKetqua.Clear();
            cInput.Clear();
            cInput.Focus();
        }
    }
}
