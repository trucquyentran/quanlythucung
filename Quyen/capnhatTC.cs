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
	public partial class capnhatTC : Form
	{
        public string emailDN;
        public capnhatTC()
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


        public capnhatTC( String email)

        {
            InitializeComponent();
         
            this.emailDN = email;


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

		public void HienThiCombobox(string query, ComboBox comb, string ma, string giong)
		{
			SqlCommand sql = new SqlCommand(query, conn);
			SqlDataReader read = sql.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(read);
			comb.DataSource = dt;
			comb.DisplayMember = giong;
			comb.ValueMember = ma;

		}

		private void capnhatTC_Load(object sender, EventArgs e)
		{
			ketnoi();
            textBox1.Text = emailDN;
            if (textBox1.Text != "admin@gmail.com")
            {
               // button3.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtThôngTinToolStripMenuItem.Enabled = false;
                //  cậpNhậtSảnPhẩmToolStripMenuItem.Enabled = false;

                //  cậpNhậtThúCưngToolStripMenuItem.Enabled = false;
                cậpNhậtDịchVụToolStripMenuItem.Enabled = false;
            }
            HienThi_TK("SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma", luoi_dlieu);
            HienThiCombobox("SELECT * FROM GiongThuCung", giong, "GTC_ma", "GTC_ten");
            HienThiCombobox("SELECT * FROM KhachHang", cbkhach, "KH_ma", "KH_ten");
        }

		//private void search_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//	string query = "select * from ThuCung  where TC_ma = '" + search.Text + "'";
		//	HienThi_TK(query, luoi_dlieu);
		//}

		

		




        private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[3].Value.ToString();
			ten.Text = luoi_dlieu.Rows[e.RowIndex].Cells[4].Value.ToString();
			dacdiem.Text = luoi_dlieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            gt.Text = luoi_dlieu.Rows[e.RowIndex].Cells[6].Value.ToString();
            giong.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
            //   giong.Text = luoi_dlieu.Rows[e.RowIndex].Cells[4].Value.ToString();
          //  khach.Text= luoi_dlieu.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbkhach.Text = luoi_dlieu.Rows[e.RowIndex].Cells[10].Value.ToString();
            ma.Enabled = false;
		}

		
        private void button4_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma  and TC_ma = '" + search.Text + "'";
			HienThi_TK(query, luoi_dlieu);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            thucung thucung = new thucung(textBox1.Text);
            this.Hide();
            thucung.ShowDialog();
            this.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dacdiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void timkiemten(object sender, KeyEventArgs e)
        {
            //  string query = "select * from KhachHang  where KH_ma = '" + textBox_timkiem.Text + "'";
            string quer = "select  * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma and TC_ten LIKE  N'%" + search.Text + "%'";
            // HienThi_TK(query, luoi_dlieu);
            HienThi_TK(quer, luoi_dlieu);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

            string newQuery = "select SUBSTRING(MAX(TC_ma),3,2)+1 " +
                              "from ThuCung";
            SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase);
            int a = (int)dase.Tables[0].Rows[0][0];
            string newTC_ma = "TC0" + a.ToString();
            ma.Text = newTC_ma;
            ma.Enabled = false;
            ten.Text = "";
            dacdiem.Text = "";
            gt.Text = "";
            giong.Text = "";
            cbkhach.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn thú cưng", "Thông báo!");
            }
            else
            {
                SqlCommand sql_Sua = new SqlCommand("update ThuCung set TC_ten = N'" + ten.Text + "', TC_dacdiem = '" + dacdiem.Text + "', TC_gioitinh = N'" + gt.Text + "', GTC_ma = '" + giong.SelectedValue + "', KH_ma = '" + cbkhach.SelectedValue + "' where TC_ma = '" + ma.Text + "'", conn);
                sql_Sua.ExecuteNonQuery();
                MessageBox.Show("Sửa thú cưng: "+ma.Text+" thành công", "Thông báo!");
                HienThi_TK("SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma", luoi_dlieu);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn thú cưng", "Thông báo!");
            }
            else
            {
                SqlCommand sql_them = new SqlCommand("delete from ThuCung where TC_ma = '" + ma.Text + "'", conn);
                sql_them.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công", "Thông báo!");
                HienThi_TK("SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma", luoi_dlieu);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand sql_them = new SqlCommand("insert into ThuCung values" +
                                  "('" + ma.Text + "', N'" + ten.Text + "', N'" + dacdiem.Text + "', N'" + gt.Text + "', '" + giong.SelectedValue + "', '" + cbkhach.SelectedValue + "') ", conn);
            sql_them.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công thú cưng: " + ma.Text, "Thông báo!");
            HienThi_TK("SELECT * FROM GiongThuCung a, ThuCung b,KhachHang c where a.GTC_ma=b.GTC_ma and b.KH_ma=c.KH_ma", luoi_dlieu);
          
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
            ten.Text = "";
            gt.Text = "";
            giong.Text = "";
            dacdiem.Text = "";
            cbkhach.Text = "";
        }

        private void themgiong_Click(object sender, EventArgs e)
        {
            capnhatGTC capnhatGTC = new capnhatGTC();
            this.Hide();
            capnhatGTC.ShowDialog();
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
