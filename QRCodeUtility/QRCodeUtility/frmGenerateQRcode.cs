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
            string data =txtLink.Text.Trim();

            int qrCodeSize = 20;

            // Create a QRCodeGenerator
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);

            // Create a QRCode
            QRCode qrCode = new QRCode(qrCodeData);

            // Convert the QRCode to a bitmap
            Bitmap qrCodeImage = qrCode.GetGraphic(qrCodeSize); // 20 is the pixel size of the QR code


            // Load the overlay image (logo)
           // Bitmap logo = new Bitmap("logo.png"); // Replace with the path to your logo

            // Overlay the logo onto the QR code
           //Bitmap qrCodeWithLogo = OverlayImage(qrCodeImage, logo);

            pbQrCode.SizeMode = PictureBoxSizeMode.Zoom; // Ensure the QR code fits within the PictureBox
            pbQrCode.Image = qrCodeImage;

            

            // Prompt the user to choose a location to save the QR code
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code";
                saveFileDialog.FileName = "QRCode.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the QR code image to the chosen location
                    qrCodeImage.Save(saveFileDialog.FileName);
                    MessageBox.Show("QR code saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }      


            Console.WriteLine("QR code generated!");
        }
        // Overlay an image onto another image (used to add a logo to the QR code)
        static Bitmap OverlayImage(Bitmap qrCode, Bitmap logo)
        {
            // Calculate the logo size and position
            int logoSize = qrCode.Width / 5; // Adjust the size of the logo
            int logoPosition = (qrCode.Width - logoSize) / 2;

            using (Graphics g = Graphics.FromImage(qrCode))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(logo, new Rectangle(logoPosition, logoPosition, logoSize, logoSize));
            }
            return qrCode;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtLink.Text = string.Empty;
            pbQrCode.Image = null;
        }
    }
}
