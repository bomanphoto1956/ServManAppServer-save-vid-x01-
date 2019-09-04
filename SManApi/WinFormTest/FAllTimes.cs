using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class FAllTimes : Form
    {
        public FAllTimes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ident = "0428fb37-6840-4be5-93bf-fa9724b3e1c7";

            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.RepTidListCL[] l = cl.getAllTimeForOrder(ident, "16275");
            
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = l;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ident = "0428fb37-6840-4be5-93bf-fa9724b3e1c7";

            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.TimeTypeCL[] l = cl.getTimeTypes(ident, false, false);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = l;

        }
    }
}
