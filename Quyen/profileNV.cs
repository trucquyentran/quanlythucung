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
	public partial class profileNV : Form
	{
		public string nhanDuLieu;
		public profileNV()
		{
			InitializeComponent();
		}
		SqlConnection conn;
		public void ketnoi()
		{
			String ketnoi = "Server= DESKTOP-61FTO1U; Database= ThuCung;integrated security=true";
			conn = new SqlConnection(ketnoi);
			conn.Open();

		}

		public profileNV(String giatri)
		  : this()
		{
			nhanDuLieu = giatri;
		}





		public void HienThi()
		{
			ketnoi();
			string query = "SELECT * FROM NhanVien where NV_ma =  '" + nhanDuLieu + "'";
			SqlDataAdapter dt = new SqlDataAdapter(query, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase, "TT");
			dulieuTenNV.DataSource = dase;
			dulieuTenNV.DataMember = "TT";

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

		private void profileNV_Load(object sender, EventArgs e)
		{
			ten.Text = nhanDuLieu;

			HienThi();

		}

		private void button_capnhatTK_Click(object sender, EventArgs e)
		{
			cappnhatNV cappnhatNV = new cappnhatNV();
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

		private void dulieuKH_ten_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*
			ma.Text = dulieuTenNV.Rows[e.RowIndex].Cells[0].Value.ToString();
			KH_sdt.Text = dulieuTenNV.Rows[e.RowIndex].Cells[1].Value.ToString();
			KH_diachi.Text = dulieuTenNV.Rows[e.RowIndex].Cells[2].Value.ToString();*/

		}

		private void button_trangchu_Click(object sender, EventArgs e)
		{
			trangchu trangchu = new trangchu();
			trangchu.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV();
            this.Hide();
            cappnhatNV.ShowDialog();
            cappnhatNV.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
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

        private void thôngTinTàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK profileTK = new profileTK();
            this.Hide();
            profileTK.ShowDialog();
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
    }
    
}
