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
	public partial class cappnhatNV : Form
	{
        public string emailDN;
        SqlConnection conn;
		public cappnhatNV()
		{
			InitializeComponent();
		}

		public void ketnoi()
		{
			String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
			conn = new SqlConnection(ketnoi);
			conn.Open();

		}
        public cappnhatNV(String email)

        {
            InitializeComponent();

            this.emailDN = email;


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
		private void tabPage1_Click(object sender, EventArgs e)
		{

		}

		private void cappnhatNV_Load(object sender, EventArgs e)
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
            HienThiCombobox("select * from ChucVu", cv, "CV_ma", "CV_ten");
            string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";
            HienThi_TK(query, luoi_dlieu);
        }

		private void Add_Click(object sender, EventArgs e)
		{
			
			string newQuery = "select SUBSTRING(MAX(NV_ma),3,2)+1 " +
							  "from NhanVien";
			SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase);
			int a = (int)dase.Tables[0].Rows[0][0];
			string newNV_ma = "NV0" + a.ToString();
			ma.Text = newNV_ma;
			ma.Enabled = false;
			ten.Text = "";
			gt.Text = "";
			sdt.Text = "";
			dchi.Text = "";
            mk.Text = "";
            cv.Text = "";
            email.Text = "";
            ngaysinh.Value = DateTime.Now;

        }

		private void button3_Click(object sender, EventArgs e)
		{
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo!");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xoá nhân viên này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand sql_xoa = new SqlCommand("delete from NhanVien where NV_ma = '" + ma.Text + "'", conn);
                    sql_xoa.ExecuteNonQuery();
                    MessageBox.Show("Đã xoá nhân viên: " + ma.Text);
                    string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";

                    HienThi_TK(query, luoi_dlieu);
                }
               
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {

            string NV_sdt = sdt.Text;
            bool NolaSo = sdt.Text.All(char.IsDigit);
            int val;
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn nhân viên", "Thông báo!");
            }
            else
            {
                if (NolaSo)
                {
                    if (NV_sdt.Length == 10)
                    {
                        NolaSo = sdt.Text.All(char.IsDigit);

                        SqlCommand sql_Sua = new SqlCommand("update NhanVien set NV_ten = N'" + ten.Text + "', NV_gioitinh = N'" + gt.Text + "', NV_sdt = '" + sdt.Text + "' ,NV_email = '" + email.Text + "', NV_pwd = '" + mk.Text + "', CV_ma = '" + cv.SelectedValue + "', NV_diachi= N'" + dchi.Text + "', NV_ngaysinh = '" + ngaysinh.Value.ToShortDateString() + "' where NV_Ma = '" + ma.Text + "'", conn);
                        sql_Sua.ExecuteNonQuery();
                        MessageBox.Show("Đã sửa thông tin nhân viên: " + ma.Text);
                        string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";
                        HienThi_TK(query, luoi_dlieu);
                    }
                    else
                    {
                        MessageBox.Show("Độ dài số điện thoại không hợp lệ", "Thông báo!");
                    }

                }
                else
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo!");
            }


        
       
        }


		private void btnXem_Click(object sender, EventArgs e)
		{
			profileNV profileNV = new profileNV(ma.Text);
            this.Hide();
            profileNV.ShowDialog();
            this.Show();
            this.Close();
        }

		private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[0].Value.ToString();
			ten.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
			gt.Text = luoi_dlieu.Rows[e.RowIndex].Cells[2].Value.ToString();
			sdt.Text = luoi_dlieu.Rows[e.RowIndex].Cells[3].Value.ToString();         
            
            mk.Text = luoi_dlieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            email.Text = luoi_dlieu.Rows[e.RowIndex].Cells[4].Value.ToString();
            cv.Text = luoi_dlieu.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
            dchi.Text = luoi_dlieu.Rows[e.RowIndex].Cells[7].Value.ToString();
            ngaysinh.Text = luoi_dlieu.Rows[e.RowIndex].Cells[8].Value.ToString();
            ma.Enabled = false;
		}

		private void Luu_Click(object sender, EventArgs e)
		{
			string MaNV = ma.Text;
			string TenNV = ten.Text;
			string KH_gioitinh = gt.Text;
			string NV_sdt = sdt.Text;
			string KH_diachi = dchi.Text;
            string KH_mk = mk.Text;
            string KH_cv = cv.Text;
            string KH_email = email.Text;
            string NV_ngausinh = ngaysinh.Text;
            bool NolaSo = sdt.Text.All(char.IsDigit);
            int val;
            if (NolaSo)
            {
                if (NV_sdt.Length == 10)
                {
                    NolaSo = sdt.Text.All(char.IsDigit);

                    SqlCommand sql_them = new SqlCommand("insert into NhanVien values " +
                                          "('" + ma.Text + "', N'" + ten.Text + "', N'" + gt.Text + "', '" + sdt.Text + "','" + email.Text + "','" + mk.Text + "','" + cv.SelectedValue + "',N'" + dchi.Text + "','" + ngaysinh.Value.ToShortDateString() + "') ", conn);
                    sql_them.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm nhân viên: " + ma.Text);
                    string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma";
                    HienThi_TK(query, luoi_dlieu);
                }else
                {
                    MessageBox.Show("Độ dài số điện thoại không hợp lệ", "Thông báo!");
                }

            }
            else
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo!");


        }

		//private void button4_Click(object sender, EventArgs e)
		//{
		//	string query = "select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma and NV_Ma = '" + search.Text + "'";
		//	HienThi_TK(query, luoi_dlieu);
		//}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhanvien nhanvien = new nhanvien(textBox1.Text);
            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        private void timkiem(object sender, KeyEventArgs e)
        {

            HienThi_TK("select * from NhanVien a, ChucVu b where a.CV_ma=b.CV_ma and(nv_ma = '" + search.Text + "' OR nv_ten like N'%" + search.Text + "%')", luoi_dlieu);
           // HienThi_TK("select * from NhanVien a, ChucVu b where a.CV_ma = b.CV_ma and NV_Ma LIKE '%" + search.Text + "%'", luoi_dlieu);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu form6 = new trangchu(textBox1.Text);
            this.Hide();
            form6.ShowDialog();
            this.Show();
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

        private void cậpNhậtThôngTinToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
            ten.Text = "";
            gt.Text = "";
            sdt.Text = "";
            dchi.Text = "";
            mk.Text = "";
            cv.Text = "";
            email.Text = "";
            ngaysinh.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            capnhatCV capnhatCV = new capnhatCV();
            this.Hide();
            capnhatCV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
