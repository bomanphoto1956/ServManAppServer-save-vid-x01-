using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI.WebControls;
using System.Net;

namespace WUploadTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                fillLv();
        }

        private void fillLv()
        {
            SmServ.PictCatCL pc = new SmServ.PictCatCL();
            SmServ.SmServClient cl = new SmServ.SmServClient();
            string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";

            DropDownList1.DataSource = cl.getPictCategories(ident,1);
            DropDownList1.DataTextField = "PictCatName";
            DropDownList1.DataValueField = "PictCatID";
            DropDownList1.DataBind();
        }


        protected void getImage()
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();
            SmServ.PictureCL pictureCL = new SmServ.PictureCL();

             string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";
             string vart_ordernr = "630415";                    
             int radnr = 1;
             int BildNr = 16;

             pictureCL = cl.getPicture(ident, vart_ordernr, radnr, BildNr);             

             Label2.Text = pictureCL.PictIdent;

             if (Label2.Text.Substring(0, 2) == "-1")
                 return;

             Stream s = cl.downLoadPict(pictureCL.PictIdent);
             using (var fileStream = File.Create(@"H:\Git\ServManAppServer\SManApi\WUploadTest\Download\test1.jpg"))             
             {
                // s.Seek(0, SeekOrigin.Begin);                 
                 s.CopyTo(fileStream);
             }
             Label2.Text = pictureCL.Description;
             Label4.Text = pictureCL.pictSize.ToString() + " " + pictureCL.pictType;
             Label5.Text = pictureCL.PictCatID.ToString();
        }


        protected void saveImage()
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();
            SmServ.PictureCL pictureCL = new SmServ.PictureCL();
           // SmServLive.SmServClient cl = new SmServLive.SmServClient();
            //SmServLive.PictureCL pictureCL = new SmServLive.PictureCL();


            byte[] bytearray = null;
            string name = "";
            //throw new NotImplementedException();
            if (FileUpload1.HasFile)
            {
                name = FileUpload1.FileName;
                Stream stream = FileUpload1.FileContent;
                stream.Seek(0, SeekOrigin.Begin);
                bytearray = new byte[stream.Length];
                int count = 0;
                while (count < stream.Length)
                {
                    bytearray[count++] = Convert.ToByte(stream.ReadByte());
                }
                stream.Position = 0;
                string PictIdent = cl.uploadPict(stream);                                
                if (PictIdent.Substring(0,2) != "-1")
                {
                    string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";
                    string vart_ordernr = "630415";                    
                    pictureCL.BildNr = 0;
                    pictureCL.VartOrdernr = vart_ordernr;
                    pictureCL.Radnr = 1;
                    pictureCL.PictIdent = PictIdent;
                    pictureCL.Description = "Nu testar vi på nytt igen";
                    pictureCL.PictCatID = Convert.ToInt32(DropDownList1.SelectedValue);


                    string s = "";
                    pictureCL = cl.savePicture(ident, pictureCL);
                    if (pictureCL.ErrCode != 0)
                        Label1.Text = pictureCL.ErrMessage;
                    else
                    {
                        Label1.Text = "Bild sparad i databas";
                        Label4.Text = pictureCL.pictSize.ToString() + " " + pictureCL.pictType; 

                    }
                }
                cl.Close();
            }

            
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            saveImage();

            
            
            

            //string baseAddress = "http://" + Environment.MachineName + "/Service/FileUpload/";
            //string baseAddress = "http://localhost/SmanLoadAPI/SvcImageLoad.svc/FileUpload/";
            //HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(baseAddress);          
            //request.Method = "POST";
            //request.ContentType = "text/plain";
            //Stream serverStream  = request.GetRequestStream();
            //serverStream.Write(bytearray, 0, bytearray.Length);
            //serverStream.Close();
            //using ( HttpWebResponse response = request.GetResponse() as HttpWebResponse )   
            //{
            //    int statusCode =(int) response.StatusCode;                              
            //    StreamReader reader = new StreamReader( response.GetResponseStream() );       

            //}
 
        
    
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label1.Text = "Knapp tryckt";

            saveImage();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            getImage();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();
            SmServ.PictureCL pictureCL = new SmServ.PictureCL();

            string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";
            string vart_ordernr = "630415";

            pictureCL.VartOrdernr = vart_ordernr;
            pictureCL.Radnr = 1;
            pictureCL.BildNr = 8;

            pictureCL = cl.deletePicture(ident, pictureCL);

            if (pictureCL.ErrMessage == "")
                Label2.Text = "Radering gick bra";
            else
                Label2.Text = pictureCL.ErrMessage;



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SmServ.SmServClient cl = new SmServ.SmServClient();
            SmServ.PictureCL pictureCL = new SmServ.PictureCL();

            string ident = "9f1abf95-1fc7-4019-a15b-27d7e542497d";
            string vart_ordernr = "630415";

            pictureCL.VartOrdernr = vart_ordernr;
            pictureCL.Radnr = 1;

            SmServ.PictureCL[] plist = cl.getPicturesForServiceRad(ident, vart_ordernr, 1);


            foreach (SmServ.PictureCL p in plist)
            {
                if (p.ErrMessage != "")
                {
                    Label3.Text = p.ErrMessage;
                }
                else
                {
                    if (Label3.Text == "")
                        Label3.Text = p.VartOrdernr + ", ";
                    Label3.Text += p.BildNr.ToString() + ", ";
                }
            }



        }
    }
}