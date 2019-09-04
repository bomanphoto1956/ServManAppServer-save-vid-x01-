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
    public partial class FPictCategories : Form
    {
        public FPictCategories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";

            SmServ.PictCatCL pc = new SmServ.PictCatCL();
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.PictCatCL[] pcl = cl.getPictCategories(ident, Convert.ToInt16(tbStep.Text));

            BindingList<SmServ.PictCatCL> bl = new BindingList<SmServ.PictCatCL>(pcl);

            comboBox1.DataSource = bl;
            comboBox1.DisplayMember = "PictCatName";
            comboBox1.ValueMember = "PictCatID";

        }
    }
}
