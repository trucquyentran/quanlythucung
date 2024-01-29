using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quyen
{
    public partial class chu : Form
    {
        public chu()
        {
            InitializeComponent();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangchu trangchu = new trangchu();
            this.Hide();
            trangchu.ShowDialog();
            this.Show();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap dangnhap = new dangnhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
