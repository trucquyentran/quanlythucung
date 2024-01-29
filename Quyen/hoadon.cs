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
	public partial class hoadon : Form
	{
		public hoadon()
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

		public void HienThi_lenluoiDuLieu(DataGridView dg)
		{
			ketnoi();
			string query = "Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap,HD_tong from NhanVien a, KhachHang b, HoaDon c where a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma";
			SqlDataAdapter dt = new SqlDataAdapter(query, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase, "DS_HoaDon");
			dg.DataSource = dase;
			dg.DataMember = "DS_HoaDon";

		}



		public void HienThi_TK(string query, DataGridView dg)
		{
			ketnoi();
			SqlDataAdapter dt = new SqlDataAdapter(query, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase, "DS_HoaDon");
			dg.DataSource = dase;
			dg.DataMember = "DS_HoaDon";
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
		private void hoadon_Load(object sender, EventArgs e)
		{
			ketnoi();

			HienThi_lenluoiDuLieu(luoi_dlieuHD);
		}

		private void textBox_timkiem_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap,HD_tong from NhanVien a, KhachHang b, HoaDon c where a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and HD_ma = '" + search.Text + "'";
			HienThi_TK(query, luoi_dlieuHD);
		}

		private void button_them_Click(object sender, EventArgs e)
		{
			capnhatHD capnhatHD = new capnhatHD();
            this.Hide();
            capnhatHD.ShowDialog();
            this.Show();
            this.Close();
        }

		private void button_timkiem_Click(object sender, EventArgs e)
		{

			string query = "Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap,HD_tong from NhanVien a, KhachHang b, HoaDon c where a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma  and HD_ma = '" + search.Text + "'";
			HienThi_TK(query, luoi_dlieuHD);

		}

		private void button_trangchu_Click(object sender, EventArgs e)
		{
			trangchu trangchu = new trangchu();
			trangchu.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			In_DS_HD In_DS_HD = new In_DS_HD();
			In_DS_HD.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void textBox_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            HienThi_TK("Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap,HD_tong from NhanVien a, KhachHang b, HoaDon c where a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and (HD_ma = '" + search.Text + "' OR KH_ten like N'%" + search.Text + "%'  OR NV_ten like N'%" + search.Text + "%')", luoi_dlieuHD);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
