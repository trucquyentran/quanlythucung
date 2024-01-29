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
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
        }
        public string emailDN;
        SqlConnection conn;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ChamSocThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }
        public thongke(String email)

        {
            InitializeComponent();

            this.emailDN = email;


        }


        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap, TC_ten,DV_ten,SP_ten,HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_TK");
            dg.DataSource = dase;
            dg.DataMember = "DS_TK";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_TK");
            dg.DataSource = dase;
            dg.DataMember = "DS_TK";
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
        private void thongke_Load(object sender, EventArgs e)
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
            HienThiCombobox("select * from NhanVien", nv, "NV_ma", "NV_Ten");
            nv.Text = "";
            HienThiCombobox("select * from SanPham", sp, "SP_ma", "SP_ten");
            sp.Text = "";
            HienThiCombobox("select * from DichVu", dv, "DV_ma", "DV_ten");
            dv.Text = "";

            HienThi_lenluoiDuLieu(luoi_dlieu);
           
            // HienThi_TK("Select c.HD_ma,NV_ma ,KH_ma ,TC_ma,DV_ma,SP_ma,HD_tong from  HoaDon c, ChiTietHD d where  c.HD_ma=d.HD_ma", luoi_dlieu);
           HienThi_TK("SELECT SUM (HD_tong) from  HoaDon ", dt);
        }

       


        private void locNV(object sender, EventArgs e)
        {
            string manv = nv.SelectedValue.ToString();
            HienThi_TK("Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap, TC_ten,DV_ten,SP_ten,HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma and c.NV_ma ='" + manv + "'", luoi_dlieu);
            // HienThi_TK("Select c.HD_ma,NV_ten, KH_ten, TC_ten,DV_ma,SP_ma, CTHD_soluongsp,CTHD_dgdv,CTHD_dgsp,HD_tong from NhanVien a, KhachHang b, HoaDon c, ChiTietHD d,ThuCung e where a.NV_ma = c.NV_ma and b.KH_ma=c.KH_ma and e.TC_ma=d.TC_ma and c.HD_ma=d.HD_ma", luoi_dlieu);
            HienThi_TK("SELECT SUM (HD_tong) from HoaDon where  NV_ma='"+ manv +"'", dt);
        }

        private void locSP(object sender, EventArgs e)
        {
            string masp = sp.SelectedValue.ToString();
            HienThi_TK("Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap, TC_ten,DV_ten,SP_ten,HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma and d.SP_ma ='" + masp + "'", luoi_dlieu);
            HienThi_TK("SELECT SUM (c.HD_tong) from  HoaDon c, ChiTietHD d where  c.HD_ma=d.HD_ma and d.SP_ma ='" + masp + "'", dt);
        }

        private void locDV(object sender, EventArgs e)
        {
            string madv = dv.SelectedValue.ToString();
            HienThi_TK("Select   c.HD_ma,KH_ten ,NV_ten , HD_ngaylap, TC_ten,DV_ten,SP_ten,HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma and d.DV_ma ='" + madv + "'", luoi_dlieu);
            HienThi_TK("SELECT SUM (c.HD_tong) from  HoaDon c, ChiTietHD d where  c.HD_ma=d.HD_ma and d.DV_ma ='" + madv + "'", dt);
        }

      

        private void ngay_ValueChanged(object sender, EventArgs e)
        {
            string qery = "Select  c.HD_ma,KH_ten ,NV_ten , HD_ngaylap, TC_ten,DV_ten,SP_ten,HD_tong from NhanVien a, KhachHang b, SanPham e, DichVu f ,HoaDon c, ChiTietHD d, ThuCung x where x.TC_ma=d.TC_ma and a.NV_ma=c.NV_ma and b.KH_ma=c.KH_ma and e.SP_ma=d.SP_ma and f.DV_ma=d.DV_ma and  c.HD_ma=d.HD_ma and c.HD_ngaylap = '" + ngay.Value.ToShortDateString() + "'";
            HienThi_TK(qery, luoi_dlieu);
            HienThi_TK("SELECT SUM (c.HD_tong) from  HoaDon c, ChiTietHD d where  c.HD_ma=d.HD_ma and c.HD_ngaylap = '" + ngay.Value.ToShortDateString() + "'", dt);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void resetDT(DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt;         
            DataSet dase = new DataSet();
          
            dg.DataSource = dase;          
           



        }
        private void reset_Click(object sender, EventArgs e)
        {
            ngay.Text = "";
            sp.Text = "";
            nv.Text = "";
            dv.Text = "";
            HienThi_lenluoiDuLieu(luoi_dlieu);
            resetDT(dt);
          


        }

        private void locNgay(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox1.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cappnhatNV cappnhatNV = new cappnhatNV(textBox1.Text);
            this.Hide();
            cappnhatNV.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
