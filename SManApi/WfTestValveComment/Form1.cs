using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfTestValveComment
{
    public partial class Form1 : Form
    {
        
        SmServ.SmServClient smServ = null;
        public Form1()
        {
            InitializeComponent();
            smServ = new SmServ.SmServClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string result = smServ.login(textBox1.Text, textBox2.Text);
            lblIdent.Text = result;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ident = "af9844be-0881-4a4a-a512-7cf0d2b3b0b8";
            SmServ.ServiceRadCL srad = smServ.getServRad(ident,"11005",6);

            srad.OvrKomment = "Testas nästa gång";
            srad.hosKund = 0;
            srad.paVerkstad = 1;
            smServ.saveServRad(ident, srad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ident = "af9844be-0881-4a4a-a512-7cf0d2b3b0b8";
            SmServ.ReservdelCL r = smServ.getReservdel(ident, "10003",2,2);

            if (r.ErrCode != 0)
            {
                textBox3.Text = r.ErrMessage;
                return;
            }
            textBox3.Text = "Reservdel hämtad";
            string errMess = smServ.deleteReservdel(ident, r);
        }
    }
}
