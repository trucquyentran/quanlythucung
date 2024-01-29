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
    public partial class quenMK : Form
    {
        public quenMK()
        {
            InitializeComponent();
        }

        private void button_trangchu3_Click(object sender, EventArgs e)
        {
            trangchu form7 = new trangchu();
            form7.Show();
        }

        private void button_Profile_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

		private void label_datMK_Click(object sender, EventArgs e)
		{

		}
	}
 }

