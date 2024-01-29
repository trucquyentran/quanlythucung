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
    public partial class profileTK : Form
    {
        public string emailDN;

        public profileTK()
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

        public profileTK(String email)
        {
            InitializeComponent();
            this.emailDN = email;
        }

        public void HienThi()
        {
            ketnoi();
            string query = "SELECT * FROM NhanVien where NV_email =  '" + emailDN + "'";

            SqlCommand comand = new SqlCommand(query, conn);
            SqlDataReader read = comand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(read);
            // label1.Text = dt.Rows[0]["description"].ToString();
            makh.Text = dt.Rows[0]["NV_ma"].ToString();
            hoten.Text = dt.Rows[0]["NV_ten"].ToString();
            gioitinh.Text = dt.Rows[0]["NV_gioitinh"].ToString();
            sdt.Text = dt.Rows[0]["NV_sdt"].ToString();
            diachi.Text = dt.Rows[0]["NV_diachi"].ToString();
            //textBox1.Text = dt.Rows[0]["description"].ToString();
            //textBox1.Text = dt.Rows[0]["description"].ToString();

        }
        private void profileTK_Load(object sender, EventArgs e)
        {
            textBox1.Text = emailDN;
            HienThi();
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
            sanpham sp = new sanpham(textBox1.Text);
            this.Hide();
            sp.ShowDialog();
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

        private void cậpNhậtGiốngThúCưngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            capnhatNG capnhatNG = new capnhatNG();
            this.Hide();
            capnhatNG.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
