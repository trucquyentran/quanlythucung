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
    public partial class capnhatLSP : Form
    {
        public string emailDN;
        SqlConnection conn;
        public capnhatLSP()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }
         public capnhatLSP(String email)

          {
              InitializeComponent();

              this.emailDN = email;


          }

        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "SELECT * FROM LoaiSanPham";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_Loai");
            dg.DataSource = dase;
            dg.DataMember = "DS_Loai";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_Loai");
            dg.DataSource = dase;
            dg.DataMember = "DS_Loai";
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

        private void capnhatLSP_Load(object sender, EventArgs e)
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

            string query = "select * from LoaiSanPham";
            HienThi_TK(query, luoi_dlieu);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string newQuery = "select SUBSTRING(MAX(LSP_ma),,2)+1 " +
                             "from LoaiSanPham";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newLSP_ma = "LSP0" + a.ToString();
            ma.Text = newLSP_ma;
            ma.Enabled = false;
            ten.Text = "";
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string MaLSP = ma.Text;
            string TenLSP = ten.Text;
            SqlCommand sql_them = new SqlCommand("insert into LoaiSanPham values " +
                                          "('" + ma.Text + "', N'" + ten.Text + "') ", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Đã thêm loại sản phẩm: " + ma.Text);
            string query = "select * from LoaiSanPham ";
            HienThi_TK(query, luoi_dlieu);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn loại sản phẩm", "Thông báo!");
            }
            else
            {
                SqlCommand sql_Sua = new SqlCommand("update LoaiSanPham set LSP_ten = N'" + ten.Text + "'where LSP_ma = '" + ma.Text + "'", conn);
                sql_Sua.ExecuteNonQuery();
                MessageBox.Show("Đã sửa thông tin loại sản phẩm: " + ma.Text);
                string query = "select * from LoaiSanPham";
                HienThi_TK(query, luoi_dlieu);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn loại sản phẩm", "Thông báo!");
            }
            else
            {
                SqlCommand sql_them = new SqlCommand("delete from LoaiSanPham where LSP_ma = '" + ma.Text + "'", conn);
                sql_them.ExecuteNonQuery();
                MessageBox.Show("Đã xoá loại sản phẩm " + ma.Text);
                string query = "select * from LoaiSanPham ";

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
            HienThi_TK("select * from LoaiSanPham where LSP_ma = '" + search.Text + "' OR LSP_ten like N'%" + search.Text + "%'", luoi_dlieu);
        }

        private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[0].Value.ToString();
            ten.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
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

        private void cậpNhậtChứcVụToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            capnhatCV capnhatCV = new capnhatCV(textBox1.Text);
            this.Hide();
            capnhatCV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sanpham sanpham = new sanpham(textBox1.Text);
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP capnhatSP = new capnhatSP(textBox1.Text);
            this.Hide();
            capnhatSP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatLSP capnhatLSP = new capnhatLSP(textBox1.Text);
            this.Hide();
            capnhatLSP.ShowDialog();
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

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC(textBox1.Text);
            this.Hide();
            capnhatGTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capnhatNG capnhatNG = new capnhatNG(textBox1.Text);
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();
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

        private void thôngTinTàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK profileTK = new profileTK(textBox1.Text);
            this.Hide();
            profileTK.ShowDialog();
            this.Show();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                dangnhap dn = new dangnhap();
                this.Hide();
                dn.ShowDialog();
                this.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capnhatSP capnhatSP = new capnhatSP(textBox1.Text);
            this.Hide();
            capnhatSP.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
