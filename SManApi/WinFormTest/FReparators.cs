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
    public partial class FReparators : Form
    {
        public FReparators()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ident = "ee45f015-9c4d-466f-942c-7e51eb4ab9e7";

            SmServ.SmServClient cl = new SmServ.SmServClient();

            dataGridView1.DataSource = cl.getReparatorsForServiceHuvud(ident, "14162");
        }
    }
}
