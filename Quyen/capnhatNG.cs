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
    public partial class capnhatNG : Form
    {
        public string emailDN;
        SqlConnection conn;
        public capnhatNG()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }
         public capnhatNG(String email)

          {
              InitializeComponent();

              this.emailDN = email;


          }

        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "SELECT * FROM NguonGoc";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_NG");
            dg.DataSource = dase;
            dg.DataMember = "DS_NG";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_NG");
            dg.DataSource = dase;
            dg.DataMember = "DS_NG";
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

        private void capnhatNG_Load(object sender, EventArgs e)
        {
            ketnoi();
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
                //   button3.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
                //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

                //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }

            string query = "select * from NguonGoc";
            HienThi_TK(query, luoi_dlieu);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            /*string newQuery = "select SUBSTRING(MAX(NG_ma),3,2)+1 " +
                             "from NguonGoc";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newNG_ma = "NG0" + a.ToString();
            ma.Text = newNG_ma;
            ma.Enabled = false;*/
            ma.Text = "";
            ten.Text = "";
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string MaCV = ma.Text;
            string TenCV = ten.Text;
            SqlCommand sql_them = new SqlCommand("insert into NguonGoc values " +
                                          "('" + ma.Text + "', N'" + ten.Text + "') ", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Đã thêm nguồn gốc: " + ma.Text);
            string query = "select * from NguonGoc ";
            HienThi_TK(query, luoi_dlieu);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn nguồn gốc", "Thông báo!");
            }
            else
            {
                SqlCommand sql_Sua = new SqlCommand("update NguonGoc set NG_ten = N'" + ten.Text + "'where NG_ma = '" + ma.Text + "'", conn);
                sql_Sua.ExecuteNonQuery();
                MessageBox.Show("Đã sửa thông tin nguồn gốc: " + ma.Text);
                string query = "select * from NguonGoc";
                HienThi_TK(query, luoi_dlieu);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn nguồn gốc", "Thông báo!");
            }
            else
            {
                SqlCommand sql_them = new SqlCommand("delete from NguonGoc where NG_ma = '" + ma.Text + "'", conn);
                sql_them.ExecuteNonQuery();
                MessageBox.Show("Đã xoá nguồn gốc " + ma.Text);
                string query = "select * from NguonGoc ";

                HienThi_TK(query, luoi_dlieu);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
            ten.Text = "";
        }

        private void timkiem(object sender, KeyEventArgs e)
        {
            HienThi_TK("select * from NguonGoc where NG_ma = '" + search.Text + "' OR NG_ten like N'%" + search.Text + "%'", luoi_dlieu);
        }

        private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            ten.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC(textBox1.Text);
            this.Hide();
            capnhatGTC.ShowDialog();
            this.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien(textBox1.Text);
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox1.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatCV capnhatCV = new capnhatCV(textBox1.Text);
            this.Hide();
            capnhatCV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang khachhang = new khachhang(textBox1.Text);
            this.Hide();
            khachhang.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1(textBox1.Text);
            this.Hide();
            Form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thucung thucung = new thucung(textBox1.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC(textBox1.Text);
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtGiốngThúCungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC(textBox1.Text);
            this.Hide();
            capnhatGTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatNG capnhatNG = new capnhatNG(textBox1.Text);
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();
        }

        private void dỊchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dichvu = new dichvu(textBox1.Text);
            this.Hide();
            dichvu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatDV capnhatDV = new capnhatDV(textBox1.Text);
            this.Hide();
            capnhatDV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            profileTK profileTK = new profileTK(textBox1.Text);
            this.Hide();
            profileTK.ShowDialog();
            this.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
