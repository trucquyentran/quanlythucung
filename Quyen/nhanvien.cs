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
    public partial class nhanvien : Form
    {
        public string emailDN;
        SqlConnection conn;
        public nhanvien()
        {
            InitializeComponent();
        }
        public nhanvien(string email)
        {
            InitializeComponent();
            this.emailDN = email;

        }
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }

        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "SELECT * FROM NhanVien";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_NhanVien");
            dg.DataSource = dase;
            dg.DataMember = "DS_NhanVien";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_NhanVien");
            dg.DataSource = dase;
            dg.DataMember = "DS_NhanVien";
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

		private void button_them_Click(object sender, EventArgs e)
		{
			cappnhatNV cappnhatNV = new cappnhatNV();
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

		private void nhanvien_Load(object sender, EventArgs e)
		{
			ketnoi();

            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
                button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
              //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

               // cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
        
            string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";
            HienThi_TK(query, luoi_dlieu);
            HienThiCombobox("select * from ChucVu", comboBox1, "CV_ma", "CV_ten");
            comboBox1.Text = "";

            //	this.reportViewer1.RefreshReport();
        }
		

		//private void textBox_timkiem_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	string query = "select * from NhanVien  where NV_ma = '" + textBox_timkiem.Text + "'";
		//	HienThi_TK(query, luoi_dlieu);
		//}

		private void button_trangchu_Click(object sender, EventArgs e)
		{
			trangchu trangchu = new trangchu();
			trangchu.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			In_DSNV In_DSNV = new In_DSNV();
			In_DSNV.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }
         
      

        private void button3_Click(object sender, EventArgs e)
        {
             string macv = comboBox1.SelectedValue.ToString();
            string query = "select * from  NhanVien  where  CV_ma ='" + macv + "'";
            HienThi_TK(query, luoi_dlieu);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";
            HienThi_TK(query, luoi_dlieu);
            comboBox1.Text = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu form6 = new trangchu(textBox1.Text);
            this.Hide();
            form6.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang form5 = new khachhang(textBox1.Text);
            this.Hide();
            form5.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(textBox1.Text);
            this.Hide();
            form1.ShowDialog();
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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK tk = new profileTK(textBox1.Text);
            this.Hide();
            tk.ShowDialog();
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

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox1.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void textBox_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            string gtrigovao = textBox_timkiem.Text;

            string timkiem = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma and(nv_ma = '" + gtrigovao + "' OR nv_ten like N'%" + gtrigovao + "%')";
            HienThi_TK(timkiem, luoi_dlieu);
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

        private void cậpNhậtNguồnGốThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            capnhatNG capnhatNG = new capnhatNG();
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();

        }

        private void cậpNhậtGiôngThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC();
            this.Hide();
            capnhatGTC.ShowDialog();
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

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatCV capnhatCV = new capnhatCV();
            this.Hide();
            capnhatCV.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
