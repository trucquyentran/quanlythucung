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
	public partial class In_DS_DV : Form
	{
		public In_DS_DV()
		{
			InitializeComponent();
		}

		private void In_DS_DV_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.DichVu' table. You can move, or remove it, as needed.
            this.DichVuTableAdapter.Fill(this.ChamSocThuCungDataSet.DichVu);

			this.reportViewer1.RefreshReport();
		}

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
