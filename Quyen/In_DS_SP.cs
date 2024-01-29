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
	public partial class In_DS_SP : Form
	{
		public In_DS_SP()
		{
			InitializeComponent();
		}

		private void In_DS_SP_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.SanPham' table. You can move, or remove it, as needed.
            this.SanPhamTableAdapter.Fill(this.ChamSocThuCungDataSet.SanPham);
            // TODO: This line of code loads data into the 'QLTCDataSet.HOA_DON' table. You can move, or remove it, as needed.
            //  this.HOA_DONTableAdapter.Fill(this.QLTCDataSet.HOA_DON);
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.SanPham' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
		{

		}

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
