using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizTalkLibrary.Objects;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;
using System.Drawing;

namespace BizTalkLibrary.Classes
{
    public class Create_PDF
    {
        public string SubjectPrefix { get; set; }
        public Create_PDF(OrderHeader order)
        {
            Global.CheckDirectory(Constants.PDF_Path);
            SubjectPrefix = pdfEmail(order);
        }

        private string pdfEmail(OrderHeader order)
        {

            int rowCount = 0, pageLineCount = 7, lineStartPositionY = 452;
            int offsetX = 30, boxPadding = 5;

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Order Confirmation:" + order.orderID;

            XFont fontBold = new XFont("Arial", 9, XFontStyle.Bold);

            XGraphics gfx = null;

            XFont font = null;
            XTextFormatter tf = null;
            XRect rect;

            rowCount = order.Lines.Count;

            string subjectPrefix = "";
            int itemLineHeight = 0, lineCounter = 0, pageLineCounter = 0;

            bool firstPage = true;
            foreach (OrderLine line in order.Lines)
            {   // per page, 7 items can be fit on the screen 
                //   oneline = linePatternText;

                XPen pen = new XPen(XColors.Gray, 0.5);
                pen.DashStyle = XDashStyle.Solid;
                XGraphicsPath path = new XGraphicsPath();

                if (pageLineCounter % pageLineCount == 0)
                {
                    gfx = addPDFPage(firstPage, document, order);
                    itemLineHeight = 0;

                    if (rowCount > pageLineCount && firstPage)          // multiple PDF box drawing
                    {
                        gfx = drawItemBox(gfx, offsetX, 440, 535, 305);
                        pageLineCount = 7;
                        pageLineCounter = 0;
                    }

                    else if (rowCount <= pageLineCount && firstPage)    // 1 page PDF box drawing
                        gfx = drawItemBox(gfx, offsetX, 440, 535, 240);

                    else if (lineCounter + 18 > rowCount)
                    {
                        gfx = drawItemBox(gfx, offsetX, 20, 535, 605);
                        lineStartPositionY = 35;
                        pageLineCount = 16;
                        pageLineCounter = 0;
                    }
                    else
                    {
                        gfx = drawItemBox(gfx, offsetX, 20, 535, 745);
                        lineStartPositionY = 35;
                        pageLineCount = 22;
                        pageLineCounter = 0;
                    }


                }

                if (line.description.Length >= 100) line.description = line.description.Substring(0, 100) + "...";
                if (line.supplierPartID.ToUpper() == "GSSTRANS") subjectPrefix = "Expedite Shipping ";
                if (line.manufacturerName == "MARKETBASKET") subjectPrefix = "JIT ";
                if (line.manufacturerName == "") subjectPrefix = "Non-Catalog ";
                if (order.identity == "PNL") subjectPrefix = "GSS-VWR ";

                font = new XFont("Arial", 9);
                tf = new XTextFormatter(gfx);

                rect = new XRect(offsetX + boxPadding, lineStartPositionY + boxPadding + itemLineHeight, 200 - boxPadding, 75 - boxPadding);
                tf.DrawString(line.manufacturerName + "\n" + line.supplierPartID + " / " + line.unitOfMeasure, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(offsetX + 135 + boxPadding, lineStartPositionY + boxPadding + itemLineHeight, 205 - boxPadding, 75 - boxPadding);
                tf.DrawString(line.description, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                tf.Alignment = XParagraphAlignment.Right;
                rect = new XRect(offsetX + 140 + boxPadding, lineStartPositionY + boxPadding + itemLineHeight, 230 - boxPadding, 75 - boxPadding);
                tf.DrawString(line.quantity.ToString("G29"), font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(offsetX + 210 + boxPadding, lineStartPositionY + boxPadding + itemLineHeight, 230 - boxPadding, 75 - boxPadding);
                tf.DrawString(line.unitPrice.ToString("C"), font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(offsetX + 290 + boxPadding, lineStartPositionY + boxPadding + itemLineHeight, 230 - boxPadding, 75 - boxPadding);
                tf.DrawString(line.extendedPrice.ToString("C"), font, XBrushes.Black, rect, XStringFormats.TopLeft);
                tf.Alignment = XParagraphAlignment.Left;

                itemLineHeight += 32;
                lineCounter++;
                pageLineCounter++;
                firstPage = false;
                //        finishedLines += oneline;
            }

            string footer = "All the prices and amounts shown are in currency USD.\n" +
                            "The sale of goods pursuant to this Order Confirmation is subject to GSS's General Terms and Conditions available at\n";

            string totalLine = "Fuel Surcharge:\n" +
                               "Sub Total:\n" +
                               "Sales Tax:\n" +
                               "Total USD:";
            string totalLineData = "\n" +
                                   "$" + order.total + "\n" +
                                   "\n" +
                                   "$" + order.total + "\n";

            // ############## Footer Text ###################

            rect = new XRect(offsetX, 710, 350, 232);
            gfx.DrawRectangle(XBrushes.Transparent, rect);
            tf.DrawString(footer, font, XBrushes.Black, rect, XStringFormats.TopLeft);

            XFont hyperLink = new XFont("Arial", 9, XFontStyle.Underline);
            XRect hyperRect = new XRect(offsetX, 740, 100, 10);
            gfx.DrawString("http://www.govsci.com/legal.html", hyperLink, XBrushes.Blue, hyperRect, XStringFormats.TopLeft);
            PdfRectangle linkRect = new PdfRectangle(gfx.Transformer.WorldToDefaultPage(hyperRect));
            document.Pages[0].AddWebLink(linkRect, "http://www.govsci.com/legal.html");

            rect = new XRect(420, 690, 250, 232);
            tf.DrawString(totalLine, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);
            tf.Alignment = XParagraphAlignment.Right;
            rect = new XRect(250 + 60, 690, 250, 232);
            tf.DrawString(totalLineData, font, XBrushes.Black, rect, XStringFormats.TopLeft);
            tf.Alignment = XParagraphAlignment.Left;

            document.Save(Constants.PDF_Path + order.identifier + ".pdf");
            return subjectPrefix;
        }

        private XGraphics addPDFPage(bool firstPage, PdfDocument document, OrderHeader order)
        {
            string reqNum = "";
            if (order.extrinsics.Contains("REQUISITION NUM:"))
                reqNum = order.extrinsics.Replace("REQUISITION NUM:", "").Replace("|", "");

            string displayPhoneNumber = order.ShipToAddress.Phone.AreaCode == "" ? order.ShipToAddress.Phone.Number : order.ShipToAddress.Phone.AreaCode + " " + order.ShipToAddress.Phone.Number;
            string displayPlacedBy = order.identity == "JLAB" ? order.ShipToAddress.Name : order.ShipToAddress.DeliverTo;


            string header = "Thank you for placing your order with GSS. We hope you enjoyed your ordering experience. Below is your order confirmation for your product(s). " +
                                "Please review the information for accuracy.\n\n";

            if (order.identity != "PNL")
                header += "We want to hear from you!\n" +
                            "Please take a few minutes to tell us about your ordering experience by clicking on the link below." +
                            "We greatly appreciate your feedback! It is critical in helping us to better meet your needs.\n";

            string header2 = "We will email separate shipment confirmations as your products are dispatched for delivery.\n\n" +
                             "Thank you,\n" +
                             "Mike Mendrysa\n" +
                             "Sales Team Leader\n";


            string gssAddress = "Government Scientific Source\n" +
                                "12355 Sunrise Valley Dr. Suite 400\n" +
                                "Reston\n" +
                                "VA 20191\n";




            string orderInfo = "Order No:\n" +
                               "Order Date:\n";

            string orderInfoData = order.orderID + "\n" +
                                   order.date + "\n";


            string billingInformation = order.BillToAddress.Name + "\n" +
                                        Global.ReturnListStringItem(order.BillToAddress.Streets,0) + "\n" +
                                        Global.ReturnListStringItem(order.BillToAddress.Streets,1) + "\n" +
                                        Global.ReturnListStringItem(order.BillToAddress.Streets,2) + "\n" +
                                        order.BillToAddress.City + " " + order.BillToAddress.State + " " + order.BillToAddress.PostalCode + "\n" +
                                        order.BillToAddress.Country + "\n";

            string shippingInformation = order.ShipToAddress.DeliverTo + "\n" +
                                         Global.ReturnListStringItem(order.ShipToAddress.Streets,0) + "\n" +
                                         Global.ReturnListStringItem(order.ShipToAddress.Streets,1) + "\n" +
                                         Global.ReturnListStringItem(order.ShipToAddress.Streets,2) + "\n" +
                                         order.ShipToAddress.City + " " + order.ShipToAddress.State + " " + order.ShipToAddress.PostalCode + "\n" +
                                         order.ShipToAddress.Country + "\n";

            string billToAttnLine = "Bill To Attn:\n" +
                                    "Ship To Attn:\n";
            if (order.identity != "JLAB") billToAttnLine += "Release No:";

            string billToAttnLineData = "\n" +
                                    order.ShipToAddress.DeliverTo + "\n" +
                                    "\n";
            if (order.identity == "PNL")
                billToAttnLineData += reqNum + "\n";


            string shipToAttnLine = "";
            if (order.identity != "JLAB") shipToAttnLine = "Your P.O.No:";

            shipToAttnLine += "\n" +
                                    "Placed By:\n" +
                                    "Phone No:\n" +
                                    "Email:";

            string shipToAttnLineData = "";
            if (order.identity != "JLAB") shipToAttnLineData = order.orderID;
            shipToAttnLineData += "\n" +
                                        order.ShipToAddress.DeliverTo + "\n" +
                                        "\n" +
                                        order.ShipToAddress.EmailAddress + "\n";

            int offsetX = 30, boxPadding = 5;




            // Create an empty page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            if (firstPage)
            {
                // ############################# Draws the company logo #######################
                string logoPath = Constants.PicturesPath + @"logo.png";
                XImage image = XImage.FromFile(logoPath);
                double x = (250 - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
                gfx.DrawImage(image, x, 10);


                XFont font = new XFont("Arial", 9); //, XFontStyle.Bold);
                XTextFormatter tf = new XTextFormatter(gfx);

                XRect rect = new XRect(offsetX, 70, 540, 232);
                gfx.DrawRectangle(XBrushes.Transparent, rect);
                tf.DrawString(header, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                // Create a font
                XFont hyperLink = new XFont("Arial", 9, XFontStyle.Underline);
                XRect hyperRect = new XRect(offsetX, 132, 100, 10);
                // Draw the text



                PdfRectangle linkRect;

                if (order.identity != "PNL")      // Disable survey link in the pdf
                {
                    gfx.DrawString("Click this Survey Link", hyperLink, XBrushes.Blue, hyperRect, XStringFormats.TopLeft);
                    linkRect = new PdfRectangle(gfx.Transformer.WorldToDefaultPage(hyperRect));
                    page.AddWebLink(linkRect, "http://www.govsci.com/websurvey/?oid=" + order.orderID);
                }

                rect = new XRect(offsetX, 143, 540, 232);
                gfx.DrawRectangle(XBrushes.Transparent, rect);
                tf.DrawString(header2, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                XFont fontBold = new XFont("Arial", 9, XFontStyle.Bold);
                rect = new XRect(offsetX, 194, 540, 232);
                gfx.DrawString("GOVERNMENT SCIENTIFIC SOURCE", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

                hyperRect = new XRect(offsetX, 203, 100, 10);
                gfx.DrawString("http://www.govsci.com", hyperLink, XBrushes.Blue, hyperRect, XStringFormats.TopLeft);
                linkRect = new PdfRectangle(gfx.Transformer.WorldToDefaultPage(hyperRect));
                page.AddWebLink(linkRect, "http://www.govsci.com/");

                XPen pen = new XPen(XColors.Gray, 0.5);
                pen.DashStyle = XDashStyle.Solid;
                XGraphicsPath path = new XGraphicsPath();
                path.AddLine(offsetX, 220, 570, 220);
                gfx.DrawPath(pen, path);

                XFont fontBoldBig = new XFont("Arial", 15, XFontStyle.Bold);
                rect = new XRect(offsetX + 200, 225, 30, 30);
                gfx.DrawString("Order Confirmation", fontBoldBig, XBrushes.Black, rect, XStringFormats.TopLeft);


                rect = new XRect(offsetX, 250, 250, 232);
                tf.DrawString(gssAddress, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(310, 250, 250, 232);
                tf.DrawString(orderInfo, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(370, 250, 250, 232);
                tf.DrawString(orderInfoData, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(offsetX, 295, 540, 232);
                gfx.DrawString("Bill To : " + order.BillToAddress.AddressID, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(310, 295, 540, 232);
                gfx.DrawString("Ship To : " + order.ShipToAddress.AddressID, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);



                rect = new XRect(offsetX + boxPadding, 310 + boxPadding, 230 - boxPadding, 75 - boxPadding);
                gfx = PDFdrawBox(gfx, offsetX, 310, 230, 75, XDashStyle.Solid);
                //    gfx.DrawRectangle(new XSolidBrush(XBrushes.Blue), rect);
                //        tf.Alignment = XParagraphAlignment.Center;
                tf.DrawString(billingInformation, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                rect = new XRect(310 + boxPadding, 310 + boxPadding, 230 - boxPadding, 75 - boxPadding);
                gfx = PDFdrawBox(gfx, 310, 310, 230, 75, XDashStyle.Solid);
                //         tf.Alignment = XParagraphAlignment.Justify;
                tf.DrawString(shippingInformation, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                rect = new XRect(offsetX, 390, 250, 232);
                tf.DrawString(billToAttnLine, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);
                rect = new XRect(offsetX + 60, 390, 250, 232);
                tf.DrawString(billToAttnLineData, font, XBrushes.Black, rect, XStringFormats.TopLeft);


                rect = new XRect(310, 390, 250, 232);
                tf.DrawString(shipToAttnLine, fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);
                rect = new XRect(310 + 60, 390, 250, 232);
                tf.DrawString(shipToAttnLineData, font, XBrushes.Black, rect, XStringFormats.TopLeft);
            }

            return gfx;
        }

        private XGraphics drawItemBox(XGraphics gfx, int x, int y, int width, int height)
        {
            /* ################################### Line Item display ######################## */
            // Draw Outer Box

            XPen pen = new XPen(XColors.Gray, 0.5);
            XGraphicsPath path = new XGraphicsPath();
            XFont fontBold = new XFont("Arial", 9, XFontStyle.Bold);

            gfx = PDFdrawBox(gfx, x, y, width, height, XDashStyle.Solid);
            path.AddLine(x, y + 15, x + width, y + 15);
            gfx.DrawPath(pen, path);

            XRect rect = new XRect(x + 5, y + 3, 150, 20);
            gfx.DrawString("Part Number/UOM", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

            rect = new XRect(x + 140, y + 3, 150, 20);
            gfx.DrawString("Description", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

            rect = new XRect(x + 345, y + 3, 150, 20);
            gfx.DrawString("Quantity", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

            rect = new XRect(x + 400, y + 3, 150, 20);
            gfx.DrawString("Unit Price", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);

            rect = new XRect(x + 465, y + 3, 150, 20);
            gfx.DrawString("Extended Price", fontBold, XBrushes.Black, rect, XStringFormats.TopLeft);
            return gfx;
        }

        private XGraphics PDFdrawBox(XGraphics gfx, double x, double y, double w, double h, XDashStyle dash)
        {

            XPen pen = new XPen(XColors.Gray, 0.5);
            pen.DashStyle = dash;

            XGraphicsPath path = new XGraphicsPath();
            path.AddLine(x, y, x, y + h);
            path.AddLine(x, y + h, x + w, y + h);
            path.AddLine(x + w, y + h, x + w, y);
            path.AddLine(x + w, y, x, y);
            gfx.DrawPath(pen, path);
            return gfx;
        }
    }
}
