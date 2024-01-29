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
    public partial class dangnhap : Form
    {
        public dangnhap()
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


        private void linkLabel_quenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenMK form3 = new quenMK ();
            this.Hide();
            form3.ShowDialog();
            this.Show();
        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu form7 = new trangchu ();
            this.Hide();
            form7.ShowDialog();
            this.Show();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {

            ketnoi();
            
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where NV_email ='" + textBox_emailDN.Text + "' and NV_pwd ='" + textBox_matkhauDN.Text + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0) {
               // string email = textBox_emailDN.Text.ToString();
                if (textBox_emailDN.Text == "admin@gmail.com" && textBox_matkhauDN.Text == "admin") 
                {
                    trangchu trangchu = new trangchu(textBox_emailDN.Text);
                    this.Hide();
                    trangchu.ShowDialog();
            } else {
                    trangchu trangchu = new trangchu(textBox_emailDN.Text);
                    this.Hide();
                    trangchu.ShowDialog();
                }
                }
            else MessageBox.Show("Email hoặc mật khẩu không đúng!!!");
            //trangchu trangchu = new trangchu();
            //this.Hide();
            //trangchu.ShowDialog();
            //this.Show();
            //this.Close();
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {

                ketnoi();

                SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien where NV_email ='" + textBox_emailDN.Text + "' and NV_pwd ='" + textBox_matkhauDN.Text + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // string email = textBox_emailDN.Text.ToString();
                    if (textBox_emailDN.Text == "admin@gmail.com" && textBox_matkhauDN.Text == "admin")
                    {
                        trangchu trangchu = new trangchu(textBox_emailDN.Text);
                        this.Hide();
                        trangchu.ShowDialog();
                    }
                    else
                    {
                        trangchu trangchu = new trangchu(textBox_emailDN.Text);
                        this.Hide();
                        trangchu.ShowDialog();
                    }
                }
                else MessageBox.Show("Email hoặc mật khẩu không đúng!!!");
            }
        }
    }
}
