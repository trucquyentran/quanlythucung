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
    public partial class profileKH : Form
    {
        public string nhanDuLieu;
        public string emailDN;
        public profileKH()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }

		 public profileKH(String makh, String email )
          
        {
            InitializeComponent();
            this.nhanDuLieu = makh;
            this.emailDN = email;
           

        }



        public void HienThi()
      {
         ketnoi();
         string query = "SELECT * FROM KhachHang where KH_ma =  '" + nhanDuLieu + "'";
  
            SqlCommand comand = new SqlCommand(query, conn);
            SqlDataReader read = comand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
           // label1.Text = dt.Rows[0]["description"].ToString();
            hoten.Text = dt.Rows[0]["KH_ten"].ToString();
            gioitinh.Text = dt.Rows[0]["KH_gioitinh"].ToString();
            sdt.Text = dt.Rows[0]["KH_sdt"].ToString();
            diachi.Text = dt.Rows[0]["KH_diachi"].ToString();
            //textBox1.Text = dt.Rows[0]["description"].ToString();
            //textBox1.Text = dt.Rows[0]["description"].ToString();

        }



       

        private void Form2_Load(object sender, EventArgs e)
        {
            makh.Text = nhanDuLieu;
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
             //   button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
                //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

                //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThi();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*
            ketnoi();

            HienThi_lenluoiDuLieu(dulieuKH_ten);*/
        }

        private void label_hoten_Click(object sender, EventArgs e)
        {

        }

        private void label_datMK_Click(object sender, EventArgs e)
        {

        }

        private void button_capnhatTK_Click(object sender, EventArgs e)
        {
			Form1 capnhat = new Form1(textBox1.Text);		
            this.Hide();
            capnhat.ShowDialog();
            this.Show();
            this.Close();
        }

		private void button_uploadAnh_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			op.Filter = "Chọn hình ảnh (*.jeg; *jpg; *.tif; *jfif) | *.jpeg; *jpg; *.tif; *jfif";
			if (op.ShowDialog() == DialogResult.OK)
			{
				pictureBox_hinhanh.Image = Image.FromFile(op.FileName);

			}
		}

		private void button_trangchu_Click(object sender, EventArgs e)
		{
			trangchu trangchu = new trangchu();
			trangchu.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1(textBox1.Text);
            this.Hide();
            Form1.ShowDialog();
            Form1.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu (textBox1.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
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

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dichvu = new dichvu();
            this.Hide();
            dichvu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatDV capnhatDV = new capnhatDV();
            this.Hide();
            capnhatDV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thucung thucung = new thucung();
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC();
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtGiốngThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC();
            this.Hide();
            capnhatGTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtNguồnGốcThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatNG capnhatNG = new capnhatNG();
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang khachhang = new khachhang();
            this.Hide();
            khachhang.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            this.Hide();
            Form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham();
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP capnhatSP = new capnhatSP();
            this.Hide();
            capnhatSP.ShowDialog();
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

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien();
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV();
            this.Hide();
            cappnhatNV.ShowDialog();
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
