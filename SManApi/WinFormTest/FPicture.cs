using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace WinFormTest
{
    public partial class FPicture : Form
    {
        public FPicture()
        {
            InitializeComponent();
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Service1.Service1Client s1 = new Service1.Service1Client();

            PictLoad.PictLoadClient pc = new PictLoad.PictLoadClient();
            

            //MemoryStream s = new MemoryStream();//

            //pictureBox1.Image.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);


            //Image image = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert2.jpg");

            //using (MemoryStream s = new MemoryStream())
            //{
            //    image.Save(s, ImageFormat.Jpeg);
            //    PictLoad.UploadedFile f = pc.Upload(s);
            //    string s2 = f.FileName;                
            //}


            

            






            //ServiceReference3.PictLoadClient pc = new ServiceReference3.PictLoadClient();
            
            

            //pictureBox1.Image.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);

            //pc.Upload(s);

            //string sIdent = "9f5add26-bf98-4188-926d-8871a4f41d36";
            //string vartOrdernr = "952";
            //int radnr = 2;

            //SmServ.SmServClient cl = new SmServ.SmServClient();
            //SmServ.PictureCL p = new SmServ.PictureCL();

            //Image i = pictureBox1.Image;

            //byte[] b = imageToByteArray(i);

            //p.VartOrdernr = vartOrdernr;
            //p.Radnr = radnr;
            //p.Bild = b;
            //p.BildNr = 0;

            //cl.savePicture(sIdent, p);


                
        }
    }
}
