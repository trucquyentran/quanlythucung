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
	public partial class capnhatHD : Form
	{
		public capnhatHD()
		{
			InitializeComponent();
		}
        public string emailDN;
        SqlConnection conn;
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }
     /*   public cappnhatNV(String email)

        {
            InitializeComponent();

            this.emailDN = email;


        }*/

        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "SELECT * FROM HoaDon";
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

      
		private void capnhatHD_Load(object sender, EventArgs e)
		{
            ketnoi();
            HienThiCombobox("select * from ThuCung a, KhachHang b where a.KH_ma=b.KH_ma ", kh, "KH_ma", "KH_ten");
            kh.Text = "";
            HienThiCombobox("select * from NhanVien", nv, "NV_ma", "NV_ten");
            nv.Text = "";
            HienThiCombobox("select * from SanPham", sp, "SP_ma", "SP_ten");
            sp.Text = "";
            HienThiCombobox("select * from DichVu", dv, "DV_ma", "DV_ten");
            dv.Text = "";
            ngaylap.Value = DateTime.Now;

            thu.Text = "";
            tc.Text = "";
            tiendv.Text = "";
            tiensp.Text = "";
            tong.Text = "";
            //  HienThiCombobox("select * from ThuCung ", tc, "TC_ma", "TC_ten" );
            string query = "select c.HD_ma, KH_ten, NV_ten, HD_ngaylap, d.TC_ma, TC_ten, DV_ten, SP_ten, CTHD_slsp,CTHD_dgsp,CTHD_dgdv, HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma";
            HienThi_TK(query, luoi_dlieu);
        }

		private void search_KeyPress(object sender, KeyPressEventArgs e)
		{
			string query = "select * from HoaDon  where HD_ma = '" + search.Text + "'";
			HienThi_TK(query, luoi_dlieu);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			
			string newQuery = "select SUBSTRING(MAX(HD_ma),3,2)+1 " +
							  "from HoaDon";
			SqlDataAdapter dt = new SqlDataAdapter(newQuery, conn);
			DataSet dase = new DataSet();
			dt.Fill(dase);
			int a = (int)dase.Tables[0].Rows[0][0];
			string newHD_ma = "HD0" + a.ToString();
			ma.Text = newHD_ma;
			ma.Enabled = false;
			kh.Text = "";
			nv.Text = "";
			ngaylap.Value = DateTime.Now;
            tong.Text = "";
            sl.Text = "";
            sp.Text = "";
            dv.Text = "";
            thu.Text = "";
            tc.Text = "";
            tiendv.Text = "";
            tiensp.Text = "";
            tong.Text = "";
            ngaylap.Value = DateTime.Now;

        }



		private void sua_Click(object sender, EventArgs e)
		{
            double giasp, giadv, slsp;
            bool sanpham, dichvu, soluong;
            string tsp = tiensp.Text;
            string tdv = tiendv.Text;
            string SL = sl.Text;
            sanpham = double.TryParse(tsp, out giasp);
            dichvu = double.TryParse(tdv, out giadv);
            soluong = double.TryParse(SL, out slsp);

            double Tong = 0;
            double thanhtiensp = 0;
            thanhtiensp = giasp * slsp;

            Tong = thanhtiensp + giadv;
            ttsp.Text = thanhtiensp.ToString();
            ttdv.Text = giadv.ToString();
            tong.Text = Tong.ToString();

            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn hoá đơn", "Thông báo!");
            }
            else
            {
                

                SqlCommand sql_Suact = new SqlCommand("update ChiTietHD set TC_ma ='" + tc.Text + "' ,SP_ma = '" + sp.SelectedValue + "' ,DV_ma = '" + dv.SelectedValue + "', CTHD_slsp = '" + sl.Text + "', CTHD_dgsp = '" + tiensp.Text + "', CTHD_dgdv= '" + tiendv.Text + "' where HD_ma = '" + ma.Text + "'", conn);
                sql_Suact.ExecuteNonQuery();
                SqlCommand sql_Suahd = new SqlCommand("update HoaDon set NV_ma = '" + nv.SelectedValue + "' ,KH_ma = '" + kh.SelectedValue + "', HD_ngaylap = '" + ngaylap.Value.ToShortDateString() + "' , HD_tong = '" + Tong + "' where HD_ma = '" + ma.Text + "'", conn);
                sql_Suahd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa thông tin hoá đơn: " + ma.Text);
                string query = "select c.HD_ma, KH_ten, NV_ten, HD_ngaylap, d.TC_ma, TC_ten, DV_ten, SP_ten, CTHD_slsp,CTHD_dgsp,CTHD_dgdv, HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma";
                HienThi_TK(query, luoi_dlieu);


            }


        }

		private void button3_Click(object sender, EventArgs e)
		{
            string manv = ma.Text;
            if (manv == "")
            {
                MessageBox.Show("Chưa chọn hoá đơn", "Thông báo!");
            }
            else
            {
                if (MessageBox.Show("Bạn muốn xoá hoá đơn này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand sql_xoact = new SqlCommand("delete from ChiTietHD where HD_ma='" + ma.Text + "'", conn);
            sql_xoact.ExecuteNonQuery();
          
            SqlCommand sql_xoahd = new SqlCommand("delete from HoaDon where HD_ma='" + ma.Text + "'", conn);
            sql_xoahd.ExecuteNonQuery();
            MessageBox.Show("Đã xoá hoá đơn: " + ma.Text);
                    string query = "select c.HD_ma, KH_ten, NV_ten, HD_ngaylap, d.TC_ma, TC_ten, DV_ten, SP_ten, CTHD_slsp,CTHD_dgsp,CTHD_dgdv, HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma";
                    HienThi_TK(query, luoi_dlieu);
                }

            }
        }

	

		private void luoi_dlieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ma.Text = luoi_dlieu.Rows[e.RowIndex].Cells[0].Value.ToString();
			kh.Text = luoi_dlieu.Rows[e.RowIndex].Cells[1].Value.ToString();
			nv.Text = luoi_dlieu.Rows[e.RowIndex].Cells[2].Value.ToString();
            thu.Text = luoi_dlieu.Rows[e.RowIndex].Cells[5].Value.ToString();
            ngaylap.Text = luoi_dlieu.Rows[e.RowIndex].Cells[3].Value.ToString();
            tc.Text = luoi_dlieu.Rows[e.RowIndex].Cells[4].Value.ToString();
            dv.Text = luoi_dlieu.Rows[e.RowIndex].Cells[6].Value.ToString();
            sp.Text = luoi_dlieu.Rows[e.RowIndex].Cells[7].Value.ToString();
            sl.Text = luoi_dlieu.Rows[e.RowIndex].Cells[8].Value.ToString();
            tiensp.Text = luoi_dlieu.Rows[e.RowIndex].Cells[9].Value.ToString();     
            tiendv.Text = luoi_dlieu.Rows[e.RowIndex].Cells[10].Value.ToString();
            tong.Text = luoi_dlieu.Rows[e.RowIndex].Cells[11].Value.ToString();
           

            ma.Enabled = false;
		}

		private void Luu_Click(object sender, EventArgs e)
		{
			

            double giasp, giadv, slsp;
            bool sanpham, dichvu, soluong;
            string tsp = tiensp.Text;
            string tdv = tiendv.Text;
            string SL = sl.Text;
            sanpham = double.TryParse(tsp, out giasp);
            dichvu = double.TryParse(tdv, out giadv);
            soluong = double.TryParse(SL, out slsp);

            double Tong = 0;
            double thanhtiensp = 0;
            thanhtiensp = giasp * slsp;
           
            Tong = thanhtiensp + giadv;
            ttsp.Text = thanhtiensp.ToString();
            ttdv.Text = giadv.ToString();
            tong.Text = Tong.ToString();
			SqlCommand sql_themhd = new SqlCommand("insert into HoaDon values " +
								  "('" + ma.Text + "', '" + nv.SelectedValue + "', '" + kh.SelectedValue + "', '" + ngaylap.Value.ToShortDateString() + "', '" + Tong + "') ", conn);
            sql_themhd.ExecuteNonQuery();

            SqlCommand sql_themct = new SqlCommand("insert into ChiTietHD  values " +
                                  "('" + ma.Text + "','" + tc.Text + "','" + dv.SelectedValue + "','" + sp.SelectedValue + "','" + sl.Text + "','" + tiendv.Text + "','" + tiensp.Text + "') ", conn);
            sql_themct.ExecuteNonQuery();

            MessageBox.Show("Đã thêm hoá đơn: " + ma.Text);
            string query = "select c.HD_ma, KH_ten, NV_ten, HD_ngaylap, d.TC_ma, TC_ten, DV_ten, SP_ten, CTHD_slsp,CTHD_dgsp,CTHD_dgdv, HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma";
            HienThi_TK(query, luoi_dlieu);
        }

		private void button4_Click(object sender, EventArgs e)
		{
			string query = "select * from HoaDon  where HD_ma = '" + search.Text + "'";
			HienThi_TK(query, luoi_dlieu);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            hoadon hoadon = new hoadon();
            this.Hide();
            hoadon.ShowDialog();
            this.Show();
            this.Close();
        }

     
        
        public void HienThi(string query, TextBox a)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_HoaDon");
          
        }

        private void sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataRowView ht = (DataRowView)sp.SelectedItem;
            tiensp.Text = ht.Row["SP_dongia"].ToString();
           
        }

        private void kh_SelectedIndexChanged(object sender,EventArgs e )
        {
            DataRowView ht = (DataRowView)kh.SelectedItem;
           // thu.Text = ht.Row["TC_ten"].ToString();
            thu.Text = ht.Row["TC_ten"].ToString();
            tc.Text = ht.Row["TC_ma"].ToString();



        }

        private void dv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView ht = (DataRowView)dv.SelectedItem;
          
           tiendv.Text = ht.Row["DV_dongia"].ToString();
            
        }

      

        private void reset_Click(object sender, EventArgs e)
        {
            ma.Text = "";
           
            kh.Text = "";
            nv.Text = "";
            ngaylap.Value = DateTime.Now;
            tong.Text = "";
            sp.Text = "";
            dv.Text = "";
            thu.Text = "";
            tc.Text = "";
            sl.Text = "";
            tiendv.Text = "";
            tiensp.Text = "";
            tong.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV();
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            HienThi_TK("Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap,HD_tong from NhanVien a, KhachHang b, HoaDon c where a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and (HD_ma = '" + search.Text + "' OR KH_ten like N'%" + search.Text + "%'  OR NV_ten like N'%" + search.Text + "%')", luoi_dlieu);

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
