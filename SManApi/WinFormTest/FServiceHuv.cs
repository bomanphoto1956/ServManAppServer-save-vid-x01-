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
    public partial class FServiceHuv : Form
    {
        string vart_ordernr = "";
        public FServiceHuv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient c = new SmServ.SmServClient();

            dataGridView1.AutoGenerateColumns = true;
            if (textBox2.Text == "")
            {

                SmServ.ServiceHuvudCL[] sh = c.getServHuvForUser(textBox1.Text);
                dataGridView1.DataSource = sh;
            }
            else
            {
                SmServ.ServiceHuvudCL sh2 = c.getServHuv(textBox1.Text, textBox2.Text);

                BindingList<SmServ.ServiceHuvudCL> bl = new BindingList<SmServ.ServiceHuvudCL>();

                bl.Add(sh2);
                dataGridView1.DataSource = bl;

                label3.Text = sh2.KundNamn;

            }



            
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            //if (row >= 0 )
            //{
            //    vart_ordernr = dataGridView1.Rows[row].Cells[8].Value.ToString();
            //    SmServ.SmServClient c = new SmServ.SmServClient();

            //    SmServ.ServiceRadListCL[] sr = c.getAllServRad(textBox1.Text, vart_ordernr);

            //    dataGridView2.AutoGenerateColumns = true;
            //    dataGridView2.DataSource = sr;
            //}
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SmServ.SmServClient c = new SmServ.SmServClient();

            int radnr = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[9].Value);

            SmServ.ServiceRadCL sr = c.getServRad(textBox1.Text, vart_ordernr, radnr);


        }
    }
}
