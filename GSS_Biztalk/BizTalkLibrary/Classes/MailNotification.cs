using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using BizTalkLibrary.Objects;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BizTalkLibrary.Classes
{
    public class Email
    {
        public static void SendEmail(string msg, string subject, string emailFrom, string emailTo, string emailCC, string emailBCC, string file, bool html)
        {
            EmailConfig emailConfig = Database.GetEmailConfig();
            if (emailTo.Length == 0)
                emailTo = emailConfig.AdminEmail;

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = html;
            string error = "";

            //Message (Body)
            if (msg.Length == 0)
                error += "\nBody of the email is empty";
            else
                mail.Body = msg;

            //Subject
            if (subject.Length == 0)
                error += "\nSubject of the email is blank";
            else
                mail.Subject = subject;

            //CC
            if (emailCC.Length > 0)
            {
                if (emailCC.Contains(';'))
                {
                    string[] emails = emailCC.Split(';');
                    foreach (string email in emails)
                    {
                        if (email.Length > 0)
                        {
                            if (TestEmail(email, false))
                                mail.CC.Add(new MailAddress(email));
                            else
                                error += "\nEmail Carbon Copy (CC) Address is not valid: " + email;
                        }
                    }
                }
                else
                {
                    if (TestEmail(emailCC, false))
                        mail.CC.Add(new MailAddress(emailCC));
                    else
                        error += "\nEmail Carbon Copy (CC) Address is not valid: " + emailCC;
                }
            }

            //From
            if (emailFrom.Length == 0)
                mail.From = new MailAddress("ecommercesystem@govsci.com");
            else
            {
                if (emailFrom.Contains(";"))
                    error += "\nEmail From Address is invalid: " + emailFrom;
                else
                {
                    if (TestEmail(emailFrom, false))
                        mail.From = new MailAddress(emailFrom);
                    else
                        error += "\nEmail From Address is invalid: " + emailFrom;
                }
            }

            //To
            if (emailTo.Contains(';'))
            {
                string[] emails = emailTo.Split(';');
                for (int i = 0; i < emails.Length; i++)
                {
                    if (emails[i].ToString().Length > 0)
                    {
                        if (TestEmail(emails[i], true))
                            mail.To.Add(new MailAddress(emails[i]));
                        else
                            error += "\nEmail To Address is not valid: " + emails[i];
                    }
                }
            }
            else
            {
                if (TestEmail(emailTo, true))
                    mail.To.Add(new MailAddress(emailTo));
                else
                    error += "\nEmail To Address is not valid: " + emailTo;
            }

            //BCC
            if (emailBCC.Length > 0)
            {
                if (emailBCC.Contains(';'))
                {
                    string[] emails = emailBCC.Split(';');
                    foreach (string email in emails)
                    {
                        if (email.Length > 0)
                        {
                            if (TestEmail(email, false))
                                mail.Bcc.Add(new MailAddress(email));
                            else
                                error += "\nEmail Blind Carbon Copy (BCC) Address is not valid: " + email;
                        }
                    }
                }
                else
                {
                    if (TestEmail(emailBCC, false))
                        mail.Bcc.Add(new MailAddress(emailBCC));
                    else
                        error += "\nEmail Blind Carbon Copy (BCC) Address is not valid: " + emailBCC;
                }
            }

            //File
            if (file.Length > 0)
            {
                if (file.Contains(';'))
                {
                    string[] files = file.Split(';');
                    foreach (string fil in files)
                        if (fil.Length > 0 && File.Exists(fil))
                            mail.Attachments.Add(new Attachment(fil));
                }
                else if (file.Contains(','))
                {
                    string[] files = file.Split(',');
                    foreach (string fil in files)
                        if (fil.Length > 0 && File.Exists(fil))
                            mail.Attachments.Add(new Attachment(fil));
                }
                else if (File.Exists(file))
                    mail.Attachments.Add(new Attachment(file));
            }

            if (error.Length == 0)
                Send(mail, emailConfig);
            else
                throw new Exception("The following errors have occurred: " + error);
        }
        public static void SendErrorMessage(Exception ex, string orchestration, string theclass, string function, string orderId, SqlCommand cmd)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine($"<b>{(Constants.DEBUG ? "DEV" : "PRD")}-BIZTALK Server Error</b><br><br>");
            msg.AppendLine($"<table border='1' style='border-collapse:collapse'><tbody>");
            msg.AppendLine($"<tr><th style='text-align:left;width:115px;padding:0px 10px;background-color:rgb(245,245,220);'>Date and Time:</th><td style='padding:5px 20px;'>{DateTime.Now}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:115px;padding:0px 10px;background-color:rgb(245,245,220);'>Order ID:</th><td style='padding:5px 20px;'>{orderId}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:115px;padding:0px 10px;background-color:rgb(245,245,220);'>Orchestration:</th><td style='padding:5px 20px;'>{orchestration}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:115px;padding:0px 10px;background-color:rgb(245,245,220);'>Class:</th><td style='padding:5px 20px;'>{theclass}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:115px;padding:0px 10px;background-color:rgb(245,245,220);'>Method:</th><td style='padding:5px 20px;'>{function}</td></tr>");
            msg.AppendLine($"</tbody></table><br/><br/>");

            msg.AppendLine($"<table border='1' style='border-collapse:collapse'><tbody><tr><th style='text-align:left;width:100px;padding:5px 10px;background-color:rgb(173,216,230);' colspan=2>THROWN ERROR DETAILS</th></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Message</th><td style='padding:5px 20px;'>{ex.Message}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Target Site</th><td style='padding:5px 20px;'>{ex.TargetSite}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Stack Trace</th><td style='padding:5px 20px;'>{ex.StackTrace}</td></tr>");
            msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Source</th><td style='padding:5px 20px;'>{ex.Source}</td></tr></tbody></table>");

            GetInnerExceptions(ex.InnerException, ref msg, 1);

            if (cmd != null)
            {
                StringBuilder query = new StringBuilder();
                query.Append(cmd.CommandText);
                foreach (SqlParameter para in cmd.Parameters)
                    query.Append($" {para.ParameterName}='{para.Value}', ");
                if (query.Length > 0) msg.AppendLine($"<b>SQL</b>: {query.ToString()}<br>");
            }

            SendEmail(msg.ToString(), $"{(Constants.DEBUG ? "DEV" : "PRD")}-BIZTALK Error", Constants.systemEmail, "dev_error@govsci.com", "", "", "", true);
        }
        private static void GetInnerExceptions(Exception ex, ref StringBuilder msg, int i)
        {
            if (ex != null)
            {
                msg.AppendLine($"<table border='1' style='border-collapse:collapse'><tbody><tr><th style='text-align:left;width:100px;padding:5px 10px;background-color:rgb(173,216,230);' colspan=2>INNER EXCEPTION {i} DETAILS</th></tr>");
                msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Message</th><td style='padding:5px 20px;'>{ex.Message}</td></tr>");
                msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Target Site</th><td style='padding:5px 20px;'>{ex.TargetSite}</td></tr>");
                msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Stack Trace</th><td style='padding:5px 20px;'>{ex.StackTrace}</td></tr>");
                msg.AppendLine($"<tr><th style='text-align:left;width:100px;padding:0px 10px;background-color:rgb(173,216,230);'>Source</th><td style='padding:5px 20px;'>{ex.Source}</td></tr></tbody></table>");

                GetInnerExceptions(ex.InnerException, ref msg, ++i);
            }
            else
                return;
        }
        private static void Send(MailMessage mail, EmailConfig emailConfig)
        {
            try
            {
                SmtpClient client = new SmtpClient(emailConfig.Host);
                client.Credentials = new NetworkCredential(emailConfig.Username, emailConfig.Password, emailConfig.Domain);
                client.Send(mail);
            }
            catch (Exception)
            {

            }
        }        
        private static bool TestEmail(string email, bool req)
        {
            try
            {
                if (email.Length > 0)
                    new MailAddress(email);
                else if (req)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public static class MailNotification
    {
        public static void Send702Confirmation(string navSONUM, string sellToNo, string manufacturerName, string orderID)
        {
            StringBuilder to = new StringBuilder();
            to.Append("gss-purchasing@govsci.com");

            switch (sellToNo)
            {
                case "JEFFERSON SCIENCE": to.Append(";jlab@govsci.com"); break;
                case "SLAC": to.Append(";slacorders@govsci.com"); break;
                case "SLAC CHEMICAL": to.Append(";slacorders@govsci.com"); break;
                case "BATTELLE COLUMBUS": to.Append(";battelle@govsci.com"); break;
                case "INEEL": to.Append(";inlorders@govsci.com"); break;
                case "RICHLAND": to.Append(";pnnlorders@govsci.com"); break;
                case "BERKELEY": to.Append(";LBNLorders@govsci.com"); break;
                case "ARGONNE AMOS": to.Append(";argonneorders@govsci.com"); break;
            }            

            Email.SendEmail($"Navision Sales Order number is {navSONUM} for your reference.", $"702 Order Confirmation for {sellToNo} {manufacturerName} {orderID}", Constants.systemEmail, to.ToString(), "", Constants.adminEmail, "", true);
        }

        public static void SendOrderConfirmationEmail(string identifier)
        {
            string orderid = "";
            try
            {
                OrderHeader order = Database.GetOrder(identifier);
                orderid = order.orderID;
                StringBuilder toEmails = new StringBuilder(), bccEmails = new StringBuilder();

                if (!Constants.DEBUG)
                {
                    if (order.ShipToAddress.EmailAddress != "") toEmails.Append($"{order.ShipToAddress.EmailAddress};");
                    bccEmails.Append($"{Constants.adminEmail};");

                    if (order.orderEmailTo.Length > 0) bccEmails.Append($"{order.orderEmailTo};");
                    if (order.orderEmailTo == "jlab@govsci.com")
                        bccEmails.Append("brownd@jlab.org;");
                    else if (order.orderEmailTo == "cselectronicpos@govsci.com")
                        bccEmails.Append("gpfaffe@govsci.com;");
                    else if (order.orderEmailTo == "inlorders@govsci.com")
                        bccEmails.Append("Jennifer.Boyd@inl.gov;");
                }
                else
                    toEmails.Append(Constants.adminEmail);

                switch (order.orderCOnfirmation)
                {
                    case "1": // email order confirmation
                        string templateText = File.Exists(@order.OCTemplate) ? File.ReadAllText(@order.OCTemplate) : "ERROR READING";

                        templateText = templateText.Replace("<-ORDERID->", order.orderID);
                        templateText = templateText.Replace("<-ORDERDATE->", Global.GetTimeFromTimeStamp(order.timestamp));
                        templateText = templateText.Replace("<-BILLTOADDRESSID->", order.BillToAddress.AddressID);
                        templateText = templateText.Replace("<-BILLTONAME->", order.BillToAddress.Name);
                        templateText = templateText.Replace("<-BILLTOSTREET1->", Global.ReturnListStringItem(order.BillToAddress.Streets,0));
                        templateText = templateText.Replace("<-BILLTOSTREET2->", Global.ReturnListStringItem(order.BillToAddress.Streets,1));
                        templateText = templateText.Replace("<-BILLTOSTREET3->", Global.ReturnListStringItem(order.BillToAddress.Streets,2));
                        templateText = templateText.Replace("<-BILLTOCITY->", order.BillToAddress.City);
                        templateText = templateText.Replace("<-BILLTOSTATE->", order.BillToAddress.State);
                        templateText = templateText.Replace("<-BILLTOPOSTALCODE->", order.BillToAddress.PostalCode);
                        templateText = templateText.Replace("<-BILLTOCOUNTRY->", order.BillToAddress.Country);

                        templateText = templateText.Replace("<-SHIPTOADDRESSID->", order.ShipToAddress.AddressID);
                        templateText = templateText.Replace("<-SHIPTODELIVERTO->", order.ShipToAddress.DeliverTo);
                        templateText = templateText.Replace("<-SHIPTOSTREET1->", Global.ReturnListStringItem(order.ShipToAddress.Streets,0));
                        templateText = templateText.Replace("<-SHIPTOSTREET2->", Global.ReturnListStringItem(order.ShipToAddress.Streets,1));
                        templateText = templateText.Replace("<-SHIPTOSTREET3->", Global.ReturnListStringItem(order.ShipToAddress.Streets,2));
                        templateText = templateText.Replace("<-SHIPTOCITY->", order.ShipToAddress.City);
                        templateText = templateText.Replace("<-SHIPTOSTATE->", order.ShipToAddress.State);
                        templateText = templateText.Replace("<-SHIPTOPOSTALCODE->", order.ShipToAddress.PostalCode);
                        templateText = templateText.Replace("<-SHIPTOCOUNTRY->", order.ShipToAddress.Country);
                        templateText = templateText.Replace("<-SHIPTOEMAIL->", order.ShipToAddress.EmailAddress);

                        templateText = templateText.Replace("&amp;", "&");

                        templateText = templateText.Replace("<-HANDLING->", "FREE");
                        templateText = templateText.Replace("<-ORDERTOTAL->", order.total);

                        Regex repeatCheck = new Regex(@"<-REPEAT:START->(?<line>.*?)<-REPEAT:END->", RegexOptions.Singleline);
                        Match repeatMatch = repeatCheck.Match(templateText);
                        string linePatternText = repeatMatch.Groups["line"].Value;
                        string finishedLines = "";

                        if (linePatternText != "")
                        {
                            foreach (OrderLine line in order.Lines)
                            {
                                string oneline = linePatternText;
                                oneline = oneline.Replace("<-VENDOR->", line.manufacturerName);
                                oneline = oneline.Replace("<-PARTNUMBER->", line.supplierPartID);
                                oneline = oneline.Replace("<-PARTAUXNUMBER->", line.supplierPartAuxiliaryID);
                                oneline = oneline.Replace("<-QTY->", line.quantity.ToString("G29"));
                                oneline = oneline.Replace("<-UNITPRICE->", line.unitPrice.ToString("G29"));
                                oneline = oneline.Replace("<-DESCRIPTION->", line.description.Replace("''", "'"));
                                oneline = oneline.Replace("<-UOM->", line.unitOfMeasure);
                                oneline = oneline.Replace("<-MFCNAME->", line.manufacturerName);
                                oneline = oneline.Replace("<-LINETOTAL->", line.extendedPrice.ToString("G29"));
                                finishedLines += oneline;
                            }
                        }

                        Regex repeatCheck2 = new Regex(@"<-REPEAT:START->.*?<-REPEAT:END->", RegexOptions.Singleline);
                        templateText = repeatCheck2.Replace(templateText, finishedLines);

                        if (order.ShipToAddress.EmailAddress != "")
                        {
                            Email.SendEmail(templateText
                                , $"Order Confirmation for GSS Ecommerce order {order.orderID}"
                                , Constants.systemEmail
                                , toEmails.ToString()
                                , ""
                                , bccEmails.ToString()
                                , order.Attachments
                                , true);
                            Database.UpdateOrderConfirmation(identifier);
                        }

                        break;

                    case "2": // email order confirmation in PDF format

                        Create_PDF pdf = new Create_PDF(order);
                        order.subjectPrefix = pdf.SubjectPrefix;

                        if (order.extrinsics.Contains("ExpediteShipping:Y") || order.comments.CompareTo("Overnight Shipping") == 0)
                            order.subjectPrefix = "Expedite Shipping ";                        

                        // ######### test confirmation email bcc ####################
                        

                        Email.SendEmail("Please open the file attachment for your order confirmation."
                            , $"{order.subjectPrefix} Order Confirmation for GSS Ecommerce order {order.orderID}", Constants.systemEmail
                            , toEmails.ToString()
                            , ""
                            , bccEmails.ToString()
                            , $"{Constants.PDF_Path}{identifier}.pdf;{order.Attachments}"
                            , false);

                        Database.UpdateOrderConfirmation(identifier);

                        break;

                    case "3": // email new auto responder order acknowledgement
                        if (Database.CheckOrderConfirmation(order.orderID)) break;

                        AutoResponder auto = Database.GetAutoResponderConfig(104);

                        string contactName = order.ShipToAddress.DeliverTo;
                        if (order.ShipToAddress.DeliverTo.EndsWith("@pnnl.gov"))
                            contactName = order.ShipToAddress.DeliverTo.Split('@')[0].Replace(".", "").ToUpper();

                        auto.Body = auto.Body.Replace("[Contact Name]", contactName)
                            .Replace("[Customer PO No]", order.orderID)
                            .Replace("[Placed By]", contactName)
                            .Replace("[Phone No]", order.ShipToAddress.Phone.Number)
                            .Replace("[Email]", order.ShipToAddress.EmailAddress)
                            .Replace("[BillToName]", order.BillToAddress.Name)
                            .Replace("[BillToDeliverTo]", order.BillToAddress.DeliverTo)
                            .Replace("[BillToAddress1]", Global.ReturnListStringItem(order.BillToAddress.Streets,0))
                            .Replace("[BillToAddress2]", Global.ReturnListStringItem(order.BillToAddress.Streets,1))
                            .Replace("[BillToAddress3]", Global.ReturnListStringItem(order.BillToAddress.Streets,2))
                            .Replace("[BillToCity]", order.BillToAddress.City)
                            .Replace("[BillToState]", order.BillToAddress.State)
                            .Replace("[BillToZip]", order.BillToAddress.PostalCode)
                            .Replace("[ShipToID]", order.ShipToAddress.AddressID)
                            .Replace("[ShipToName]", order.ShipToAddress.Name)
                            .Replace("[ShipToDeliverTo]", order.ShipToAddress.DeliverTo)
                            .Replace("[ShipToAddress1]", Global.ReturnListStringItem(order.ShipToAddress.Streets,0))
                            .Replace("[ShipToAddress2]", Global.ReturnListStringItem(order.ShipToAddress.Streets,1))
                            .Replace("[ShipToAddress3]", Global.ReturnListStringItem(order.ShipToAddress.Streets,2))
                            .Replace("[ShipToCity]", order.ShipToAddress.City)
                            .Replace("[ShipToState]", order.ShipToAddress.State)
                            .Replace("[ShipToZip]", order.ShipToAddress.PostalCode)
                            .Replace("[Order Date]", Global.GetTimeFromTimeStamp(order.timestamp));

                        string bodyCart = "", auxPartNo = "";
                        decimal orderTotal = 0.0M;

                        string lineQuery = "";
                        foreach (OrderLine line in order.Lines)
                        {
                            bodyCart += auto.Cart.Replace("[SupplierPartNo]", line.manufacturerName + "<br>" + line.supplierPartID)
                                .Replace("[Description]", line.description)
                                .Replace("[PriceUOM]", "$" + line.unitPrice.ToString("G29") + "<br>" + line.unitOfMeasure)
                                .Replace("[Quantity]", line.quantity.ToString("G29"))
                                .Replace("[ExtPrice]", "$" + (line.extendedPrice).ToString("G29"));

                            if (line.manufacturerName == "DELL IT" && line.unitPrice > 1000.00M)
                                auxPartNo = line.supplierPartAuxiliaryID;

                            orderTotal += line.extendedPrice;

                            if (lineQuery.Length > 0)
                                lineQuery += ",([insertedid],'" + line.supplierPartID + "','" + line.manufacturerName + "','" + line.unitOfMeasure + "'," + line.quantity.ToString() + ")";
                            else
                                lineQuery = "([insertedid],'" + line.supplierPartID + "','" + line.manufacturerName + "','" + line.unitOfMeasure + "'," + line.quantity.ToString() + ")";

                            if (line.supplierPartID.ToUpper() == "GSSTRANS") order.subjectPrefix = "Expedite Shipping";
                            if (line.manufacturerName == "MARKETBASKET") order.subjectPrefix = "JIT";
                            if (line.manufacturerName == "") order.subjectPrefix = "Non-Catalog";
                        }

                        if (order.identity == "PNL") order.subjectPrefix = "GSS-VWR";

                        if (order.salespersonPhone.Length == 0) order.salespersonPhone = "800-248-8030";
                        if (order.orderEmailTo.Length > 0) order.salespersonEmail = order.orderEmailTo;
                        if (order.salespersonEmail.Length == 0) order.salespersonEmail = order.salesTeamEmail;
                        if (order.ShipToAddress.EmailAddress.Length == 0) order.ShipToAddress.EmailAddress = order.salespersonEmail;
                        if (order.salesTeamPhoneNo.Length == 0) order.salesTeamPhoneNo = "800-248-8030";

                        auto.Body = auto.Body.Replace("[cart]", bodyCart)
                            .Replace("[Subtotal]", "$" + orderTotal.ToString("G29"))
                            .Replace("[tax]", "$0.00")
                            .Replace("[orderTotal]", "$" + orderTotal.ToString("G29"))
                            .Replace("[Extra Comments]", order.extraComments);

                        auto.Body = auto.Body.Replace("[SalesTeamEmail]", order.orderEmailTo.Length > 0 ? order.orderEmailTo : order.salesTeamEmail)
                            .Replace("[SalespersonPhoneNumber]", order.salespersonPhone)
                            .Replace("[SalespersonName]", order.salespersonName)
                            .Replace("[SalespersonEmailAddress]", order.salespersonEmail)
                            .Replace("[SalesTeamPhoneNumber]", order.salesTeamPhoneNo);

                        string extraComments = "";
                        if (auxPartNo.Length > 0)
                            extraComments = Database.GetExtraComments(auxPartNo);
                        if (extraComments.Length > 0) extraComments = "<br><br>" + extraComments + "<br>";
                        auto.Body = auto.Body.Replace("[Extrinsics]", extraComments);

                        if (order.orderID.ToUpper().StartsWith("47Q"))
                            auto.Body = auto.Body.Replace("[Comments]", "");
                        else
                        {
                            StringBuilder sb = new StringBuilder();
                            MatchCollection mc = Regex.Matches(order.comments, @"Comment Type: (?<ctype>.+?) Comment Body: (?<cbody>.*?)\s?Comment By: (?<cby>.+?) Comment Date: (?<cdate>\d{4}-\d\d-\d\dT\d\d:\d\d:\d\d-\d\d:\d\d)");
                            foreach (Match m in mc)
                            {
                                sb.AppendLine("Comment Type: " + m.Groups["ctype"].Value);
                                sb.AppendLine("Comment Body: " + m.Groups["cbody"].Value);
                                sb.AppendLine("Comment By: " + m.Groups["cby"].Value);
                                sb.AppendLine("Comment Date: " + m.Groups["cdate"].Value);
                                sb.AppendLine("");
                            }

                            if (sb.Length > 0)
                                auto.Body = auto.Body.Replace("[Comments]", sb.ToString());
                            else
                                auto.Body = auto.Body.Replace("[Comments]", order.comments);
                        }

                        if (order.ShipToAddress.EmailAddress != "")
                        {
                            if (order.extrinsics.Contains("ExpediteShipping:Y") || order.comments.CompareTo("Overnight Shipping") == 0 || order.expedite)
                                order.subjectPrefix = "Expedite Shipping ";

                            Database.UpdateOrderConfirmation(identifier);

                            string body = auto.Header.Replace("[style]", auto.Style) + auto.Body.Replace("[style]", auto.BodyStyle) + auto.Footer;
                            string subject = auto.Subject.Replace("[Order No]", order.orderID).Replace("[SubjectPrefix]", order.subjectPrefix.Length > 0 ? order.subjectPrefix + " " : "");

                            string insertedid = Database.InsertOrderAck(order.orderID, subject, body, toEmails, bccEmails, lineQuery);

                            if (insertedid.Length > 0)
                            {
                                Email.SendEmail(body
                                    , subject
                                    , Constants.systemEmail
                                    , toEmails.ToString()
                                    , ""
                                    , bccEmails.ToString()
                                    , order.Attachments
                                    , true);
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Email.SendErrorMessage(ex, "", "MailNotification", "SendOrderConfirmationEmail", orderid, null);
            }
        }

        public static void SendVendorAsn(ASN_Header asn)
        {
            StringBuilder emailContent = new StringBuilder();
            string emailForwardToEmail = Database.GetAsnEmailForward(asn.Credentials);

            emailContent.AppendLine($"<b>Shipment No.:</b> {asn.ShipmentID}<br/>");
            emailContent.AppendLine($"<b>Shipment Date:</b> {asn.ShipmentDate}<br/>");
            emailContent.AppendLine($"<b>Order No.:</b> {asn.OrderID}<br/>");
            if (asn.PayloadID.Length > 0) emailContent.AppendLine($"Payload ID: {asn.PayloadID}<br/>");
            emailContent.AppendLine("<hr/><br/>");

            if (asn.ShipmentID.Length>0) emailContent.AppendLine($"<b>ShipmentID:</b> {asn.ShipmentID}<br/>");
            if(asn.NoticeDate.Length>0) emailContent.AppendLine($"<b>Notice Date:</b> {asn.NoticeDate}<br/>");
            if(asn.CarrierIdentifierDomain.Length>0) emailContent.AppendLine($"<b>Carrier Domain:</b> {asn.CarrierIdentifierDomain}<br/>");
            if (asn.CarrierIdentifier.Length > 0) emailContent.AppendLine($"<b>Carrier Identifier:</b> {asn.CarrierIdentifier}<br/>");
            if (asn.ShipmentIdentifier.Length > 0) emailContent.AppendLine($"<b>Shipment identifier:</b> {asn.ShipmentIdentifier}<br/>");
            emailContent.AppendLine("<hr/><br/>");

            foreach (Address addr in asn.Contacts)
            {
                if(addr.Role != "") emailContent.AppendLine($"<b>Type of Contact Info:</b> {addr.Role}<br/>");
                if(addr.Name != "") emailContent.AppendLine(addr.Name + "<br/>");
                if(addr.Name2 != "") emailContent.AppendLine(addr.Name2 + "<br/>");

                for (int i = 0; i < addr.MultipleDeliverTos.Count; i++)
                    if (addr.MultipleDeliverTos[i].Length > 0)
                        emailContent.AppendLine(addr.MultipleDeliverTos[i] + "<br/>");

                for (int i = 0; i < addr.Streets.Count; i++)
                    if (addr.Streets[i].Length > 0)
                        emailContent.AppendLine(addr.Streets[i] + "<br/>");

                if (addr.City != "") emailContent.AppendLine(addr.City + "<br/>");
                if (addr.State != "") emailContent.AppendLine(addr.State + "<br/>");
                if (addr.PostalCode != "") emailContent.AppendLine(addr.PostalCode + "<br/>");
                if (addr.Country != "") emailContent.AppendLine(addr.Country + "<br/>");
                if (addr.CountryCode != "") emailContent.AppendLine(addr.CountryCode + "<br/>");
                if (addr.EmailAddress != "") emailContent.AppendLine($"<b>Email Address:</b> {addr.EmailAddress}<br/>");
                if (addr.Phone.Name != "") emailContent.AppendLine($"<b>Phone Name:</b> {addr.Phone.Name}<br/>");
                emailContent.AppendLine($"<b>Phone Number:</b> {addr.Phone.CountryCode} {addr.Phone.Country} ({addr.Phone.AreaCode}) {addr.Phone.Number} ext. {addr.Phone.Extension}<br/>");
                emailContent.AppendLine("<hr/><br/>");
            }

            emailContent.AppendLine("<b>Items Shipped:</b>");
            emailContent.AppendLine("<table border='1' style='border-collapse:collapse'><tbody><tr><th>Line Number</th><th>Quantity</th><th>Unit of Measure</th></tr>");
            foreach (ASN_Line line in asn.Lines)
                emailContent.AppendLine($"<tr><td>{line.LineNumber}</td><td>{line.Quantity}</td><td>{line.UnitOfMeasure}</td></tr>");
            emailContent.AppendLine("</tbody></table>");

            if (emailForwardToEmail.Length == 0) emailForwardToEmail = "gss-it-development@govsci.com;purchase_orders@govsci.com";

            //Email.SendEmail(emailContent.ToString(), $"Advanced Shipping Notification for order {asn.OrderID} has been received.", Constants.systemEmail, emailForwardToEmail, "", Constants.adminEmail, "", true);
            Email.SendEmail(emailContent.ToString(), $"Advanced Shipping Notification for order {asn.OrderID} has been received.", Constants.systemEmail, Constants.adminEmail, "", Constants.adminEmail, "", true);
        }

        public static void SendVendorOC(OrderConfirmationHeader oc)
        {
            StringBuilder emailContact = new StringBuilder();

            if (oc.CxmlCredentials.FromIdentity.Length > 0) emailContact.AppendLine($"<b>From Identity:</b> {oc.CxmlCredentials.FromIdentity}<br/>");
            if (oc.CxmlCredentials.UserAgent.Length > 0) emailContact.AppendLine($"<b>User Agent:</b> {oc.CxmlCredentials.UserAgent}<br/>");
            emailContact.AppendLine($"<b>Payload ID:</b> {oc.PayloadID}<br/>");
            emailContact.AppendLine($"<b>Confirmation No.:</b> {oc.ConfirmID}<br/>");
            emailContact.AppendLine($"<b>Confirmation Date:</b> {oc.NoticeDate}<br/>");
            emailContact.AppendLine($"<b>Order No.:</b> {oc.OrderID}<br/>");
            emailContact.AppendLine($"<b>Order Date:</b> {oc.OrderDate}<br/>");
            emailContact.AppendLine($"<hr/><br/>");

            emailContact.AppendLine($"<b>Operation:</b> {oc.Operation}<br/>");
            emailContact.AppendLine($"<b>Type:</b> {oc.Type}<br/>");
            emailContact.AppendLine($"<b>Total:</b> {oc.Total}<br/>");
            emailContact.AppendLine($"<hr/><br/>");

            foreach(Address addr in oc.Contacts)
            {
                emailContact.AppendLine($"<b>Role:</b> {addr.Role}<br/>");
                emailContact.AppendLine($"<b>Address ID:</b> {addr.AddressID}<br/>");
                emailContact.AppendLine($"<b>Name:</b> {addr.Name}<br/>");
                emailContact.AppendLine($"<b>Name 2:</b> {addr.Name2}<br/>");

                if (addr.MultipleDeliverTos.Count > 0)
                    for (int i = 0; i < addr.MultipleDeliverTos.Count; i++)
                        emailContact.AppendLine($"<b>Deliver To {i+1}:</b> {addr.MultipleDeliverTos[i]}<br/>");

                if (addr.Streets.Count > 0)
                    for (int i = 0; i < addr.Streets.Count; i++)
                        emailContact.AppendLine($"<b>Street {i + 1}:</b> {addr.Streets[i]}<br/>");

                emailContact.AppendLine($"<b>City:</b> {addr.City}<br/>");
                emailContact.AppendLine($"<b>State:</b> {addr.State}<br/>");
                emailContact.AppendLine($"<b>Postal Code:</b> {addr.PostalCode}<br/>");
                emailContact.AppendLine($"<b>Country Code:</b> {addr.CountryCode}<br/>");
                emailContact.AppendLine($"<b>Country:</b> {addr.Country}<br/>");
                emailContact.AppendLine($"<hr/><br/>");
            }

            if (oc.Extrinsics.Count > 0)
            {
                foreach (string extr in oc.Extrinsics)
                    emailContact.AppendLine(extr);
                emailContact.AppendLine($"<hr/><br/>");
            }

            emailContact.AppendLine("<table border='1' style='border-collapse:collapse'><tbody><tr><th>Line No</th><th>Confirmation Type</th><th>Item Type</th><th>Item No.</th><th>Description</th><th>UoM</th><th>Confirmed UoM</th><th>Qty</th><th>Confirmed Qty</th><th>Unit Price</th><th>Confirmed Unit Price</th><th>Ship Date</th><th>Del Date</th><th>Ship To</th><th>Contacts</th><th>Est. Tax</th><th>Extrinsics</th><th>Shipping Desc.</th><th>Comments</th></tr>");
            foreach (OrderConfirmationLine line in oc.Lines)
            {
                StringBuilder shipTo = new StringBuilder();
                if (line.ShipTo != null)
                {
                    if (line.ShipTo.Role.Length > 0) shipTo.AppendLine($"<b>Role:</b> {line.ShipTo.Role}<br/>");
                    if (line.ShipTo.AddressID.Length > 0) shipTo.AppendLine($"<b>Address ID:</b> {line.ShipTo.AddressID}<br/>");
                    if (line.ShipTo.Name.Length > 0) shipTo.AppendLine($"<b>Name:</b> {line.ShipTo.Name}<br/>");
                    if (line.ShipTo.Name2.Length > 0) shipTo.AppendLine($"<b>Name 2:</b> {line.ShipTo.Name2}<br/>");

                    if (line.ShipTo.MultipleDeliverTos.Count > 0)
                        for (int i = 0; i < line.ShipTo.MultipleDeliverTos.Count; i++)
                            shipTo.AppendLine($"<b>Deliver To {i + 1}:</b> {line.ShipTo.MultipleDeliverTos[i]}<br/>");

                    if (line.ShipTo.Streets.Count > 0)
                        for (int i = 0; i < line.ShipTo.Streets.Count; i++)
                            shipTo.AppendLine($"<b>Street {i + 1}:</b> {line.ShipTo.Streets[i]}<br/>");

                    if (line.ShipTo.City.Length > 0) shipTo.AppendLine($"<b>City:</b> {line.ShipTo.City}<br/>");
                    if (line.ShipTo.State.Length > 0) shipTo.AppendLine($"<b>State:</b> {line.ShipTo.State}<br/>");
                    if (line.ShipTo.PostalCode.Length > 0) shipTo.AppendLine($"<b>Postal Code:</b> {line.ShipTo.PostalCode}<br/>");
                    if (line.ShipTo.CountryCode.Length > 0) shipTo.AppendLine($"<b>Country Code:</b> {line.ShipTo.CountryCode}<br/>");
                    if (line.ShipTo.Country.Length > 0) shipTo.AppendLine($"<b>Country:</b> {line.ShipTo.Country}<br/>");
                    if (shipTo.Length > 0) shipTo.AppendLine($"<hr/><br/>");
                }

                StringBuilder contacts = new StringBuilder();
                foreach (Address contact in line.Contacts)
                {
                    if (contact.Role.Length > 0) contacts.AppendLine($"<b>Role:</b> {contact.Role}<br/>");
                    if (contact.AddressID.Length > 0) contacts.AppendLine($"<b>Address ID:</b> {contact.AddressID}<br/>");
                    if (contact.Name.Length > 0) contacts.AppendLine($"<b>Name:</b> {contact.Name}<br/>");
                    if (contact.Name2.Length > 0) contacts.AppendLine($"<b>Name 2:</b> {contact.Name2}<br/>");

                    if (contact.MultipleDeliverTos.Count > 0)
                        for (int i = 0; i < contact.MultipleDeliverTos.Count; i++)
                            contacts.AppendLine($"<b>Deliver To {i + 1}:</b> {contact.MultipleDeliverTos[i]}<br/>");

                    if (contact.Streets.Count > 0)
                        for (int i = 0; i < contact.Streets.Count; i++)
                            contacts.AppendLine($"<b>Street {i + 1}:</b> {contact.Streets[i]}<br/>");

                    if (contact.City.Length > 0) contacts.AppendLine($"<b>City:</b> {contact.City}<br/>");
                    if (contact.State.Length > 0) contacts.AppendLine($"<b>State:</b> {contact.State}<br/>");
                    if (contact.PostalCode.Length > 0) contacts.AppendLine($"<b>Postal Code:</b> {contact.PostalCode}<br/>");
                    if (contact.CountryCode.Length > 0) contacts.AppendLine($"<b>Country Code:</b> {contact.CountryCode}<br/>");
                    if (contact.Country.Length > 0) contacts.AppendLine($"<b>Country:</b> {contact.Country}<br/>");
                    if (contacts.Length > 0) contacts.AppendLine($"<hr/><br/>");
                }

                StringBuilder extrinsics = new StringBuilder();
                foreach (string extr in line.Extrinsics)
                    extrinsics.AppendLine($"{extr}<br/>");

                emailContact.AppendLine($"<tr><td>{line.LineNumber}</td>"
                    + $"<td>{line.ConfirmationType}</td>"
                    + $"<td>{line.ItemType}</td>"
                    + $"<td>{line.SupplierPartID}</td>"
                    + $"<td>{line.Description}</td>"
                    + $"<td>{line.UnitOfMeasure}</td>"
                    + $"<td>{line.ConfirmedUnitOfMeasure}</td>"
                    + $"<td>{line.Quantity}</td>"
                    + $"<td>{line.ConfirmedQuantity}</td>"
                    + $"<td>{line.UnitPrice}</td>"
                    + $"<td>{line.ConfirmedUnitPrice}</td>"
                    + $"<td>{line.ShipmentDate}</td>"
                    + $"<td>{line.DeliveryDate}</td>"
                    + $"<td>{shipTo.ToString()}</td>"
                    + $"<td>{contacts.ToString()}</td>"
                    + $"<td>{line.TaxAmount}</td>"
                    + $"<td>{extrinsics.ToString()}</td>"
                    + $"<td>{line.ShippingDescription}</td>"
                    + $"<td>{line.Comments}</td></tr>");
            }
            emailContact.AppendLine("</tbody></table>");

            Email.SendEmail(emailContact.ToString(), $"Order Confirmation Notification for order {oc.OrderID} has been received.", Constants.systemEmail, Constants.adminEmail, "", Constants.adminEmail, "", true);
        }
        public static void SendOrderCancellationNotice(string orderID, string comments)
        {
            //Email.SendEmail($"Request to cancel order {orderID} has been received. Please follow standard operating procedures to cancel this order.\r\n\r\nCancellation Comments: {comments}", $"Request to Cancel Order {orderID}", Constants.systemEmail, "gpfaffe@govsci.com;cselectronicpos@govsci.com", Constants.adminEmail, "", "", false);
            Email.SendEmail($"Request to cancel order {orderID} has been received. Please follow standard operating procedures to cancel this order.\r\n\r\nCancellation Comments: {comments}", $"Request to Cancel Order {orderID}", Constants.systemEmail, "zlingelbach@govsci.com", Constants.adminEmail, "", "", false);
        }
    }
}
