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
    public partial class Form4 : Form
    {
        SqlConnection conn;
        public Form4()
        {
            InitializeComponent();
        }
        private void button_uploadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Chọn hình ảnh (*.jeg; *jpg; *.tif; *jfif) | *.jpeg; *jpg; *.tif; *jfif";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox_hinhanh.Image = Image.FromFile(op.FileName);

            }
        }

        public void ketnoi()
        {
            String ketnoi = "Server= DESKTOP-61FTO1U; Database= ThuCung;integrated security=true";
            conn = new SqlConnection(ketnoi);
            conn.Open();

        }

        public void HienThi_lenluoiDuLieu(DataGridView dg)
        {
            ketnoi();
            string query = "SELECT * FROM KhachHang";
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_KhachHang");
            dg.DataSource = dase;
            dg.DataMember = "DS_KhachHang";

        }



        public void HienThi_TK(string query, DataGridView dg)
        {
            ketnoi();
            SqlDataAdapter dt = new SqlDataAdapter(query, conn);
            DataSet dase = new DataSet();
            dt.Fill(dase, "DS_KhachHang");
            dg.DataSource = dase;
            dg.DataMember = "DS_KhachHang";
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

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu form7 = new trangchu();
            form7.Show();
        }


        private void button_Profile4_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            ketnoi();

        }
    }
    
}
