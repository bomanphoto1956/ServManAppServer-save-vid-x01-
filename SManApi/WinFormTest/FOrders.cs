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
    public partial class FOrders : Form
    {
        public FOrders()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            string vartOrdernr = "";
            if (dataGridView1.Rows[row].Cells[6].Value != null)            
                vartOrdernr = dataGridView1.Rows[row].Cells[8].Value.ToString();
                      
            SmServ.SmServClient sc = new SmServ.SmServClient();
            SmServ.ServiceRadListCL[] sRader = sc.getAllServRad(tbIdentity.Text, vartOrdernr);

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = sRader;      
      


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmServLive.SmServClient sc = new SmServLive.SmServClient();

            SmServLive.ServiceHuvudCL[] head = sc.getServHuvForUser(tbIdentity.Text);
            

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = head;

            SmServ.SmServClient sc2 = new SmServ.SmServClient();

            SmServ.VentilKategoriCL[] categories = sc2.getVentilKategorier(tbIdentity.Text);

            dataGridView5.AutoGenerateColumns = true;
            dataGridView5.DataSource = categories;

            SmServ.FabrikatCL[] f = sc2.getFabrikat(tbIdentity.Text);
            dataGridView6.AutoGenerateColumns = true;
            dataGridView6.DataSource = f;

            SmServ.DnCL[] d = sc2.getDn(tbIdentity.Text);
            dataGridView7.AutoGenerateColumns = true;
            dataGridView7.DataSource = d;

            SmServ.PnCL[] p = sc2.getPn(tbIdentity.Text);
            dataGridView8.AutoGenerateColumns = true;
            dataGridView8.DataSource = p;

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            string vart_ordernr = "";
            int radnr = 0;

            if (dataGridView2.Rows[row].Cells[6].Value != null)
                vart_ordernr = dataGridView2.Rows[row].Cells[10].Value.ToString();
            if (dataGridView2.Rows[row].Cells[5].Value != null)
                radnr = Convert.ToInt32(dataGridView2.Rows[row].Cells[9].Value);


            SmServLive.SmServClient sc = new SmServLive.SmServClient();
            SmServLive.ServiceRadCL rd = sc.getServRad(tbIdentity.Text, vart_ordernr, radnr);

            BindingList<SmServLive.ServiceRadCL> l = new BindingList<SmServLive.ServiceRadCL>();
            l.Add(rd);


            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.DataSource = l;

            




        }

        private void dataGridView3_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string ventilID = "";

            if (dataGridView3.Rows[row].Cells[24].Value != null)
                ventilID = dataGridView3.Rows[row].Cells[24].Value.ToString();
            SmServ.SmServClient sc = new SmServ.SmServClient();

            SmServ.VentilCL v = sc.getVentil(tbIdentity.Text, ventilID);

            BindingList<SmServ.VentilCL> l = new BindingList<SmServ.VentilCL>();

            l.Add(v);

            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = l;
        }
    }
}
