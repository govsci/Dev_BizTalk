using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizTalkLibrary.Objects;
using System.Xml;


namespace BizTalkLibrary.Classes
{
    public class ERP_Item_Functions
    {
        public static void cXMLtoNavisionItemTable(XmlDocument cXML)
        {
            Constants.F1 setValue = x => x == null ? "" : x.InnerXml.Replace("'", "''");

            XmlNodeList lines = cXML.SelectNodes("//ItemOut");

            string partNumber, secondlyPartNumber, description, price, UM, UNSPSC, mfcName, vendorCode, unitOfMeasure;

            foreach (XmlNode i in lines)
            {
                partNumber = setValue(i.SelectSingleNode("ItemID/SupplierPartID"));
                secondlyPartNumber = setValue(i.SelectSingleNode("ItemID/SupplierPartAuxiliaryID"));
                description = setValue(i.SelectSingleNode("ItemDetail/Description"));
                price = setValue(i.SelectSingleNode("ItemDetail/UnitPrice/Money"));

                partNumber = Global.RemoveStrings(partNumber);
                secondlyPartNumber = Global.RemoveStrings(secondlyPartNumber);

                // ##################### Unit of measure convertion ####################### //
                UM = setValue(i.SelectSingleNode("ItemDetail/UnitOfMeasure"));

                UNSPSC = setValue(i.SelectSingleNode("ItemDetail/Classification"));
                mfcName = setValue(i.SelectSingleNode("ItemDetail/ManufacturerName"));
                mfcName = Database.GetVendorName(mfcName);
                vendorCode = Database.GetVendorCode(mfcName);
                unitOfMeasure = NormalizeUOM(partNumber, UM, vendorCode);

                string altNumber = "";

                if (ValidateGSSPartNum(partNumber, unitOfMeasure, vendorCode) == "FALSE" && mfcName != "MARKETBASKET")
                    ERP_Web_Service_Functions.insertNewItems(vendorCode, findGSSPartnumber(partNumber, UM, secondlyPartNumber, ref altNumber, vendorCode), description, unitOfMeasure, price, partNumber, UNSPSC);
            }

        }

        public static string ValidateGSSPartNum(string vendorPartNum, string unitOfMeasure, string navVendorID)
        {
            string returnValue;
            if (navVendorID == "GSS") // if order is direct line order , bypass the verification, return true 
                returnValue = "TRUE";
            else if (navVendorID == "SHIPPING")
                returnValue = "TRUE";
            else if (navVendorID != "")
                returnValue = Database.ValidateGssPartNumber(vendorPartNum, unitOfMeasure, navVendorID);
            else	// if mfcName is not provided(exception), return True, so the system can ignore the error.
                returnValue = "TRUE";

            return returnValue;
        }

        public static string NormalizeUOM(string vendorPartNum, string UM, string navVendorID)
        {
            string uom;

            switch (navVendorID)
            {
                case "SIG":
                    uom = "EA";
                    string queryPartNum = vendorPartNum.IndexOf("SIG") == 0 ? vendorPartNum.Replace("SIG", "") : vendorPartNum;
                    uom = Database.GetSigmaUnitOfMeasure(queryPartNum, UM);
                    break;

                default:
                    uom = Database.GetUnitOfMeasure(navVendorID, vendorPartNum, UM);
                    break;
            }
            /* ############# oddball human exception list ############## */
            switch (vendorPartNum)
            {
                case "SES769204BX": uom = "PK"; break;
            }

            if (UM == "EAC") uom = "EA";

            return uom;
        }

        public static string findGSSPartnumber(string vendorPartNum, string unitOfMeasure, string secondlyPartNumber, ref string altNumber, string navVendorID)
        {
            if (navVendorID == "GSS")	// if order is direct catalog order 
            {
                return vendorPartNum;
            }
            else if (navVendorID == "MARKETBASKET")
                return secondlyPartNumber;
            else if (navVendorID != "")
                return generateGSSPartnumber(vendorPartNum, navVendorID, unitOfMeasure, ref altNumber);
            else // unknown error at this moment
                return vendorPartNum;
        }

        public static string generateGSSPartnumber(string vendorPartNum, string navVendorID, string UM, ref string altNumber)
        {
            string gssPartNum = "";

            if (navVendorID == "SIG" || navVendorID == "SIGMA" || navVendorID == "SIAL")
            {
                if (vendorPartNum.Length > Constants.MAX_PARTNUMBER_LENGTH)
                {
                    gssPartNum = Database.ValidateGssPartNumber(vendorPartNum, UM, navVendorID);

                    if (gssPartNum == "FALSE")
                    {
                        gssPartNum = Database.getShortGSSPartNumber(vendorPartNum);
                        gssPartNum = navVendorID + gssPartNum + UM;
                    }
                }
                else
                {
                    /*	##############################################################################################
                        #######		Check generated Sigma Part Number against Navision Item table				######
                        #######		Updated Nov. 05. 2016                                            			######
                        #######     Swapping unit of measure code                                               ######
                        ############################################################################################## */
                    Database.GetSigmaGssPartNumber(vendorPartNum, UM, ref gssPartNum, ref altNumber);

                    if (gssPartNum == "")
                        gssPartNum = navVendorID + vendorPartNum;
                }
            }
            else
            {
                gssPartNum = Database.ValidateGssPartNumber(vendorPartNum, UM, navVendorID);
                if (gssPartNum == "FALSE")
                {
                    if (vendorPartNum.Length > Constants.MAX_PARTNUMBER_LENGTH)
                    {
                        gssPartNum = Database.getShortGSSPartNumber(vendorPartNum);
                        gssPartNum = navVendorID + gssPartNum + UM;
                    }
                    else
                        gssPartNum = navVendorID + vendorPartNum + UM;
                }
            }

            return gssPartNum;
        }
    }
}
