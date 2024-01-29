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
	public partial class capnhatSP : Form
	{
        public string emailDN;
        SqlConnection conn;
		public capnhatSP()
		{
			InitializeComponent();
		}
		public void ketnoi()
		{
			String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
			conn = new SqlConnection(ketnoi);
			conn.Open();

		}
        public capnhatSP(String email)

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
        public void HienThiLenCB(string cautruyvan, ComboBox cb, string ShowVal, string HideVal)
        {
            SqlCommand cm = new SqlCommand(cautruyvan, conn);
            SqlDataReader read = cm.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(read);
            cb.DataSource = table;
            cb.DisplayMember = ShowVal;
            cb.ValueMember = HideVal;

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham();
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            string maloaisp = comboBox1.SelectedValue.ToString();
            string tenloaisp = comboBox1.Text;
            SqlCommand sql_Sua = new SqlCommand("update sanpham set sp_ma = '" + ma.Text + "', sp_ten = N'" + textBox2.Text +
              "', sp_dongia = '" + textBox3.Text + "', lsp_ma = '" + maloaisp + "' where sp_ma = '" + ma.Text + "'", conn);
            sql_Sua.ExecuteNonQuery();

            HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string masp = ma.Text;
            if (masp == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!");
            }
            else
            {
                string xoa_sql = "Delete from sanpham where sp_ma = '" + masp + "' ";
                SqlCommand comd = new SqlCommand(xoa_sql, conn);
                comd.BeginExecuteNonQuery();
                MessageBox.Show("Xoa thanh cong");
                HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string masp = ma.Text;
            string tensp = textBox2.Text;
            string gia = textBox3.Text;
            string malsp = comboBox1.SelectedValue.ToString();



            SqlCommand sql_them = new SqlCommand("insert into sanpham values " + "('" + masp + "', N'" + tensp + "', '" + gia + "', '" + malsp + "')", conn);

            sql_them.ExecuteNonQuery();

            HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);
        }

        private void capnhatSP_Load(object sender, EventArgs e)
        {
            ketnoi();
            textBox5.Text = emailDN;
            if (textBox5.Text != "admin@gmail.com")
            {
                //   button_them.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
                //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

                //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);
            HienThiLenCB("Select * from loaisanpham", comboBox1, "lsp_ten", "lsp_ma");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ma.Enabled = false;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            string gtrigovao = textBox4.Text;
          
                string timkiem = "Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where (sp_ma = '" + gtrigovao + "' OR sp_ten like N'%" + gtrigovao + "%') AND sanpham.lsp_ma = loaisanpham.lsp_ma";
                HienThiLenDataGridView(timkiem, dataGridView1);
            
        }

       

        private void trangChủToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            trangchu tc = new trangchu(textBox5.Text);
            this.Hide();
            tc.ShowDialog();
            tc.Show();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nhanvien form6 = new nhanvien(textBox5.Text);
            this.Hide();
            form6.ShowDialog();
            this.Show();
            this.Close();
        }

       

        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox5.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham(textBox5.Text);
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang form5 = new khachhang(textBox5.Text);
            this.Hide();
            form5.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(textBox5.Text);
            this.Hide();
            form1.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thucung thucung = new thucung(textBox5.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtThúCưngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatTC capnhatTC = new capnhatTC(textBox5.Text);
            this.Hide();
            capnhatTC.ShowDialog();
            this.Show();
            this.Close();
        }

        private void danhSáchDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dichvu dv = new dichvu(textBox5.Text);
            this.Hide();
            dv.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhatDV cdp = new capnhatDV(textBox5.Text);
            this.Hide();
            cdp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void thôngTinTàiKhoànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profileTK tk = new profileTK(textBox5.Text);
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

        private void Add_Click(object sender, EventArgs e)
        {
            string newQuery = "select SUBSTRING(MAX(sp_ma),3,2)+1 " +
                             "from sanpham";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newMaSP = "SP0" + a.ToString();
            ma.Text = newMaSP;
            ma.Enabled = false;
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string masp = ma.Text;
            if (masp == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!", "Thông báo!");
            }
            else
            {
                string maloaisp = comboBox1.SelectedValue.ToString();
                string tenloaisp = comboBox1.Text;
                SqlCommand sql_Sua = new SqlCommand("update sanpham set sp_ma = '" + ma.Text + "', sp_ten = N'" + textBox2.Text +
                  "', sp_dongia = '" + textBox3.Text + "', lsp_ma = '" + maloaisp + "' where sp_ma = '" + ma.Text + "'", conn);
                sql_Sua.ExecuteNonQuery();

                HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string masp = ma.Text;
            if (masp == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm nào!", "Thông báo!");
            }
            else
            {
                string xoa_sql = "Delete from sanpham where sp_ma = '" + masp + "' ";
                SqlCommand comd = new SqlCommand(xoa_sql, conn);
                comd.BeginExecuteNonQuery();
                MessageBox.Show("Xoá thành công","Thông báo!");
                HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);

            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            string masp = ma.Text;
            string tensp = textBox2.Text;
            string gia = textBox3.Text;
            string malsp = comboBox1.SelectedValue.ToString();



            SqlCommand sql_them = new SqlCommand("insert into sanpham values " + "('" + masp + "', N'" + tensp + "', '" + gia + "', '" + malsp + "')", conn);

            sql_them.ExecuteNonQuery();
             MessageBox.Show("Thêm thành công: "+ma.Text, "Thông báo!");

            HienThiLenDataGridView("Select sp_ma as 'Mã Sản Phẩm', sp_ten as 'Tên Sản Phẩm', sp_dongia as 'Đơn Giá', lsp_ten as 'Loại Sản Phẩm' from sanpham, loaisanpham where sanpham.lsp_ma = loaisanpham.lsp_ma", dataGridView1);

        }

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sanpham sanpham = new sanpham(textBox2.Text);
            this.Hide();
            sanpham.ShowDialog();
            this.Show();
            this.Close();
        }

        private void themloai_Click(object sender, EventArgs e)
        {
            capnhatLSP capnhatLSP = new capnhatLSP();
            this.Hide();
            capnhatLSP.ShowDialog();
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

        private void cậpNhậtNguồnGốThúCưngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
