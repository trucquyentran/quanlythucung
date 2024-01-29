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
    public partial class trangchu : Form
    {
        public string emailDN;
        // String NV_email = "",NV_ten="", NV_pwd = "", NV_quyen = "";
        // String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";


        public SqlConnection conn;
        public trangchu()
        {
            InitializeComponent();
        }
        public trangchu(string email) 
        {
                InitializeComponent();
            this.emailDN = email;
            
        }

        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();
            //SqlDataAdapter da;
            //DataTable dt;
            //SqlCommand cmd;


        }
      
        //public trangchu(String NV_email, String NV_ten, String NV_pwd, String NV_quyen)
        //{
        //    InitializeComponent();
        //    this.NV_email = NV_email;
        //    this.NV_ten = NV_ten;
        //    this.NV_pwd = NV_pwd;
        //    this.NV_pwd = NV_quyen;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
			sanpham sanpham = new sanpham(textBox1.Text);
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button_dsKH_Click(object sender, EventArgs e)
        {
            khachhang form5 = new khachhang(textBox1.Text);
            this.Hide();
            form5.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button_dsNV_Click(object sender, EventArgs e)
        {
            nhanvien form6 = new nhanvien();
            this.Hide();
            form6.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            dangnhap dangnhap = new dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button_Profile5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
            this.Close();
        }

		private void button_dsDV_Click(object sender, EventArgs e)
		{
			dichvu dichvu = new dichvu(textBox1.Text);
            this.Hide();
            dichvu.ShowDialog();
            this.Show();
            this.Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			thucung thucung = new thucung(textBox1.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			hoadon hoadon = new hoadon();
            this.Hide();
            hoadon.ShowDialog();
            this.Show();
            this.Close();
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            ketnoi();
            
          //string ctv=("Select NV_ten form Nhanvien where NV_ma ='"+ emailDN + "'");
            textBox1.Text = emailDN;

            if (textBox1.Text != "admin@gmail.com")
            { 
                thốngKêToolStripMenuItem.Enabled = false;
            cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
           // cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;
          
        //    cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
            cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
 }


        }

	

        private void button3_Click_2(object sender, EventArgs e)
        {
            chu chu = new chu();
            this.Hide();
            chu.ShowDialog();
            chu.Show();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dn = new dangnhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
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

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ketnoi();
            //SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where NV_email ='" + textBox_emailDN.Text + "' and NV_pwd ='" + textBox_matkhauDN.Text + "'", conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if (textBox1.Text == "admin@gmail.com")
            //{
            //    khachhang form5 = new khachhang();
            //    this.Hide();
            //    form5.ShowDialog();
            //    this.Show();
            //    this.Close();
            //}
            //else 
            //{
            //    MessageBox.Show("a");
            //};
            thongke thongke = new thongke(textBox1.Text);
            this.Hide();
            thongke.ShowDialog();
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

      

        //private void đăngXuấtToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
        //        this.Close();
        //}

        private void trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
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
            profileTK tk = new profileTK(textBox1.Text);
            this.Hide();
            tk.ShowDialog();
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

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP cdp = new capnhatSP(textBox1.Text);
            this.Hide();
            cdp.ShowDialog();
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
    
  

