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
	public partial class In_DSNV : Form
	{
		public In_DSNV()
		{
			InitializeComponent();
		}

		private void trangChuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			trangchu trangchu = new trangchu();
			trangchu.Show();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.ChamSocThuCungDataSet.NhanVien);
        

		//	this.reportViewer1.RefreshReport();
			this.reportViewer2.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			
		}

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }


}
