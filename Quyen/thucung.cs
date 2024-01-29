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
    public partial class thucung : Form
    {
        public string emailDN;
        SqlConnection conn;
        public thucung()
        {
            InitializeComponent();
        }
        public thucung(string email)
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

		


		public void HienThi_TK(string query, DataGridView dg)
		{
			ketnoi();
			SqlDataAdapter dt = new SqlDataAdapter(query, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase, "DS_ThuCung");
			dg.DataSource = dase;
			dg.DataMember = "DS_ThuCung";
		}

		
		private void thucung_Load(object sender, EventArgs e)
		{
			ketnoi();
            

            textBox2.Text = emailDN;
            if (textBox2.Text != "admin@gmail.com")
            { 
               // button3.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
            cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
          //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

          //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
            cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThi_TK("SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma", luoi_dlieu);
        
        }

		 private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma  and TC_ma = '" + textBox1.Text + "'";
            HienThi_TK(query, luoi_dlieu);
        }

		//private void button_them_Click(object sender, EventArgs e)
		//{
		//	capnhatTC capnhatTC = new capnhatTC();
  //          this.Hide();
  //          capnhatTC.ShowDialog();
  //          this.Show();
  //          this.Close();
  //      }

		

		private void button_trangchu_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			In_DS_TC In_DS_TC = new In_DS_TC();
			In_DS_TC.Show();
		}

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            trangchu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox2.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC(textBox2.Text);
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

       
        private void timkiem(object sender, KeyEventArgs e)
        {
            string quer = "select  * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma and TC_ten LIKE  N'%" + textBox1.Text + "%'";
            HienThi_TK(quer, luoi_dlieu);
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang form5 = new khachhang(textBox2.Text);
            this.Hide();
            form5.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(textBox2.Text);
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien(textBox2.Text);
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu(textBox2.Text);
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox2.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham(textBox2.Text);
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP capnhatSP = new capnhatSP(textBox2.Text);
            this.Hide();
            capnhatSP.ShowDialog();
            this.Show();
            this.Close();
        }

        private void thúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thucung thucung = new thucung(textBox2.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC(textBox2.Text);
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dichvu = new dichvu(textBox2.Text);
            this.Hide();
            dichvu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatDV capnhatDV = new capnhatDV(textBox2.Text);
            this.Hide();
            capnhatDV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK profileTK = new profileTK(textBox2.Text);
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
