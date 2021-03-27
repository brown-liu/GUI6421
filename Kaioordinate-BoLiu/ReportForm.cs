using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate_BoLiu
{
    public partial class ReportForm : Form
    {

        private DataModule _dataModule;
        private DataRow[] reportToPrint;
        private int pagesAmountToPrint, currentPage;

        public ReportForm(DataModule dataModule, MainForm mainForm)
        {
            _dataModule = dataModule;

            InitializeComponent();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void kaiDownBtn_Click(object sender, EventArgs e)
        {
            reportToPrint = _dataModule.EventTable.Select();
            pagesAmountToPrint = reportToPrint.Length;
            currentPage = 0;
            printPreviewDialogPrintReport.Show();
        }



        private void printDocumentPrintReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int lineSoFarHeading = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 12, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 12, FontStyle.Bold);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);


            Brush brush = new SolidBrush(Color.Black);

            int leftmargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;


            var item = reportToPrint[currentPage];
                 DataRow location;
            string locationName;
            string locationAddress;

            if (string.IsNullOrEmpty(item["locationId"].ToString()))
            {
                locationName = "n/a";
                locationAddress = "n/a";
            }
            else
            {
                try
                {
                    location = _dataModule.LocationTable.Rows.Find(item["locationId"]);
                    locationName = location["LocationName"].ToString();
                    locationAddress = location["Address"].ToString();
                }
                catch (MissingPrimaryKeyException ex)
                {
                    Console.WriteLine(ex.ToString());
                    locationName = "n/a";
                    locationAddress = "n/a";
                }

            }

            g.DrawString($"Event ID: {item["eventID"]}",
                headingFont,
                brush, leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));

            lineSoFarHeading++;
            lineSoFarHeading++;
            lineSoFarHeading++;

            g.DrawString($"Event Name: {item["eventName"]}",
                headingFont,
                brush, leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));

            lineSoFarHeading++;
            lineSoFarHeading++;

            g.DrawString($"Date: {item["eventDate"]}",
                headingFont,
                brush,
                leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));
            lineSoFarHeading++;
            lineSoFarHeading++;

            g.DrawString($"Location: {locationName}",
                headingFont,
                brush,
                leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));
            lineSoFarHeading++;
            lineSoFarHeading++;

            g.DrawString($"Address: {locationAddress}",
                headingFont,
                brush,
                leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));

            lineSoFarHeading++;
            lineSoFarHeading++;
            lineSoFarHeading++;

            g.DrawString("Attendees:",
                headingFont,
                brush,
                leftmargin + headingLeftMargin,
                topMargin + (lineSoFarHeading * textFont.Height));

            lineSoFarHeading++;
            lineSoFarHeading++;
            lineSoFarHeading++;

            var register = _dataModule.EventRegisterTable.Select($"eventId={item["eventID"]}");

            if (register.Length == 0)
            {
                g.DrawString("No attendees at the moment",
                                  textFont,
                                  brush,
                                  leftmargin + headingLeftMargin,
                                  topMargin + (lineSoFarHeading * textFont.Height));

                lineSoFarHeading++;
                lineSoFarHeading++;
            }
            else
            {
                g.DrawString("First Name     Last Name               Phone No.          Email",
               headingFont,
               brush,
               leftmargin + headingLeftMargin,
               topMargin + (lineSoFarHeading * textFont.Height));

                lineSoFarHeading++;
                lineSoFarHeading++;
                foreach (var record in register)
                {

                    var whanua = _dataModule.WhanauTable.Rows.Find(record["WhanauId"]);

                    g.DrawString($"{whanua["FirstName"]}     {whanua["LastName"]}               {whanua["Phone"]}          {whanua["Email"]}",
                     textFontCenter,
                     brush,
                     leftmargin + headingLeftMargin,
                     topMargin + (lineSoFarHeading * textFont.Height));

                    lineSoFarHeading++;
                }

            }
            currentPage++;
            e.HasMorePages = !(pagesAmountToPrint == currentPage);
        }
    }
}
