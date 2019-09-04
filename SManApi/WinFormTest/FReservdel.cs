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
    public partial class FReservdel : Form
    {
        SmServ.SmServClient cl = null;
        SmServ.ReservdelCL res = null;
        public FReservdel()
        {
            InitializeComponent();
            cl = new SmServ.SmServClient();
        }

        private void bReservdel_Click(object sender, EventArgs e)
        {
            

//            SmServ.ArtikelCL[] art = cl.getArtList("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", "3", "G");

            //SmServ.ArtikelCL a = cl.getArtikel("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", "33363196");

            //BindingList<SmServ.ArtikelCL> art = new BindingList<SmServ.ArtikelCL>();

            //SmServ.ReservdelCL[] res = cl.getReservdelsForServiceRad("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", "3", 1);

            res = cl.getReservdel("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", "3", 1, 1);

            BindingList<SmServ.ReservdelCL> bl = new BindingList<SmServ.ReservdelCL>();

            bl.Add(res);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (res != null)
            {
                res = cl.saveReservdel("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", res);
                BindingList<SmServ.ReservdelCL> bl = new BindingList<SmServ.ReservdelCL>();

                bl.Add(res);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = bl;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmServ.ReservdelCL res = new SmServ.ReservdelCL();
            res.VartOrdernr = "3";
            res.Radnr = 1;
            res.ReservNr = 0;
            res.Artnr = "42";
            res.ArtNamn = "Test";
            res = cl.saveReservdel("ee45f015-9c4d-466f-942c-7e51eb4ab9e7", res);
            BindingList<SmServ.ReservdelCL> bl = new BindingList<SmServ.ReservdelCL>();

            bl.Add(res);

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bl;


        }
    }
}
