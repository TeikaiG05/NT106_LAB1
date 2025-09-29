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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private List<(int Room, string Seat)> veDaChon = new List<(int, string)>();
        private HashSet<(int Room, string Seat)> gheDaBan = new HashSet<(int Room, string Seat)>();
        Dictionary<string, (int GiaChuan, List<int> PhongChieu)> phimDict = new Dictionary<string, (int, List<int>)>()
        {
            {"Đào, phở và piano", (45000, new List<int>{1,2,3})},
            {"Mai", (100000, new List<int>{2,3})},
            {"Gặp lại chị bầu", (70000, new List<int>{1})},
            {"Tarot", (90000, new List<int>{3})}
        };

        Dictionary<string, string> gheDict = new Dictionary<string, string>()
        {
            {"A1","vot"},{"A5","vot"},{"C1","vot"},{"C5","vot"},
            {"A2","thuong"},{"A3","thuong"},{"A4","thuong"},
            {"C2","thuong"},{"C3","thuong"},{"C4","thuong"},
            {"B2","vip"},{"B3","vip"},{"B4","vip"}
        };

        private void cListphim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPhongchieu.Items.Clear();
            if (cListPhim.SelectedItem == null) return;
            string phim = cListPhim.SelectedItem.ToString();
            foreach (int p in phimDict[phim].PhongChieu) cPhongchieu.Items.Add(p);
            if (cPhongchieu.Items.Count > 0) cPhongchieu.SelectedIndex = 0;
        }
        private void Bai4_Load(object sender, EventArgs e)
        {
            cListPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var tenPhim in phimDict.Keys)
            {
                cListPhim.Items.Add(tenPhim);
            }
        }
        private void button_checklist(object sender, EventArgs e)
        {
            if (cListPhim.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn phim!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cPhongchieu.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn phòng chiếu!", "Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Button btn = sender as Button;
            string ghe = btn.Text;
            int phongChieu = Convert.ToInt32(cPhongchieu.SelectedItem);

            if (btn.BackColor == Color.LightGreen)
            {
                MessageBox.Show("Ghế đã được chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var distinctRooms = veDaChon.Select(v => v.Room).Distinct().ToList();
            if (!distinctRooms.Contains(phongChieu)) distinctRooms.Add(phongChieu);

            if (distinctRooms.Count > 1 && veDaChon.Count + 1 > 2)
            {
                MessageBox.Show("Không thể chọn hơn 2 vé ở 2 phòng chiếu khác nhau!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            btn.BackColor = Color.LightGreen;
            veDaChon.Add((phongChieu, ghe));

            for (int i = 0; i < cCheckList.Items.Count; i++)
                if (cCheckList.Items[i].ToString() == ghe)
                {
                    cCheckList.SetItemChecked(i, true);
                    break;
                }

        }
        private void RefreshSeats()
        {
            if (cPhongchieu.SelectedItem == null) return;
            int phong = Convert.ToInt32(cPhongchieu.SelectedItem);

            foreach (var btn in this.Controls.OfType<Button>())
            {
                string ghe = btn.Text;
                if (gheDaBan.Contains((phong, ghe)))
                {
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = SystemColors.Control;
                    btn.Enabled = true;
                }
            }
        }
        private void cThanhtoan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cHoten.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cListPhim.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string phim = cListPhim.SelectedItem.ToString();
            int giaChuan = phimDict[phim].GiaChuan;

            var gheHopLe = veDaChon
                           .Where(v => !gheDaBan.Contains(v)) 
                           .ToList();

            if (gheHopLe.Count == 0)
            {
                MessageBox.Show("Tất cả ghế bạn chọn đã bán hoặc chưa chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tongTien = 0;
            StringBuilder bill = new StringBuilder();
            bill.AppendLine("HÓA ĐƠN THANH TOÁN");
            bill.AppendLine($"KHÁCH HÀNG : {cHoten.Text}");
            bill.AppendLine($"PHIM: {phim}");
            bill.AppendLine("----------------------------");

            foreach (var ghe in gheHopLe)
            {
                string loai = gheDict.ContainsKey(ghe.Seat) ? gheDict[ghe.Seat] : "thuong";
                int gia;
                switch (loai)
                {
                    case "vot":
                        gia = giaChuan / 4;
                        break;
                    case "vip":
                        gia = giaChuan * 2;
                        break;
                    default:
                        gia = giaChuan;
                        break;
                }

                tongTien += gia;
                bill.AppendLine($"Phòng {ghe.Room} - Ghế {ghe.Seat} ({loai}) : {gia:N0} VND");
            }

            bill.AppendLine("----------------------------");
            bill.AppendLine($"TỔNG CỘNG : {tongTien:N0} VND");

            MessageBox.Show(bill.ToString(), "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var ghe in gheHopLe)
            {
                gheDaBan.Add(ghe); 
            }

            RefreshSeats();
            veDaChon.Clear();
        }
        private void cReset_Click(object sender, EventArgs e)
        {
            veDaChon.Clear();
            foreach (var item in this.Controls)
                if (item is Button btn && btn.Text != "Reset")
                    btn.BackColor = SystemColors.Control;

            for (int i = 0; i < cCheckList.Items.Count; i++)
                cCheckList.SetItemChecked(i, false);
        }
        private void cHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void cThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cA1_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cA2_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cA3_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cA4_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cA5_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }
        private void cB1_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cC1_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cB2_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cB3_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cB4_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cB5_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cC2_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cC3_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cC4_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }

        private void cC5_Click(object sender, EventArgs e)
        {
            button_checklist(sender, e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cPhongchieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSeats();
        }
    }
}
