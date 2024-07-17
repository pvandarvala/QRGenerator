using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QRCodeUtility
{
    public partial class frmGenerateQRcode : Form
    {
        public frmGenerateQRcode()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // string data = "https://www.12jyotirlingas.com/"; // Data to encode in the QR code
            string data =txtLink.Text.Trim();

            int qrCodeSize = 20;

            // Create a QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);

            // Create a QRCode
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert the QRCode to a bitmap
            Bitmap qrCodeImage = qrCode.GetGraphic(qrCodeSize); // 20 is the pixel size of the QR code

            // Save or display the QR code image as needed
            qrCodeImage.Save("QRCode.png");

            //pbQrCode.Size = new Size(200, 200); // Set the fixed size
            //pbQrCode.SizeMode = PictureBoxSizeMode.Normal;
            //pbQrCode.Image = Image.FromFile("QRCode.png");
           

            Console.WriteLine("QR code generated!");
        }
        // Overlay an image onto another image (used to add a logo to the QR code)
        static Bitmap OverlayImage(Bitmap qrCode, Bitmap logo)
        {
            using (Graphics g = Graphics.FromImage(qrCode))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(logo, new Rectangle(qrCode.Width / 3, qrCode.Height / 3, qrCode.Width / 3, qrCode.Height / 3));
            }
            return qrCode;
        }
    }
}
