using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quyen
{
    public partial class Form1 : Form
    {
        public string emailDN;
        SqlConnection conn;
        public Form1()
        {
            
        InitializeComponent();
        }
        public void ketnoi()
        {
            String ketnoi = "Server=DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }
        public Form1(String email)
        {
            InitializeComponent();
            this.emailDN = email;
        }
        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();

            string query = "SELECT * FROM KhachHang";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_KhachHang");
            dg.DataSource = dase;
            dg.DataMember = "DS_KhachHang";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_KhachHang");
            dg.DataSource = dase;
            dg.DataMember = "DS_KhachHang";
        }

        public void HienThiCombobox(string query, ComboBox comb, string ma, string ten)
        {
            SqlCommand sql = new SqlCommand(query, conn);
            SqlDataReader read = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            comb.DataSource = dt;
            comb.DisplayMember = ten;
            comb.ValueMember = ma;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi();
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
               // button3.Enabled = false;
                // button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
                //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

                //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThi_lenluoiDuLieu(luoi_dlieu);
        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            string query = "select * from KhachHang where (kh_ma = '" + search.Text + "' OR kh_ten like N'%" + search.Text + "%')";
            // HienThi_TK(query, luoi_dlieu);
            HienThi_TK(query, luoi_dlieu);
        }

        private void Add_Click(object sender, EventArgs e)
        {

            string newQuery = "select SUBSTRING(MAX(KH_ma),3,2)+1 " +
                              "from KhachHang";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newKH_ma = "KH0" + a.ToString();
            ma.Text = newKH_ma;
            ma.Enabled = false;
            ten.Text = "";
            gt.Text = "";
            sdt.Text = "";
            dchi.Text = "";
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string NV_sdt = sdt.Text;
            bool NolaSo = sdt.Text.All(char.IsDigit);
            int val;
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo!");
            }
            else
            {
                if (NolaSo)
                {
                    if (NV_sdt.Length == 10)
                    {
                        NolaSo = sdt.Text.All(char.IsDigit);

                        SqlCommand sql_Sua = new SqlCommand("update KhachHang set KH_ten = N'" + ten.Text + "', KH_gioitinh = N'" + gt.Text + "', KH_sdt = '" + sdt.Text + "' , KH_diachi= N'" + dchi.Text + "' where KH_ma = '" + ma.Text + "'", conn);
                        sql_Sua.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật khách hàng: " + ma.Text + " thành công", "Thông báo!");
                        HienThi_lenluoiDuLieu(luoi_dlieu);
                    }
                    else
                    {
                        MessageBox.Show("Độ dài số điện thoại không hợp lệ", "Thông báo!");
                    }

                }
                else
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo!");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo!");
            }
            else
            {
                SqlCommand sql_them = new SqlCommand("delete from KhachHang where KH_ma = '" + ma.Text + "'", conn);
                sql_them.ExecuteNonQuery();
                HienThi_lenluoiDuLieu(luoi_dlieu);
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string KH_sdt = sdt.Text;
            bool NolaSo = sdt.Text.All(char.IsDigit);
            int val;
            if (NolaSo)
            {
                if(KH_sdt.Length == 10)
                {
                    NolaSo = sdt.Text.All(char.IsDigit);

                    SqlCommand sql_them = new SqlCommand("insert into KhachHang values " +
                                  "('" + ma.Text + "', N'" + ten.Text + "', N'" + gt.Text + "', '" + sdt.Text + "',N'" + dchi.Text + "')", conn);
                    sql_them.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm khách hàng: " + ma.Text);
                    HienThi_lenluoiDuLieu(luoi_dlieu);
                  
                }
                else
                {
                    MessageBox.Show("Độ dài số điện thoại không hợp lệ", "Thông báo!");
                }

            }
            else
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo!");       
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
            ten.Text = "";
            gt.Text = "";
            sdt.Text = "";
            dchi.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            profileKH profileKH = new profileKH(ma.Text, textBox1.Text);
            this.Hide();
            profileKH.ShowDialog();
            this.Show();
            this.Close();
            string makh = ma.Text.ToString();
            profileKH pf = new profileKH(ma.Text, textBox1.Text);
            pf.Show();
        }

        private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            ten.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            gt.Text = luoi_dlieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            sdt.Text = luoi_dlieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            dchi.Text = luoi_dlieu.Rows[e.RowIndex].Cells[4].Value.ToString();


            ma.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khachhang khachhang = new khachhang(textBox1.Text);
            this.Hide();
            khachhang.ShowDialog();
            this.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dangnhap dn = new dangnhap();
                this.Hide();
                dn.ShowDialog();
                this.Show();
                this.Close();
            }
        }

        private void thôngTinTàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {

            profileTK profileTK = new profileTK(textBox1.Text);
            this.Hide();
            profileTK.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatCV capnhatCV = new capnhatCV();
            this.Hide();
            capnhatCV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatLSP capnhatLSP = new capnhatLSP();
            this.Hide();
            capnhatLSP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC();
            this.Hide();
            capnhatGTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capnhatNG capnhatNG = new capnhatNG();
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dỊchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
