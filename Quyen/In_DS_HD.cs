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
	public partial class In_DS_HD : Form
	{
		public In_DS_HD()
		{
			InitializeComponent();
		}

		private void In_DS_HD_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.ChamSocThuCungDataSet1.HoaDon);
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet1.ChiTietHD' table. You can move, or remove it, as needed.
           // this.ChiTietHDTableAdapter.Fill(this.ChamSocThuCungDataSet1.ChiTietHD);
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.KhachHang' table. You can move, or remove it, as needed.
           // this.KhachHangTableAdapter.Fill(this.ChamSocThuCungDataSet.KhachHang);
            // TODO: This line of code loads data into the 'ChamSocThuCungDataSet.DichVu' table. You can move, or remove it, as needed.
            this.DichVuTableAdapter.Fill(this.ChamSocThuCungDataSet.DichVu);
            // TODO: This line of code loads data into the 'QLTCDataSet.HOA_DON' table. You can move, or remove it, as needed.
           // this.HOA_DONTableAdapter.Fill(this.QLTCDataSet.HOA_DON);

			this.reportViewer1.RefreshReport();
		}

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
