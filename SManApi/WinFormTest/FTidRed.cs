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
    public partial class FTidRed : Form
    {
        
        SmServ.SmServClient cl = null;
        SmServ.ServRadRepTidCL rt = null;
        public FTidRed()
        {
            InitializeComponent();
            cl = new SmServ.SmServClient();
            rt = new SmServ.ServRadRepTidCL();
            getDates();
        }

        private void getDates()
        {
            string ident = "54286ed4-1481-4a80-8567-ec71a7d854ea";
            SmServ.OpenDateCL[] l = cl.getOpenDates(ident, "{7C267ECC-62CF-4DD4-AF36-8D667D6C68F2}");

            cbDates.DataSource = l;

            cbDates.DisplayMember = "Datum";
            cbDates.ValueMember = "Datum";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ident = "54286ed4-1481-4a80-8567-ec71a7d854ea";

            //SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServLive.SmServClient cl = new SmServLive.SmServClient();

            SmServLive.OpenDateCL[] l = cl.getOpenDates(ident, "{7C267ECC-62CF-4DD4-AF36-8D667D6C68F2}");

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.DataSource = l;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ident = "54286ed4-1481-4a80-8567-ec71a7d854ea";

            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.ServiceRadCL sr = cl.getServRad(ident,"951147",3);

            BindingList<SmServ.ServiceRadCL> srr = new BindingList<SmServ.ServiceRadCL>();

            srr.Add(sr);

            dataGridView1.AutoGenerateColumns = true;

            dataGridView1.DataSource = srr;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ident = "54286ed4-1481-4a80-8567-ec71a7d854ea";
            rt = new SmServ.ServRadRepTidCL();

            if (tbID.Text == "")
                rt.ID = 0;
            else
                rt.ID = Convert.ToInt32(tbID.Text);
            rt.SrAltKey = tbAltKey.Text;
            rt.AnvID = tbAnvID.Text;
            rt.Datum = Convert.ToDateTime(cbDates.SelectedValue);
            rt.Tid = Convert.ToDecimal(tbTid.Text);

            rt = cl.saveServRadRepTid(ident, rt);

            if (rt.ErrMessage != "")
                lblError.Text = rt.ErrMessage;
            else
            {
                tbID.Text = rt.ID.ToString();
                tbAltKey.Text = rt.SrAltKey;
                tbAnvID.Text = rt.AnvID;
                cbDates.SelectedValue = rt.Datum.ToShortDateString();
                tbTid.Text = rt.Tid.ToString();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 1)
                tbAltKey.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ident = "54286ed4-1481-4a80-8567-ec71a7d854ea";
            SmServ.SmServClient cl = new SmServ.SmServClient();

            Decimal ldHours = cl.SumHoursForServRad(ident, tbAltKey.Text, "");
            textBox1.Text = ldHours.ToString();
            ldHours = cl.SumHoursForServRad(ident, tbAltKey.Text, tbAnvID.Text);
            textBox2.Text = ldHours.ToString();
        }


    }
}
