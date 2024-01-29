using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quyen
{
    public partial class khachhang : Form
    {

        public string emailDN; //truyen du lieu
        SqlConnection conn;
        public khachhang()
        {
            InitializeComponent();
        }

        // ham co tham so
        public khachhang(string email)
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

    

    

        private void button_Profile5_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu form7 = new trangchu();
            form7.Show();
        }

     
        private void khachhang_Load(object sender, EventArgs e)
        {

            
            ketnoi();

            //phan quyen
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
              //  button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
              //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

              //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThi_lenluoiDuLieu(luoi_dlieu);

        }

        private void button_them_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(textBox1.Text);
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }

        //private void button_timkiem_Click_1(object sender, EventArgs e)
        //{

        //    // TIm Kiem du lieu
        //    string query = "select * from KhachHang where (kh_ma = '" + textBox_timkiem.Text + "' OR kh_ten like N'%" + textBox_timkiem.Text + "%')";

        //   // string query = "select * from KhachHang  where KH_ma = '" + textBox_timkiem.Text + "'";
        //        HienThi_TK(query, luoi_dlieu);
            
        //}

        //private void textBox_timkiem_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string query = "select * from KhachHang  where KH_ma = '" + textBox_timkiem.Text + "'";
        //    string quer = "select * from KhachHang  where KH_ten LIKE '%" + textBox_timkiem.Text +"%'";
        //    HienThi_TK(query, luoi_dlieu);
        //    HienThi_TK(quer, luoi_dlieu);
        //}

		private void textBox_timkiem_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			In_DSKH In_DSKH = new In_DSKH();
			In_DSKH.Show();
			
		}

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timkiem(object sender, KeyEventArgs e)
        {
            //  string query = "select * from KhachHang  where KH_ma = '" + textBox_timkiem.Text + "'";
            string query = "select * from KhachHang where (kh_ma = '" + textBox_timkiem.Text + "' OR kh_ten like N'%" + textBox_timkiem.Text + "%')";
            // HienThi_TK(query, luoi_dlieu);
            HienThi_TK(query, luoi_dlieu);
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien(textBox1.Text);
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox1.Text);
            this.Hide();
            trangchu.ShowDialog();
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

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cậpNhậtGiôngThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC();
            this.Hide();
            capnhatGTC.ShowDialog();
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
    }

    
}
