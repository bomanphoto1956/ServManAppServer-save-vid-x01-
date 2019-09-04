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
    public partial class FVentil : Form
    {
        BindingList<SmServ.VentilCL> vl = null;
        public FVentil()
        {
            InitializeComponent();
        }

        private void getVentil()
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.VentilCL[] ventil = cl.getVentilsForCust("11b821a3-3eaf-4ac4-8ccb-dde25fdeb6ff", "024373000", tbPosition.Text, tbIDNR.Text, tbVentiltyp.Text, tbFabrikat.Text, tbAnlaggningnr.Text);               
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ventil;
            vl = new BindingList<SmServ.VentilCL>();
            vl.Add(ventil[0]);
            lblCount.Text = ventil.Length.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getVentil();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmServ.VentilCL v = vl[0];
            SmServ.SmServClient cl = new SmServ.SmServClient();
            v = cl.saveVentil("11b821a3-3eaf-4ac4-8ccb-dde25fdeb6ff", v);

            vl.Clear();
            vl.Add(v);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = vl;
        }


        private void save( Boolean bForce)
        {
            SmServ.VentilCL v = new SmServ.VentilCL();
            SmServ.SmServClient cl = new SmServ.SmServClient();

            

            if (tbVentilID.Text != "")
                v.VentilID = tbVentilID.Text;
            v.Position = tbPosition.Text;
            v.IdNr = tbIDNR.Text;
            v.Ventiltyp = tbVentiltyp.Text;
            v.Fabrikat = tbFabrikat.Text;
            v.Anlaggningsnr = tbAnlaggningnr.Text;
            v.KundID = "058381500";
            v.VentilkatID = 2;
            v.forceSave = bForce;
          

            v = cl.saveVentil("9f1abf95-1fc7-4019-a15b-27d7e542497d", v);

            if (v.ErrMessage != "")
                tbError.Text = v.ErrMessage;
            else
                tbVentilID.Text = v.VentilID;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            save(false);


        }

        private void bForce_Click(object sender, EventArgs e)
        {
            save(true);
        }
    }
}
