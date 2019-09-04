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
    public partial class FUpdateServrad : Form
    {
        SmServ.SmServClient smServ = null;
        string ident = "";
        int iCurrRow = -1;
        int iCurrServRow = -1;
        string vartOrdernr = "";
        int radnr = 0;
        SmServ.ServiceRadCL sr;
        public FUpdateServrad()
        {
            InitializeComponent();
            smServ = new SmServ.SmServClient();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            ident = smServ.login(tBAnvID.Text, tbPwd.Text);

            if (ident != "")
            {
                lblIdent.Text = ident;
                SmServ.ServiceHuvudCL[] sh = smServ.getServHuvForUser(ident);
                dgvServHuv.AutoGenerateColumns = true;
                dgvServHuv.DataSource = sh;
            }
            else
                lblIdent.Text = "Login failed";

            

           
        }

        private void dgvServHuv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (iCurrRow != row)
            {
                vartOrdernr = dgvServHuv.Rows[row].Cells[8].Value.ToString();
                SmServ.ServiceRadListCL[] sr = smServ.getAllServRad(ident, vartOrdernr);

                dgvServRow.AutoGenerateColumns = true;
                dgvServRow.DataSource = sr;
                iCurrRow = row;
            }

        }

        private void dgvServRow_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (iCurrServRow != row)
            {
                radnr = Convert.ToInt32(dgvServRow.Rows[row].Cells[10].Value);

                sr = smServ.getServRad(ident, vartOrdernr, radnr);

                BindingList<SmServ.ServiceRadCL> srl = new BindingList<SmServ.ServiceRadCL>();

                srl.Add(sr);

                dgvServRowEdit.AutoGenerateColumns = true;
                dgvServRowEdit.DataSource = srl;                
                if (dgvServRowEdit.Rows.Count > 0)
                    visaDetaljer(sr);
                iCurrServRow = row; 
            }
        }

        private void visaDetaljer(SmServ.ServiceRadCL sr)
        {
            tbAnmarkning.Text = sr.Anmarkning;
            tbKontroll.Text = sr.Kontroll;
            tbArbete.Text = sr.Arbete;
            tbReservdelar.Text = sr.Reservdelar;
            return;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            sr.Anmarkning = tbAnmarkning.Text;
            sr.Kontroll = tbKontroll.Text;
            sr.Arbete = tbArbete.Text;
            sr.Reservdelar = tbReservdelar.Text;

            sr = smServ.saveServRad( ident, sr);

            BindingList<SmServ.ServiceRadCL> srl = new BindingList<SmServ.ServiceRadCL>();

            srl.Add(sr);

            dgvServRowEdit.AutoGenerateColumns = true;
            dgvServRowEdit.DataSource = srl;
            if (dgvServRowEdit.Rows.Count > 0)
               visaDetaljer(sr);


        }

        private void bNew_Click(object sender, EventArgs e)
        {
            string ventilID = "{2D4D3633-35AA-4812-990F-98A6BDE35193}";

            SmServ.ServiceRadCL sr = new SmServ.ServiceRadCL();
            sr.VentilID = ventilID;
            sr.VartOrdernr = vartOrdernr;
            sr = smServ.saveServRad(ident, sr);

            BindingList<SmServ.ServiceRadCL> bl = new BindingList<SmServ.ServiceRadCL>();

            bl.Add(sr);
            dgvServRowEdit.DataSource = bl;
            
        }






    }
}
