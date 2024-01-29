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
	public partial class In_DS_TC : Form
	{
		public In_DS_TC()
		{
			InitializeComponent();
		}

		private void In_DS_TC_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.ThuCung' table. You can move, or remove it, as needed.
            this.ThuCungTableAdapter.Fill(this.ChamSocThuCungDataSet.ThuCung);
          

			this.reportViewer1.RefreshReport();
		}

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
