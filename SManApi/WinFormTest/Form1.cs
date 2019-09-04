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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  ServiceReference1.Service1Client s1 = new ServiceReference1.Service1Client();

           // label1.Text = s1.GetData(Convert.ToInt32(textBox1.Text));
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FServiceHuv sh = new FServiceHuv();

            sh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FOrders fo = new FOrders();

            fo.Show();
        }

        private void bVentil_Click(object sender, EventArgs e)
        {
            FVentil fv = new FVentil();

            fv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FUpdateServrad fs = new FUpdateServrad();

            fs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FReservdel fr = new FReservdel();

            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FTidRed ft = new FTidRed();

            ft.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FReparators fr = new FReparators();

            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FPicture fp = new FPicture();

            fp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FPictCategories fp = new FPictCategories();

            fp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string ident = "745bab7c-3660-49fd-bde0-7b3368d608e8";
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.ServiceRadListCL[] sr = cl.getAllServRad(ident, "16218");


            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string ident = "745bab7c-3660-49fd-bde0-7b3368d608e8";
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.ServiceRadListCL[] sr = cl.getAllServRad(ident, "16218");

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Uppdatera servicerad med värden från ventil
            string ident = "75c6e965-4fde-4c09-a2bc-8b612099efdb";
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.VentilCL v = cl.getVentil(ident, "b7e9bff7-b2bc-431f-9602-95b833972a5f");
            v.Position = "Test46";
            cl.saveVentil(ident, v);

            SmServ.ServiceRadCL sr = cl.getServRad(ident, "16218",2);
            sr.VentilID = "b7e9bff7-b2bc-431f-9602-95b833972a5f";
            cl.saveServRad(ident,sr);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            FAllTimes fa = new FAllTimes();

            fa.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();

            string ident = "0428fb37-6840-4be5-93bf-fa9724b3e1c7";
            SmServ.ServiceRadCL cr = cl.getServRad(ident, "16239", 105);

            cr.OvrKomment = "Detta är en övrig kommentar";
            cr.Attention = 1;
            cl.saveServRad(ident, cr);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();

            SmServ.ServRadRepTidCL[] sr = cl.getServRadRepTidForSR("b70b76f1-b4fe-4fe3-9a89-5e3ac94de270", "f4af917a-59bc-4bd2-ac79-f81f3a2d72d8");                

        }

        private void button17_Click(object sender, EventArgs e)
        {
            FNewTimeReport tr = new FNewTimeReport();

            tr.Show();
        }
    }
}
