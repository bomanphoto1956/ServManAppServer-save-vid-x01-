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
    public partial class FNewTimeReport : Form
    {
        string srAltKey = "fb1cb8e1-f010-4bb0-9dde-be68114f9b62";
        string vartOrdernr = "1705221";
        string ident = "";        
        SmServLive.SmServClient cl = null;
        SmServLive.ReparatorCL[] reps = null;
        SmServLive.SalartCL[] salarts = null;
        bool handleSelection = false;
        int ID = 0;
        public FNewTimeReport()
        {
            InitializeComponent();
            cl = new SmServLive.SmServClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
            label1.Text = cl.getTimeRegVersion(ident, vartOrdernr).ToString();
            showSalart();
            getOpenDates();
            listReparators();
            listTimeTypes();
            listSalart();
            listRepKat();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            handleSelection = true;
        }

        private void login()
        {
            ident = cl.login("KaCh", "pj200as");
        }

        private void showSalart()
        {
            SmServLive.SalartCL[] s1 = cl.getSalart(ident,true);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = s1;

            SmServLive.SalartCL[] s2 = cl.getSalart(ident, false);
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = s2;
        }

        private void getOpenDates()
        {
            //SmServLive.OpenDateCL[] od = cl.getOpenDates(ident, srAltKey );
            SmServLive.OpenDateCL[] od = cl.getOpenDatesSH(ident, vartOrdernr);

            comboBox1.DataSource = od;
            comboBox1.ValueMember = "datum";
            comboBox1.DisplayMember = "datum";

            if (od.Length > 0)
            {
                SmServLive.OpenDateCL c = od[0];
                lblErrMess.Text = c.ErrCode.ToString() + " " + c.ErrMessage;
            }
            
        }


        private void listReparators()
        {
            reps = cl.getReparatorsForServiceHuvud(ident, vartOrdernr);

            SmServLive.ReparatorCL rep = reps[0];            
            comboBox2.DataSource = reps;
            comboBox2.ValueMember = "AnvId";
            comboBox2.DisplayMember = "Reparator";
        }

        private void listTimeTypes()
        {
            SmServLive.TimeTypeCL[] timeTypes = cl.getTimeTypesForOrder(ident, vartOrdernr );

            SmServLive.TimeTypeCL timeType = timeTypes[0];

            comboBox3.DataSource = timeTypes;
            comboBox3.ValueMember = "TimeTypeID";
            comboBox3.DisplayMember = "TimeType";            

        }


        private void listSalart()
        {
            salarts = cl.getSalart(ident, false);
            SmServLive.SalartCL s = salarts[0];

            comboBox4.DataSource = salarts;
            comboBox4.ValueMember = "SalartID";
            comboBox4.DisplayMember = "SalartName";
        }

        private void listRepKat()
        {
            SmServLive.RepKatCL[] repKats = cl.getRepKat(ident);
            SmServLive.RepKatCL r = repKats[0];

            comboBox5.DataSource = repKats;
            comboBox5.ValueMember = "RepKatID";
            comboBox5.DisplayMember = "RepKat";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!handleSelection)
                return;

            string anvID = comboBox2.SelectedValue.ToString();

            SmServLive.RepKatCL rc = cl.getDefaultRepKat(ident, anvID, vartOrdernr);
            
            if (rc.ErrCode == 0)
                comboBox5.SelectedValue = rc.RepKatID;

/*            foreach (SmServLive.ReparatorCL rep in reps)
            {
                if (rep.AnvID == anvID)
                {
                    comboBox5.SelectedValue = rep.RepKatID;
                    break;
                }
            } */
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!handleSelection)
                return;
            int salartID = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            foreach (SmServLive.SalartCL s in salarts)
            {
                if (salartID == s.SalartID)
                    label4.Text = s.Unit;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmServLive.ServRadRepTidCL srt = new SmServLive.ServRadRepTidCL();



            srt.ID = Convert.ToInt32(label5.Text);
            srt.SrAltKey = srAltKey;
            srt.AnvID = comboBox2.SelectedValue.ToString();
            srt.Datum = Convert.ToDateTime(comboBox1.SelectedValue);
            srt.Tid = Convert.ToDecimal(textBox1.Text);
            srt.timeTypeID = Convert.ToInt32(comboBox3.SelectedValue);
            srt.SalartID = Convert.ToInt32(comboBox4.SelectedValue);
            srt.RepKatID = comboBox5.SelectedValue.ToString();

            srt = cl.saveServRadRepTid(ident, srt);

            if (srt.ErrCode != 0)
                label5.Text = srt.ErrCode.ToString() + " " + srt.ErrMessage;
            else
                label5.Text = srt.ID.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SmServLive.ServHuvRepTidCL sht = new SmServLive.ServHuvRepTidCL();

            sht.ID = Convert.ToInt32(label5.Text);
            sht.VartOrdernr = vartOrdernr;
            if (comboBox2.SelectedIndex != -1)
                sht.AnvId = comboBox2.SelectedValue.ToString();
            sht.Datum = Convert.ToDateTime(comboBox1.SelectedValue);
            sht.Tid = Convert.ToDecimal(textBox1.Text);
            sht.TimeTypeID = Convert.ToInt32(comboBox3.SelectedValue);
            sht.SalartID = Convert.ToInt32(comboBox4.SelectedValue);
            if (comboBox5.SelectedIndex != -1)
                sht.RepKatID = comboBox5.SelectedValue.ToString();
            sht = cl.saveServHuvRepTid(ident, sht);

            if (sht.ErrCode != 0)
                label5.Text = sht.ErrCode.ToString() + " " + sht.ErrMessage;
            else
                label5.Text = sht.ID.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            login();
            dataGridView3.AutoGenerateColumns = true;
            SmServLive.ServHuvRepTidCL[] res = null;
            if (tbID.Text != "")
            {
                BindingList<SmServLive.ServHuvRepTidCL> bl = new BindingList<SmServLive.ServHuvRepTidCL>();
                SmServLive.ServHuvRepTidCL r = cl.getServHuvRepTid(ident, Convert.ToInt32(tbID.Text));
                bl.Add(r);
                dataGridView3.DataSource = bl;
            }
            if (tbOrdernr.Text != "" && tbUser.Text != "")
            {
                res = cl.getServHuvRepTidForShAnv(ident, tbOrdernr.Text, tbUser.Text);
                dataGridView3.DataSource = res;
            }
            if (tbOrdernr.Text != "" && tbUser.Text == "")
            {
                res = cl.getServHuvRepTidForSH(ident, tbOrdernr.Text);                
                dataGridView3.DataSource = res;
            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            SmServLive.TimeRep2ProcessCL trr = new SmServLive.TimeRep2ProcessCL();

            trr.VartOrdernr = vartOrdernr;
            trr.Email = "kjbo@melent.se";
            trr = cl.generateTimeReg2Report(ident, trr, true, false);

            BindingList<SmServLive.TimeRep2ProcessCL> bl = new BindingList<SmServLive.TimeRep2ProcessCL>();
            bl.Add(trr);

            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = bl;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SmServLive.TimeRep2ProcessCL trr = new SmServLive.TimeRep2ProcessCL();
            trr = cl.getTimeRep2ReportStatus(ident, vartOrdernr);
            BindingList<SmServLive.TimeRep2ProcessCL> bl = new BindingList<SmServLive.TimeRep2ProcessCL>();
            bl.Add(trr);

            dataGridView4.AutoGenerateColumns = true;
            dataGridView4.DataSource = bl;

        }

    }
}
