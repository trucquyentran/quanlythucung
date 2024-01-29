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
    public partial class dichvu : Form
    {
        public string emailDN;
        public dichvu()
        {
            InitializeComponent();
        }
        public dichvu(String email)

        {
            InitializeComponent();
            this.emailDN = email;
        }
        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
            this.Close();
        }
		SqlConnection conn;
		public void ketnoi()
		{
			String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
			conn = new SqlConnection(ketnoi);
			conn.Open();

		}

		public void HienThi_lenluoiDuLieu(DataGridView dg)
		{
			ketnoi();
			string query = "SELECT * FROM DichVu";
			SqlDataAdapter dt = new SqlDataAdapter(query, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase, "DS_DichVu");
			dg.DataSource = dase;
			dg.DataMember = "DS_DichVu";

		}
        public void HienThiLenDataGridView(string cautruyvan, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DS");
            dg.DataSource = ds;
            dg.DataMember = "DS";
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
		private void dichvu_Load(object sender, EventArgs e)
		{
            ketnoi();
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
                button5.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
              //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

              //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);
        }

		

		private void button_them_Click(object sender, EventArgs e)
		{
			capnhatDV capnhatDV = new capnhatDV();
            this.Hide();
            capnhatDV.ShowDialog();
            this.Show();
            this.Close();
        }

		

		private void button1_Click(object sender, EventArgs e)
		{
			In_DS_DV In_DS_DV = new In_DS_DV();
			In_DS_DV.Show();
		}

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();

        }

        private void timkiem(object sender, KeyEventArgs e)
        {
            string gtrigovao = search.Text;
           
                string timkiem = "Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where (dv_ma = '" + gtrigovao + "' OR dv_ten like N'%" + gtrigovao + "%') AND dichvu.nv_ma = nhanvien.nv_ma";
                HienThiLenDataGridView(timkiem, dataGridView1);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            capnhatDV dv = new capnhatDV();
            this.Hide();
            dv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu(textBox1.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien form6 = new nhanvien(textBox1.Text);
            this.Hide();
            form6.ShowDialog();
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
            nhanvien form6 = new nhanvien(textBox1.Text);
            this.Hide();
            form6.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP cdp = new capnhatSP(textBox1.Text);
            this.Hide();
            cdp.ShowDialog();
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

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatDV cdp = new capnhatDV(textBox1.Text);
            this.Hide();
            cdp.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            In_DS_DV In_DS_DV = new In_DS_DV();
            In_DS_DV.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu(textBox1.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
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
