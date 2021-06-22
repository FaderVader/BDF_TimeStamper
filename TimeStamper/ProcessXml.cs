using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TimeStamper
{
    public class ProcessXml
    {
        public void ModifyTimeStamp(DateTime newDate, string pathToXml, string channelId = "")
        {
            var sourceXml = GetXml(pathToXml);
            string updatedName = GenerateUpdatedFileName(newDate, sourceXml);
            XElement element = ChangeValues(newDate, sourceXml, channelId);

            SaveXml(updatedName, element);
        }

        private XElement GetXml(string pathToXml)
        {
            XDocument inDocument;
            XElement element = new XElement("empty");

            try
            {
                inDocument = XDocument.Load(pathToXml);
                element = inDocument.Element("OdfBody");
            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading xml-file: " + pathToXml);
                Application.Exit();
            }
            return element;
        }

        private XElement ChangeValues(DateTime date, XElement body, string channelId = "") 
        {
            XElement log = body.Element("Log");            

            string timeZone = Properties.Settings.Default.TimeZoneOffSet;

            string time4blocks = date.Hour.ToString() + ":" + date.Minute.ToString() + ":00:00";
            string time1block = date.Hour.ToString() + date.Minute.ToString() + "00000";
            string dateYearMonthDay = date.ToString("yyyy") + "-" + date.ToString("MM") + "-" + date.ToString("dd");
            string bdfTimestamp = dateYearMonthDay + "T" + date.TimeOfDay + $".0000000+{timeZone}";


            try
            {
                body.Attribute("BDFTimestamp").Value = bdfTimestamp;             // BDFTimestamp="2017-12-15T16:44:07.2103067+09:00""
                body.Attribute("Date").Value = dateYearMonthDay;                 // Date="2017-11-15"
                body.Attribute("Time").Value = time1block;                       // Time = "210602218"
                body.Attribute("LogicalDate").Value = dateYearMonthDay;          // LogicalDate="2012-07-28"

                body.Attribute("BDFChannelId").Value = channelId;                // BDFChannelIDd="DX09;MX03"

                log.Element("Date").Value = dateYearMonthDay;                    // 2017-12-15
                log.Element("TimeCode").Value = time4blocks;                     // 16:44:07:21
            }
            catch (Exception e)
            {
                MessageBox.Show("Error while changing values in XML-file: " + e.Message);
                Application.Exit();
            }
            return body;
        }

        private void SaveXml(string pathToXml, XElement element)
        {
            XDocument outDocument;           

            try
            {
                string xmlSource = Path.GetFileName(pathToXml);
                string xmlTarget = Properties.Settings.Default.OutputDirectory + xmlSource;

                outDocument = new XDocument(new XDeclaration("1.0", "UTF-8", null));
                outDocument.Add(element);
                outDocument.Save(xmlTarget);

                MessageBox.Show("Filen blev gemt som: " + xmlTarget);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error While saving XML-file: " + e.Message);
            }
        }

        private string GenerateUpdatedFileName(DateTime newDate, XElement sourceXml)
        {
            // name-template: 2018-02-14-14-00-00-015_OBS-------------------------------_OBS_BDF_VID_LOG_5649.xml
            string staticPart = Properties.Settings.Default.StaticNamePart;

            // set minimum length and pad if required
            string serial = sourceXml.Attribute("Serial").Value.PadLeft(5, '0');
            string version = sourceXml.Attribute("Version").Value.PadLeft(5, '0');            

            // format date-string
            string datePart = newDate.ToString("yyyyMMddHHmmssfff");
            string fileExt = ".xml";

            var sb = new StringBuilder();
            sb.Append(datePart);
            sb.Append("_");
            sb.Append(version);
            sb.Append("_");
            sb.Append(serial);
            sb.Append("_");
            sb.Append(staticPart);
            sb.Append(fileExt);

            return sb.ToString();
        }

    }
}
