using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizTalkLibrary.WS_ItemCard;
using BizTalkLibrary.Objects;
using BizTalkLibrary.WS_ShipToAddress;
using BizTalkLibrary.WS_CustomerContact;
using BizTalkLibrary.WS_CustomerCreditCards;
using BizTalkLibrary.WS_SalesOrder;
using BizTalkLibrary.WS_PurchaseOrder;
using BizTalkLibrary.WS_AutoPostDoc;

namespace BizTalkLibrary.Classes
{
    public static class ERP_Web_Service_Functions
    {
        public static void insertNewItems(string vendorName, string gssPartNum, string description, string uom, string unitPrice, string vendorPartNum, string UNSPSC)
        {
            description = Global.RemoveStrings(description);

            if (vendorPartNum.Length > Constants.MAX_PARTNUMBER_LENGTH)
                Database.InsertReferenceGssPartNumber(gssPartNum, vendorName, vendorPartNum, uom);

            /************* If vendor part number is longer than Navision Max length, chop off the number **************/
            /************* Added on June.28.2017 by Sean Jang - Requested by Nick Williams               **************/

            if (vendorPartNum.Length > Constants.MAX_VENDORPARTNUMBER_LENGTH)
                vendorPartNum = vendorPartNum.Substring(0, Constants.MAX_VENDORPARTNUMBER_LENGTH);

            string description2 = "";
            if (description.Length >= Constants.MAX_DESCRIPTION_LENGTH)
            {
                description2 = description.Substring(Constants.MAX_DESCRIPTION_LENGTH, description.Length - Constants.MAX_DESCRIPTION_LENGTH);
                description2 = description2.Substring(0, Math.Min(description2.Length, Constants.MAX_DESCRIPTION_LENGTH));
                description = description.Substring(0, Constants.MAX_DESCRIPTION_LENGTH);
            }

            UNSPSC = Global.checkUNSPSC(UNSPSC);

            ItemCard_Service itemCardService = new ItemCard_Service();
            ItemCard GSSPartNo = new ItemCard();

            itemCardService.UseDefaultCredentials = true;

            GSSPartNo.No = gssPartNum;
            GSSPartNo.Vendor_No = vendorName;
            GSSPartNo.Vendor_Item_No = vendorPartNum;
            GSSPartNo.Description = description;
            GSSPartNo.Description_2 = description2;
            GSSPartNo.UNSPSC_Code = UNSPSC;
            GSSPartNo.Unit_Price = Convert.ToDecimal(unitPrice);
            GSSPartNo.Unit_PriceSpecified = true;
            GSSPartNo.Base_Unit_of_Measure = uom;
            GSSPartNo.Gen_Prod_Posting_Group_2 = "SUP";
            GSSPartNo.Inventory_Posting_Group_2 = "SUP";
            GSSPartNo.Tax_Group_Code_2 = "INV";

            itemCardService.Create(ref GSSPartNo);
        }

        public static string CheckShipToAddress(Address shipToAddress, OrderHeader order)
        {
            string addressID = Database.GetAddressID(shipToAddress, order.navSellToCustomerNo);

            if (addressID.Length > 0)
            {
                ShipToAddress_Service shipToService = new ShipToAddress_Service();
                ShipToAddress shipTo = new ShipToAddress();
                shipToService.UseDefaultCredentials = true;

                shipTo = shipToService.Read(order.navSellToCustomerNo, addressID);

                if (shipTo == null)
                {
                    shipTo = new ShipToAddress();
                    shipTo.Customer_No = order.navSellToCustomerNo;
                    shipTo.Code = addressID;
                    shipTo.Customer_Address_ID = shipToAddress.AddressID;
                    shipTo.Name = Global.CutOff(shipToAddress.Name, Constants.MAX_NAME_LENGTH).ToUpper();
                    shipTo.Address = Global.ReturnListStringItem(shipToAddress.Streets, 0).ToUpper();
                    shipTo.Address_2 = Global.ReturnListStringItem(shipToAddress.Streets, 1).ToUpper();
                    shipTo.City = shipToAddress.City.ToUpper();
                    shipTo.Post_Code = shipToAddress.PostalCode;
                    shipTo.Contact = "";

                    shipTo.County = shipToAddress.State.ToUpper();
                    shipTo.Country_Region_Code = "US";
                    shipTo.Location_Code = "VA";

                    if (order.taxCharged > 0.0M)
                    {
                        shipTo.Tax_LiableSpecified = true;
                        shipTo.Tax_Liable = true;
                        shipTo.Tax_Area_Code = Database.GetTaxAreaCode(shipToAddress.City, shipToAddress.State, "VA");
                    }

                    shipToService.Create(ref shipTo);
                }
            }

            return addressID;
        }

        public static int CheckNavisionContact(string NavFriendlyName, OrderHeader order)
        {
            int contactID = 0;
            /* ########################## Populate Contact ID ##################### */

            CxmlCustomerName contactName = Global.GetContactNames(NavFriendlyName);
            CxmlCustomerPhone contactPhone = Global.GetPhoneNumber(order.ShipToAddress.Phone.AreaCode, order.ShipToAddress.Phone.Number);

            CustomerContact_Service cusCardService = new CustomerContact_Service();

            cusCardService.UseDefaultCredentials = true;

            contactID = CheckNavisionContact(cusCardService, contactName, order.ShipToAddress.EmailAddress, order.navSellToCustomerNo);

            //  output("reading customer card" + navSellToCustomerNo +" "+ NavFriendlyName + "\r\n");
            if (contactID == 0)
            {
                CustomerContact cusCard = new CustomerContact();
                cusCard = new CustomerContact();
                cusCard.Sell_to_Customer_No = order.navSellToCustomerNo;
                cusCard.Prefix = contactName.Prefix;
                cusCard.First_Name = contactName.FirstName;
                cusCard.Last_Name = contactName.LastName;
                cusCard.Middle_Name = contactName.MiddleName;
                cusCard.Suffix = contactName.Suffix;

                if (contactPhone.InternationalPhoneNumber.Length > 0)
                    cusCard.International_Phone_Number = contactPhone.InternationalPhoneNumber;
                else
                {
                    cusCard.US_Area_Code = contactPhone.AreaCode.ToString();
                    cusCard.Phone_Prefix = contactPhone.Prefix.ToString();
                    cusCard.Number = contactPhone.Number.ToString();
                }

                if (order.navSellToCustomerNo == "BATTELLE COLUMBUS")
                {
                    bool isemail = false;
                    string name = NavFriendlyName.Replace(",", " ");
                    string[] namearray = name.Split(' ');
                    foreach (string n in namearray)
                        if (n.Length > 1 && order.ShipToAddress.EmailAddress.Contains(n))
                            isemail = true;

                    if (isemail)
                        cusCard.Contact_E_Mail = order.ShipToAddress.EmailAddress;
                    else
                        cusCard.Contact_E_Mail = "emailnotfound@govsci.com";
                }
                else if (order.ShipToAddress.EmailAddress.Length == 0)
                    cusCard.Contact_E_Mail = "emailnotfound@govsci.com";
                else
                    cusCard.Contact_E_Mail = order.ShipToAddress.EmailAddress;

                cusCardService.Create(ref cusCard);

                contactID = CheckNavisionContact(cusCardService, contactName, order.ShipToAddress.EmailAddress, order.navSellToCustomerNo);
            }

            return contactID;
        }

        public static int CheckNavisionContact(CustomerContact_Service cusCardService, CxmlCustomerName contactName, string shipToEmail, string navSelltoCustomerNo)
        {
            int contactID = 0;

            CustomerContact_Filter sellToCustomerNoFilter = new CustomerContact_Filter();
            sellToCustomerNoFilter.Field = CustomerContact_Fields.Sell_to_Customer_No;
            sellToCustomerNoFilter.Criteria = navSelltoCustomerNo;

            CustomerContact_Filter firstNameFilter = new CustomerContact_Filter();
            firstNameFilter.Field = CustomerContact_Fields.First_Name;
            firstNameFilter.Criteria = contactName.FirstName;

            CustomerContact_Filter lastNameFilter = new CustomerContact_Filter();
            lastNameFilter.Field = CustomerContact_Fields.Last_Name;
            lastNameFilter.Criteria = contactName.LastName;

            CustomerContact_Filter emailFilter = new CustomerContact_Filter();
            emailFilter.Field = CustomerContact_Fields.Contact_E_Mail;
            emailFilter.Criteria = shipToEmail;

            CustomerContact_Filter[] filters = new CustomerContact_Filter[]
            {
                sellToCustomerNoFilter,
                firstNameFilter,
                lastNameFilter,
                emailFilter
            };
            CustomerContact[] contacts = cusCardService.ReadMultiple(filters, null, 0);

            if (contacts.Length > 0)
                contactID = contacts[0].Contact_ID;

            return contactID;
        }

        public static void CheckCreditCard(OrderHeader order)
        {
            CustomerCreditCards_Service creditCardService = new CustomerCreditCards_Service();
            creditCardService.UseDefaultCredentials = true;

            CustomerCreditCards_Filter noFilter = new CustomerCreditCards_Filter();
            noFilter.Field = CustomerCreditCards_Fields.No;
            noFilter.Criteria = order.navSellToCustomerNo;

            CustomerCreditCards_Filter accountNumberFilter = new CustomerCreditCards_Filter();
            accountNumberFilter.Field = CustomerCreditCards_Fields.Account_Number;
            accountNumberFilter.Criteria = "*" + order.PCard.Number.Substring(order.PCard.Number.Length - 4);

            CustomerCreditCards_Filter expirationMonthFilter = new CustomerCreditCards_Filter();
            expirationMonthFilter.Field = CustomerCreditCards_Fields.Expiration_Month;
            expirationMonthFilter.Criteria = DateTime.Parse(order.PCard.Expiration).ToString("MM");

            CustomerCreditCards_Filter expirationYearFilter = new CustomerCreditCards_Filter();
            expirationYearFilter.Field = CustomerCreditCards_Fields.Expiration_Year;
            expirationYearFilter.Criteria = DateTime.Parse(order.PCard.Expiration).ToString("yy");

            CustomerCreditCards_Filter descriptionFilter = new CustomerCreditCards_Filter();
            descriptionFilter.Field = CustomerCreditCards_Fields.Description;
            descriptionFilter.Criteria = order.PCard.Name;

            CustomerCreditCards_Filter[] filters = new CustomerCreditCards_Filter[] { noFilter, accountNumberFilter, expirationMonthFilter, expirationYearFilter, descriptionFilter };

            CustomerCreditCards[] cards = creditCardService.ReadMultiple(filters, null, 0);

            if (cards == null || cards.Count() == 0)
            {
                CustomerCreditCards card = new CustomerCreditCards();

                card.Link_TypeSpecified = true;
                card.Link_Type = Link_Type.Customer;
                card.No = order.navSellToCustomerNo;
                card.Account_Number = order.PCard.Number;
                card.Expiration_Month = DateTime.Parse(order.PCard.Expiration).ToString("MM");
                card.Expiration_Year = DateTime.Parse(order.PCard.Expiration).ToString("yy");
                card.Bill_to_Name = order.PCard.Name;
                card.Description = order.PCard.Name;
                card.Card_Type = Card_Type.Purchasing;

                creditCardService.Create(ref card);
                creditCardService.Update(ref card);
            }
        }

        public static string CreateSalesOrder(OrderHeader order, bool creditCardFailed)
        {
            string salesOrderNo = "";

            List<Sales_Order_Line> SalesLineCollection = new List<Sales_Order_Line>();
            string trackingNumbers = "";

            foreach (OrderLine line in order.Lines)
            {
                Sales_Order_Line salesLine = new Sales_Order_Line();

                if (order.navSellToCustomerNo == "SANDIA NATIONAL LABS")
                    salesLine.Notes = line.extra;
                salesLine.TypeSpecified = true;

                if (line.manufacturerName == "SHIPPING" || line.supplierPartID.ToUpper().StartsWith("GSSTRANS"))     // Another exception caused by Niyati at SLAC
                {
                    salesLine.QuantitySpecified = true;
                    salesLine.Unit_PriceSpecified = true;
                    salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                    salesLine.Description = line.description;
                    salesLine.Quantity = line.quantity;
                    salesLine.Unit_Price = line.unitPrice;

                    switch (line.supplierPartID)
                    {
                        /*case "GSSTRANS": salesLine.No = functions.NAVISION_SHIPPING_GLCODE; break;
                        case "GSSTRANSDIGIKEY": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSTHORLABS": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSNEWPORT": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSWESTERNTOOL": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSPACIFICCOMPU": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSDIBERT": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSOFFICERELIEF": salesLine.No = functions.NAVISION_SHIPPING_GLCODE_PREPAY; break;*/

                        case "GSSTRANSSLACOWN": salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_PREPAY; break;
                        case "GSSTRANSSLACTAX": salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_FEDERAL_EXCISE_TAX; break;
                        default:
                            if (line.description.ToUpper().Contains("UNISON"))
                                salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_UNISON;
                            else if (line.unitPrice > 1.00M)
                                salesLine.No = Constants.NAVISION_SHIPPING_GLCODE;
                            else
                                salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_PREPAY;
                            break;
                    }

                }
                else
                {
                    salesLine.Type = WS_SalesOrder.Type.Item;
                    salesLine.QuantitySpecified = true;
                    salesLine.Unit_PriceSpecified = true;

                    salesLine.No = line.gssPartNumber;

                    decimal unitCost = 0.0M;

                    if (line.unitCostStr.Length > 0 && decimal.TryParse(line.unitCostStr, out unitCost))
                        unitCost = decimal.Parse(line.unitCostStr);
                    else
                        unitCost = Database.CalculateUnitCost(order.navSellToCustomerNo, line.vendorCode, Convert.ToDecimal(line.unitPrice));

                    if (unitCost > 0.00M)
                    {
                        salesLine.Unit_Cost_LCYSpecified = true;
                        salesLine.Unit_Cost_LCY = unitCost;
                    }

                    switch (order.navSellToCustomerNo)
                    {
                        case "SLAC CHEMICAL":
                            salesLine.Barcode_ReqSpecified = true;
                            salesLine.Barcode_Req = true;
                            salesLine.Location_Code = "CA";
                            break;
                        case "SLAC":
                            salesLine.Location_Code = "CA";
                            break;
                        case "BERKELEY":
                            salesLine.Location_Code = "CA";
                            if (line.gssPartNumber.StartsWith("GWZ") || line.gssPartNumber.StartsWith("DLC"))
                            {
                                salesLine.Tracking_No = line.supplierPartAuxiliaryID;
                                if (!trackingNumbers.Contains(line.supplierPartAuxiliaryID))
                                    trackingNumbers += $"{line.supplierPartAuxiliaryID}; ";
                            }
                            break;
                        case "OAK RIDGE NTL LAB":
                            salesLine.Barcode_ReqSpecified = true;
                            salesLine.Barcode_Req = true;
                            salesLine.Location_Code = "TN";
                            break;
                        case "LOS ALAMOS NNSA":
                            salesLine.Location_Code = "NM";
                            break;
                        default:
                            salesLine.Location_Code = "VA";
                            break;
                    }

                    if (line.requestedDeliveryDate.Date != Constants.NAVISION_DEFAULT_DATETIME_VALUE.Date)
                    {
                        salesLine.Requested_Delivery_DateSpecified = true;
                        salesLine.Requested_Delivery_Date = Convert.ToDateTime(line.requestedDeliveryDate);
                    }
                    else if (order.navSellToCustomerNo == "RICHLAND")
                    {
                        salesLine.Requested_Delivery_DateSpecified = true;
                        salesLine.Requested_Delivery_Date = DateTime.Now.AddDays(7).Date;
                    }

                    salesLine.Unit_of_Measure_Code = line.unitOfMeasure;
                    salesLine.Quantity = line.quantity;
                    salesLine.Unit_Price = line.unitPrice;

                    if (line.altNumber.Length > 0)
                        salesLine.Alt_Vendor_Name_No = line.altNumber;

                    string descr1 = "", descr2 = "";
                    if (line.description.Length > 50)
                    {
                        descr1 = line.description.Substring(0, 50);
                        descr2 = line.description.Substring(50);

                        if (descr2.Length > 50)
                            descr2 = descr2.Remove(47) + "...";
                    }
                    else
                        descr1 = line.description;

                    salesLine.Description = descr1;
                    salesLine.Description_2 = descr2;
                }

                SalesLineCollection.Add(salesLine);

                if (line.gssPartNumber.Contains("SYSTEMGEN"))
                {
                    string systemGenComment = "MAP:" + line.supplierPartID + " to " + line.gssPartNumber;

                    while (systemGenComment.Length >= Constants.MAX_DESCRIPTION_LENGTH * 2)
                    {
                        salesLine = new Sales_Order_Line();
                        salesLine.TypeSpecified = true;
                        salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                        salesLine.Description = systemGenComment.Substring(0, Constants.MAX_DESCRIPTION_LENGTH);
                        systemGenComment = systemGenComment.Substring(Constants.MAX_DESCRIPTION_LENGTH, systemGenComment.Length - Constants.MAX_DESCRIPTION_LENGTH);
                        salesLine.Description_2 = systemGenComment.Substring(0, Constants.MAX_DESCRIPTION_LENGTH);
                        systemGenComment = systemGenComment.Substring(Constants.MAX_DESCRIPTION_LENGTH, systemGenComment.Length - Constants.MAX_DESCRIPTION_LENGTH);
                        SalesLineCollection.Add(salesLine);
                    }

                    if (systemGenComment.Length > Constants.MAX_DESCRIPTION_LENGTH)
                    {
                        salesLine = new Sales_Order_Line();
                        salesLine.TypeSpecified = true;
                        salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                        salesLine.Description = systemGenComment.Substring(0, Constants.MAX_DESCRIPTION_LENGTH);
                        systemGenComment = systemGenComment.Substring(Constants.MAX_DESCRIPTION_LENGTH, systemGenComment.Length - Constants.MAX_DESCRIPTION_LENGTH);
                        salesLine.Description_2 = systemGenComment.Substring(0, Math.Min(systemGenComment.Length, Constants.MAX_DESCRIPTION_LENGTH));
                        SalesLineCollection.Add(salesLine);
                    }
                    else if (systemGenComment.Length > 1 && systemGenComment.Length <= Constants.MAX_DESCRIPTION_LENGTH)
                    {
                        salesLine = new Sales_Order_Line();
                        salesLine.TypeSpecified = true;
                        salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                        salesLine.Description = systemGenComment.Substring(0, Math.Min(systemGenComment.Length, Constants.MAX_DESCRIPTION_LENGTH));
                        SalesLineCollection.Add(salesLine);
                    }
                }
            }

            if (order.quoteNumber.Length > 0)
                order.quoteNumber = order.quoteNumber.Remove(order.quoteNumber.LastIndexOf('|'));

            if (order.extrinsicOptions == 1)
            {
                Sales_Order_Line salesLine = new Sales_Order_Line();
                salesLine.TypeSpecified = true;
                salesLine.QuantitySpecified = true;
                salesLine.Unit_PriceSpecified = true;
                salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_PREPAY;
                salesLine.Description = "Expedite Shipping Charge";
                salesLine.Quantity = 1;
                salesLine.Unit_Price = 1.00M;
                SalesLineCollection.Add(salesLine);
            }

            // ################################# Build comments in navision sales line #####################################
            if (order.comments != "")
            {
                if (order.comments == "Overnight Shipping")
                {
                    Sales_Order_Line salesLine = new Sales_Order_Line();
                    salesLine.TypeSpecified = true;
                    salesLine.QuantitySpecified = true;
                    salesLine.Unit_PriceSpecified = true;
                    salesLine.Type = WS_SalesOrder.Type.G_L_Account;
                    salesLine.No = Constants.NAVISION_SHIPPING_GLCODE_PREPAY;
                    salesLine.Description = "Overnight Shipping";
                    salesLine.Quantity = 1;
                    salesLine.Unit_Price = 1.00M;
                    SalesLineCollection.Add(salesLine);
                }
            }

            SalesOrder_Service salesOrderService = new SalesOrder_Service();
            SalesOrder s = new SalesOrder();

            salesOrderService.UseDefaultCredentials = true;
            salesOrderService.Create(ref s);

            if (order.notes.Length > 0)
                s.Notes = order.notes;

            if (trackingNumbers.Length > 0)
            {
                trackingNumbers = trackingNumbers.Remove(trackingNumbers.LastIndexOf(";"));
                if (trackingNumbers.Length > 100) trackingNumbers = trackingNumbers.Remove(100);
                s.Notes = trackingNumbers;
            }

            s.Sell_to_Customer_No = order.navSellToCustomerNo;
            if (order.navSalesTeamColor.Length > 0)
                s.Sales_Team = order.navSalesTeamColor;

            if (order.BillToAddress.Contact_ID > 0)
                s.Contact_ID = order.BillToAddress.Contact_ID;
            else
                s.Contact_ID = order.ShipToAddress.Contact_ID;

            if (order.navSellToCustomerNo == "OAK RIDGE NTL LAB")
                s.Sell_to_Customer_Name = Global.CutOff(order.ShipToAddress.Name, 50);
            else
                s.Sell_to_Customer_Name = Global.CutOff(order.BillToAddress.Name, 50);

            order.orderID = Global.CheckOrderID(order.orderID);

            s.eStore_Order_No = s.External_Document_No = s.Your_Reference = order.orderID;
            if (order.customerPoNo.Length > 0)
                s.Your_Reference = order.customerPoNo;

            if (order.quoteNumber.Length > 20) order.quoteNumber = order.quoteNumber.Substring(0, 20);
            s.Quote_No = order.quoteNumber;

            if (order.purchReqNumber.Length > 0)
                s.External_Document_No = order.purchReqNumber;

            if (s.Sell_to_Customer_No == "ARGONNE AMOS")
                s.eStore_Order_No = s.External_Document_No = order.payloadID;
            else if (s.Sell_to_Customer_No == "RICHLAND")
            {
                s.Credit_Card_Invoice_TransmitSpecified = true;
                s.Credit_Card_Invoice_Transmit = Credit_Card_Invoice_Transmit.No_Invoice;
            }

            string shipToLocationCode = "VA";

            s = buildShipToAddress(s, order, shipToLocationCode);

            // UPDATE BARCODE NUMBER TO THE CORRECT ONES
            //if (navSellToCustomerNo == "SLAC CHEMICAL") SalesLineCollection = functions.GenerateBarCode("SLAC CHEMICAL", SalesLineCollection);

            if (order.navSellToCustomerNo == "SLAC CHEMICAL" || order.navSellToCustomerNo == "OAK RIDGE NTL LAB")
            {
                s.Barcodes_ReqSpecified = true;
                s.Barcodes_Req = true;
            }

            if (order.requestedDeliveryDate.Date != Constants.NAVISION_DEFAULT_DATETIME_VALUE.Date)
            {
                s.Requested_Delivery_DateSpecified = true;
                s.Requested_Delivery_Date = order.requestedDeliveryDate.Date;
            }

            s.SalesLines = new Sales_Order_Line[SalesLineCollection.Count];
            for (int i = 0; i < SalesLineCollection.Count; i++)
                s.SalesLines[i] = SalesLineCollection[i];

            if (order.bpaNumber.Length > 0) s.BPA_No = order.bpaNumber;

            salesOrderService.Update(ref s);

            if (order.PCard.Number.Length > 0 && !creditCardFailed)
            {
                s.Payment_Terms_Code = "CR CARD";
                s.Payment_Method_Code = "CREDITCARD";

                salesOrderService.Update(ref s);

                s.Account_Number = order.PCard.Number;
            }

            salesOrderService.Update(ref s);

            salesOrderService.Dispose();

            salesOrderNo = s.No;

            if (order.navSellToCustomerNo == "C10366")
            {
                s.Automate_Confirmation = true;
                Database.UpdateEcat(salesOrderNo, order.orderID);
            }

            try
            {
                int lineNo = 10000;
                int pos = 0;
                foreach (OrderLine line in order.Lines)
                {
                    decimal unitCost = decimal.Parse(line.unitCostStr);
                    if (s.SalesLines[pos] != null && (s.SalesLines[pos].Unit_Price != line.unitPrice || s.SalesLines[pos].Unit_Cost_LCY != unitCost))
                        Database.UpdateSalesOrderLine(line, unitCost, lineNo, s.No);
                    lineNo += 10000;
                    pos++;
                }
            }
            catch { }

            if (order.PCard.Number.Length > 0 && !creditCardFailed)
                Database.UpdateSalesOrderCreditCard(order, salesOrderNo);

            return salesOrderNo;
        }

        public static SalesOrder buildShipToAddress(SalesOrder s
            , OrderHeader order
            , string shipToLocation)
        {
            if (order.navSellToCustomerNo == "SLAC" || order.navSellToCustomerNo == "SLAC CHEMICAL")
            {
                shipToLocation = "CA";

                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength("eBuyer " + order.ShipToAddress.Contact, 50);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + "eBuyer " + order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "OAK RIDGE NTL LAB")
            {
                shipToLocation = "TN";

                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = "";
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;

            }
            else if (order.navSellToCustomerNo == "BERKELEY")
            {
                shipToLocation = "CA";
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength(Global.ReturnListStringItem(order.ShipToAddress.Streets,0), 50);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + "eBuyer " + order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "ARGONNE AMOS")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = "ATTN: " + Global.CheckLength(order.ShipToAddress.Contact, 44);
                s.Ship_to_Contact = Global.CheckLength(order.orderID, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "JEFFERSON SCIENCE")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength(order.ShipToAddress.Name, 50);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "LLNL SHOP STOCK" || order.navSellToCustomerNo == "LLNL EOS")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength(Global.ReturnListStringItem(order.ShipToAddress.Streets,1), 50);
                s.Ship_to_Contact = Global.CheckLength(order.ShipToAddress.DeliverTo, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "RICHLAND")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength(order.orderID, 50);
                s.Ship_to_Contact = Global.CheckLength(order.ShipToAddress.DeliverTo, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "C10366")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Name_2 = Global.CheckLength(order.orderID, 50);
                s.Ship_to_Contact = Global.CheckLength(Database.GetEcatTCN(order.orderID), 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "LOS ALAMOS NNSA")
            {
                shipToLocation = "NM";
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;
            }
            else if (order.navSellToCustomerNo == "C14139")
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + order.ShipToAddress.Contact, 50);
                s.Ship_to_Name_2 = Global.CheckLength(order.orderID, 50);
                s.Location_Code = shipToLocation;
            }
            else
            {
                s.Ship_to_Code = Global.CheckLength(order.ShipToAddress.AddressID, 30);
                s.Ship_to_Contact = Global.CheckLength(order.orderID + "/" + order.ShipToAddress.Contact, 50);
                s.Ship_to_Name_2 = Global.CheckLength(order.ShipToAddress.Contact, 50);
                s.Location_Code = shipToLocation;
            }

            return s;
        }

        public static void UpdatePurchaseOrder(string documentNo, bool sent)
        {
            try
            {
                AutoPostDocument auto = new AutoPostDocument();
                auto.UseDefaultCredentials = true;

                auto.UpdateBizStatusPO(documentNo, DateTime.Now, DateTime.Now, sent ? "SENT" : "FAILED");
            }
            catch { }
        }
    }
}
