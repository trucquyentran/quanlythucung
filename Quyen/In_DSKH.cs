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
	public partial class In_DSKH : Form
	{
		public In_DSKH()
		{
			InitializeComponent();
		}

		private void In_DSKH_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.ChamSocThuCungDataSet.KhachHang);
          

			this.reportViewer1.RefreshReport();
		}

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
