using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cMang_TextChanged(object sender, EventArgs e)
        {
            string[] arr = cMang.Text.Split(new char[] { ',' }).Select(x => x.Trim()).ToArray();
            if (arr.Length != 13)
            {
                cKiemtra.Text = "Bạn đã nhập sai format!";
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(arr[0], @"^[\p{L}\s]+$"))
            {
                cKiemtra.Text = "Họ tên chỉ được chứa chữ và khoảng trắng!";
                return;
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (!double.TryParse(arr[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double d) || d < 0 || d > 10)
                {
                    cKiemtra.Text = $"Sai format: điểm môn {i} không hợp lệ!";
                    return;
                }
            }
            cKiemtra.Text = "Bạn đã nhập đúng format!";
        }

        private void cTinh_Click(object sender, EventArgs e)
        {
            cKetqua.Clear();
            int count = 0;
            string[] arr = cMang.Text.Split(',');
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i].Trim() != "")
                {
                    count++;
                }
            }
            if (arr.Length < 13 && count<13 || arr.Length > 13 && count< 13 || !System.Text.RegularExpressions.Regex.IsMatch(arr[0].Trim(), @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Bạn đã nhập sai format, vui lòng kiểm tra lại!");
                return;
            }
            cKetqua.AppendText($"Họ tên: {arr[0].Trim()}\r\n");
            cKetqua.AppendText($"Môn 1: {arr[1].Trim()}\t\n");
            cKetqua.AppendText($"Môn 2: {arr[2].Trim()}\t\t\n");
            cKetqua.AppendText($"Môn 3: {arr[3].Trim()}\r\n");
            cKetqua.AppendText($"Môn 4: {arr[4].Trim()}\t\n");
            cKetqua.AppendText($"Môn 5: {arr[5].Trim()}\t\t\n");
            cKetqua.AppendText($"Môn 6: {arr[6].Trim()}\t\r\n");
            cKetqua.AppendText($"Môn 7: {arr[7].Trim()}\t\n");
            cKetqua.AppendText($"Môn 8: {arr[8].Trim()}\t\t\n");
            cKetqua.AppendText($"Môn 9: {arr[9].Trim()}\t\r\n");
            cKetqua.AppendText($"Môn 10: {arr[10].Trim()}\t\n");
            cKetqua.AppendText($"Môn 11: {arr[11].Trim()}\t\n");
            cKetqua.AppendText($"Môn 12: {arr[12].Trim()}\r\n");

            List<double> diem = new List<double>();

            double cTongdiem = 0;
            double max = 0;
            double min = 10;
            int countDau = 0;
            int countRot = 0;
            for (int i=1; i<arr.Length; i++)
            {
                if (double.TryParse(arr[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double d) && d >= 0 && d <= 10) cTongdiem += d;
                if (d > max) max = d;
                if (d < min) min = d;
                if (d >= 5) countDau++;
                else countRot++;
                diem.Add(d);
            }
            double cDiemtb = cTongdiem / (arr.Length-1);
            cDiemtb = Math.Round(cDiemtb,2);
            cKetqua.AppendText($"Điểm trung bình: {cDiemtb}\r\n");
            cKetqua.AppendText($"Điểm cao nhất: {max}\r\n");
            cKetqua.AppendText($"Điểm thấp nhất: {min}\r\n");
            cKetqua.AppendText($"Số môn đậu: {countDau}\r\n");
            cKetqua.AppendText($"Số môn không đậu: {countRot}\r\n");
            
            string xeploai;
            if (cDiemtb >= 8.0 && diem.All(x => x >= 6.5)) xeploai = "Giỏi";
            else if(cDiemtb >= 6.5 && diem.All(x => x >= 5.0)) xeploai = "Khá";
            else if (cDiemtb >= 5.0 && diem.All(x => x >= 3.5)) xeploai = "Trung bình";
            else if (cDiemtb >= 3.5 && diem.All(x => x >= 2.0)) xeploai = "Yếu";
            else xeploai = "Kém";
            cKetqua.AppendText($"Xếp loại: {xeploai}\r\n");
        }

        private void cKiemtra_Click(object sender, EventArgs e)
        {
            
        }

        private void cKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
