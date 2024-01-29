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
	public partial class capnhatDV : Form
	{
        public string emailDN;
        SqlConnection conn;
		public capnhatDV()
		{
			InitializeComponent();
		}
		public void ketnoi()
		{
			String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
			conn = new SqlConnection(ketnoi);
			conn.Open();

		}
        public capnhatDV(String email)

        {
            InitializeComponent();
            this.emailDN = email;
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


		

        private void button7_Click(object sender, EventArgs e)
        {
            string newQuery = "select SUBSTRING(MAX(dv_ma),3,2)+1 " +
                                "from dichvu";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newMaDV = "DV0" + a.ToString();
            madv.Text = newMaDV;
            madv.Enabled = false;
            tendv.Text = "";
            gia.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string maloaisp = nhanvien.SelectedValue.ToString();
            string tenloaisp = nhanvien.Text;
            SqlCommand sql_Sua = new SqlCommand("update dichvu set dv_ma = '" + madv.Text + "', dv_ten = N'" + tendv.Text +
              "', dv_dongia = '" + gia.Text + "', nv_ma = '" + maloaisp + "' where dv_ma = '" + madv.Text + "'", conn);
            sql_Sua.ExecuteNonQuery();
            HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string masp = madv.Text;
            if (masp == "")
            {
                MessageBox.Show("chua chon dich vu nao");
            }
            else
            {
                string xoa_sql = "Delete from dichvu where dv_ma = '" + masp + "' ";
                SqlCommand comd = new SqlCommand(xoa_sql, conn);
                comd.BeginExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string masp = madv.Text;
            string tensp = tendv.Text;
            string gia = this.gia.Text;
            string malsp = nhanvien.SelectedValue.ToString();



            SqlCommand sql_them = new SqlCommand("insert into dichvu values " + "('" + masp + "', N'" + tensp + "', '" + gia + "', '" + malsp + "')", conn);

            sql_them.ExecuteNonQuery();
            HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);

        }

        private void capnhatDV_Load(object sender, EventArgs e)
        {
            ketnoi();
            textBox4.Text = emailDN;
            if (textBox4.Text != "admin@gmail.com")
            {
              //  button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
              //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

               // cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);
            HienThiCombobox("Select * from nhanvien", nhanvien, "nv_ma", "nv_ten");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            madv.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tendv.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            gia.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nhanvien.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            madv.Enabled = false;
        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            string gtrigovao = search.Text;
           
                string timkiem = "Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where (dv_ma = '" + gtrigovao + "' OR dv_ten like N'%" + gtrigovao + "%') AND dichvu.nv_ma = nhanvien.nv_ma";
                HienThiLenDataGridView(timkiem, dataGridView1);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu tc = new trangchu(textBox4.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
            this.Close();
        }

       

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox4.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien form6 = new nhanvien(textBox4.Text);
            this.Hide();
            form6.ShowDialog();
            this.Show();
            this.Close();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham(madv.Text);
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP cdp = new capnhatSP(madv.Text);
            this.Hide();
            cdp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
         khachhang form5 = new khachhang(madv.Text);
                    this.Hide();
                    form5.ShowDialog();
                    this.Show();
                    this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(madv.Text);
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            thucung thucung = new thucung(madv.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC(madv.Text);
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dv = new dichvu(madv.Text);
            this.Hide();
            dv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK tk = new profileTK(madv.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            dichvu dichvu = new dichvu(madv.Text);
            this.Hide();
            dichvu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string newQuery = "select SUBSTRING(MAX(dv_ma),3,2)+1 " +
                                "from dichvu";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newMaDV = "DV0" + a.ToString();
            madv.Text = newMaDV;
            madv.Enabled = false;
            tendv.Text = "";
            gia.Text = "";
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string Madv = madv.Text;
            if (Madv == "")
            {
                MessageBox.Show("Chưa chọn dịch vụ", "Thông báo!");
            }
            else
            {
                string maloaisp = nhanvien.SelectedValue.ToString();
                string tenloaisp = nhanvien.Text;
                SqlCommand sql_Sua = new SqlCommand("update dichvu set dv_ma = '" + madv.Text + "', dv_ten = N'" + tendv.Text +
                  "', dv_dongia = '" + gia.Text + "', nv_ma = '" + maloaisp + "' where dv_ma = '" + madv.Text + "'", conn);
                sql_Sua.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công dịch vụ: "+madv.Text, "Thông báo!");
                HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string masp = madv.Text;
            if (masp == "")
            {
                MessageBox.Show("chua chon dich vu nao");
            }
            else
            {
                string xoa_sql = "Delete from dichvu where dv_ma = '" + masp + "' ";
                SqlCommand comd = new SqlCommand(xoa_sql, conn);
                comd.BeginExecuteNonQuery();
                MessageBox.Show("Xoá thành công", "Thông báo!");
                HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);

            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {

            string masp = madv.Text;
            string tensp = tendv.Text;
            string Gia = this.gia.Text;
         //  string malsp = nhanvien.SelectedValue;



            SqlCommand sql_them = new SqlCommand("insert into dichvu values " + "('" + masp + "', N'" + tensp + "', '" + Gia + "', '" + nhanvien.SelectedValue + "')", conn);

            sql_them.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công dịch vụ: "+madv.Text, "Thông báo!");
            HienThiLenDataGridView("Select dv_ma as 'Mã Dịch Vụ', dv_ten as 'Tên Dịch Vụ', dv_dongia as 'Đơn Giá', nv_ten as 'Nhân Viên Đạm Nhận' from dichvu, nhanvien where dichvu.nv_ma = nhanvien.nv_ma", dataGridView1);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            madv.Text = "";
            tendv.Text = "";
            nhanvien.Text = "";
            gia.Text = "";
          
        }

        private void cậpNhậtLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatSP capnhatSP = new capnhatSP();
            this.Hide();
            capnhatSP.ShowDialog();
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
