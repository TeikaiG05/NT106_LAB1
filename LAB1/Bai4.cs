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

        Dictionary<string, (int GiaChuan, List<int> PhongChieu)> phimDict =
            new Dictionary<string, (int, List<int>)>()
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
            
        }
        private void Bai4_Load(object sender, EventArgs e)
        {
            cListPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var tenPhim in phimDict.Keys)
            {
                cListPhim.Items.Add(tenPhim);
            }
        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        } 
        private void button_checklist(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string ghe = btn.Text;
            string phong = ghe.Substring(0, 1); // phòng A/B/C

            if (btn.BackColor == Color.LightGreen)
            {
                MessageBox.Show("Vé đã được chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HashSet<string> phongDangChon = new HashSet<string>(
                    this.Controls.OfType<Button>().Where(b => b.BackColor == Color.LightGreen).Select(b => b.Text.Substring(0, 1))
                );

                phongDangChon.Add(phong);

                if (phongDangChon.Count > 2)
                {
                    MessageBox.Show("Không thể chọn nhiều hơn 2 vé ở 2 phòng chiếu khác nhau!","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btn.BackColor = Color.LightGreen;
                for (int i = 0; i < cCheckList.Items.Count; i++) 
                { if (cCheckList.Items[i].ToString() == ghe) 
                    { 
                        bool Check = cCheckList.GetItemChecked(i); 
                        cCheckList.SetItemChecked(i, !Check); 
                        break; 
                    } 
                }
            }

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

        private void cReset_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is Button btn && btn.Text != "Reset")
                {
                    btn.BackColor = SystemColors.Control;
                }
            }
            for (int i = 0; i < cCheckList.Items.Count; i++)
            {
                cCheckList.SetItemChecked(i, false);
            }
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

        private void cThanhtoan_Click(object sender, EventArgs e)
        {
            
            int giaChuan = 0;
            if (cListPhim.SelectedItem != null)
            {
                string phim = cListPhim.SelectedItem.ToString();
                if (phim == "Đào, phở và piano") giaChuan = 45000;
                else if (phim == "Mai") giaChuan = 100000;
                else if (phim == "Gặp lại chị bầu") giaChuan = 70000;
                else if (phim == "Tarot") giaChuan = 90000;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cCheckList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ghế nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int tongTien = 0;
            StringBuilder bill = new StringBuilder();
            bill.AppendLine("HÓA ĐƠN THANH TOÁN");
            bill.AppendLine($"KHÁCH HÀNG: {cHoten.Text}");
            bill.AppendLine($"Phim: {cListPhim.SelectedItem}");
            bill.AppendLine("----------------------------");

            foreach (var item in cCheckList.CheckedItems)
            {
                string ghe = item.ToString();
                string loai = gheDict.ContainsKey(ghe) ? gheDict[ghe] : "thuong";
                int gia = 0;

                switch (loai)
                {
                    case "vot": gia = giaChuan / 4; break;
                    case "thuong": gia = giaChuan; break;
                    case "vip": gia = giaChuan * 2; break;
                }

                tongTien += gia;
                bill.AppendLine($"{ghe} ({loai}) : {gia} VND");
            }

            bill.AppendLine("----------------------------");
            bill.AppendLine($"TỔNG CỘNG: {tongTien} VND");

            MessageBox.Show(bill.ToString(), "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void cThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
