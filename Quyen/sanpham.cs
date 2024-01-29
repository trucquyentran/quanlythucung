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
    public partial class sanpham : Form
    {
        public string emailDN;
        public sanpham()
        {
            InitializeComponent();
        }
        public sanpham( String email)

        {
            InitializeComponent();
           
            this.emailDN = email;


        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu form7 = new trangchu();
            
            this.Hide();
            form7.ShowDialog();
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

        public void HienThiLenDataGridView(string cautruyvan, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter da = new SqlDataAdapter(cautruyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DS");
            dg.DataSource = ds;
            dg.DataMember = "DS";
        }



        private void button1_Click(object sender, EventArgs e)
		{
			In_DS_SP In_DS_SP = new In_DS_SP();
            
          
            In_DS_SP.Show();
           
        }

        private void sanpham_Load(object sender, EventArgs e)
        {
            ketnoi();
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
            HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);

        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            string gtrigovao = search.Text;
           
                string timkiem = "Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where (sp_ma = '" + gtrigovao + "' OR sp_ten like N'%" + gtrigovao + "%') AND sanpham.lsp_ma = loaisanpham.lsp_ma";
                HienThiLenDataGridView(timkiem, dataGridView1);
            
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            capnhatSP sp = new capnhatSP(textBox1.Text);
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu(textBox1.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dv = new dichvu(textBox1.Text);
            this.Hide();
            dv.ShowDialog();
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

        private void thôngTinTàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK tk = new profileTK(textBox1.Text);
            this.Hide();
            tk.ShowDialog();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            In_DS_SP In_DS_SP = new In_DS_SP();
          
            In_DS_SP.Show();
          
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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
