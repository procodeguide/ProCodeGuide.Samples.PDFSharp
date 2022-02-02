using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCodeGuide.Samples.PDFSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            //Create PDF Document
            PdfDocument document = new PdfDocument();
            
            //You will have to add Page in PDF Document
            PdfPage page = document.AddPage();
            
            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics gfx = XGraphics.FromPdfPage(page);
            
            //For Test you will have to define font to be used
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            //Finally use XGraphics & font object to draw text in PDF Page
            gfx.DrawString("My First PDF Document", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            //Specify file name of the PDF file
            string filename = "FirstPDFDocument.pdf";

            //Save PDF File
            document.Save(filename);

            //Load PDF File for viewing
            Process.Start(filename);
        }
    }
}
