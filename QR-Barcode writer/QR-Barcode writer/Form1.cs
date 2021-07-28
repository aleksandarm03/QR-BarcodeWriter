using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OnBarcode.Barcode;
using System.Drawing.Imaging;

namespace QR_writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void GenerateBacode(string podatak )
        {
            Linear barcode = new Linear();
            barcode.Type = BarcodeType.CODE11;
            barcode.Data = podatak;
            pictureBoxBarCode.Image = barcode.drawBarcode();
            
        }
        private void GenerateQrcode(string podatak)
        {
            QRCode qrcode = new QRCode();
            qrcode.Data = podatak;
            qrcode.DataMode = QRCodeDataMode.Byte;
            qrcode.UOM = UnitOfMeasure.PIXEL;
            qrcode.X = 3;
            qrcode.LeftMargin = 0;
            qrcode.RightMargin = 0;
            qrcode.TopMargin = 0;
            qrcode.BottomMargin = 0;
            qrcode.Resolution = 72;
            qrcode.Rotate = Rotate.Rotate0;
            qrcode.ImageFormat = ImageFormat.Gif;
            pictureBoxQR.Image = qrcode.drawBarcode();
        }

   
        private void Generate(object sender, EventArgs e)
        {
            GenerateBacode(textBoxQrText.Text);
            GenerateQrcode(textBoxQrText.Text);
            textBoxQrText.Text = "";
        }
    }
}
