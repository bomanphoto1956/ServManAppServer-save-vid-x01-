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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                nxConnection1.Open();
                MessageBox.Show("lyckades");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                nxConnection1.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient s = new SmServ.SmServClient();

//            label1.Text = s.getReparator(textBox1.Text);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient s = new SmServ.SmServClient();
            //SmServLive.SmServClient s = new SmServLive.SmServClient();


            string login = s.login(textBox2.Text, textBox3.Text);

            if (login != "")
            {
                label4.Text = login;
                s.getServHuvForUser(login);
            }
            else
                label4.Text = "Felaktigt användarnamn eller lösenord";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient s = new SmServ.SmServClient();

            SmServ.ReparatorCL r = s.getReparator(textBox4.Text);

            if (r != null)
            {
                label5.Text = r.AnvID;
                label6.Text = r.Reparator;
                label7.Text = r.RepKatID;
                if (r.ErrMessage != "")
                    label7.Text = r.ErrMessage;
            }
            else
                label5.Text = "Användaren finns ej";


            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Reparators");

            SmServ.SmServClient s = new SmServ.SmServClient();

            string ident = "";

            ident = textBox4.Text;
            SmServ.ReparatorCL[] l = s.getReparators(ident);

            dt.Columns.Add("reparator",typeof(string));
            dt.Columns.Add("RepKatID", typeof(string));
            dt.Columns.Add("AnvID", typeof(string));


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = l;



        }
    }
}
