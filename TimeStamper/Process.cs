using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TimeStamper
{
    public class Process
    {
        #region field initializers
        string PathToXml;
        string xmlSource;
        string xmlTarget;

        DateTime Date;
        int Hour;
        int Minutes;

        XDocument inDocument;
        XDocument outDocument;
        XElement body;
        XElement log; 
        #endregion

        public void ModifyTimeStamp(DateTime date, int hour, int minutes, string pathToXml)
        {
            Date = date.ChangeDate(hour, minutes);
            PathToXml = pathToXml;
            Hour = hour;
            Minutes = minutes;

            xmlSource = Path.GetFileName(PathToXml);
            xmlTarget = Properties.Settings.Default.OutputDirectory + xmlSource;

            string time4blocks = Hour.ToString() + ":" + Minutes.ToString() + ":00:00";
            string time1block = Hour.ToString() + Minutes.ToString() + "00000";
            string dateYearMonthDay = Date.ToString("yyyy") + "-" + Date.ToString("MM") + "-" + Date.ToString("dd");

            string bdfTimeStampUTC = dateYearMonthDay + "T" + Date.TimeOfDay + "+00:00";
            string bdfTimestamp = dateYearMonthDay + "T" + Date.TimeOfDay + "00000+00:00";

            LoadXml();

            ChangeValues(time4blocks, time1block, dateYearMonthDay, bdfTimeStampUTC, bdfTimestamp);

            SaveXml();
        }
       
        private void LoadXml()
        {
            try
            {
                inDocument = XDocument.Load(PathToXml);
                body = inDocument.Element("OdfBody");
                log = body.Element("Log");
            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading xml-file: " + PathToXml);
            }
        }

        private void ChangeValues(string time4blocks, string time1block, string dateYearMonthDay, string bdfTimeStampUTC, string bdfTimestamp)
        {
            try
            {
                body.Attribute("BDFTimeStampUTC").Value = bdfTimeStampUTC;       //BDFTimeStampUTC="2017-11-15T21:06:22+09:00" // date.ToUniversalTime().ToString()
            }
            catch (Exception)
            {
                MessageBox.Show("Old version xml - TimeStampUTC not found!");
            }

            try
            {
                body.Attribute("BDFTimestamp").Value = bdfTimestamp;             // BDFTimestamp="2017-12-15T16:44:07.2103067+09:00""
                body.Attribute("Date").Value = dateYearMonthDay;                 // Date="2017-11-15"
                body.Attribute("Time").Value = time1block;                       // Time = "210602218"
                body.Attribute("LogicalDate").Value = dateYearMonthDay;          // LogicalDate="2012-07-28"

                log.Element("Date").Value = dateYearMonthDay;                    // 2017-12-15
                log.Element("TimeCode").Value = time4blocks;                     //16:44:07:21
            }
            catch (Exception e)
            {

                MessageBox.Show("Error while changing values in XML-file: " + e.Message);
            }
        }

        private void SaveXml()
        {
            try
            {
                outDocument = new XDocument(new XDeclaration("1.0", "UTF-8", null));
                outDocument.Add(body);
                outDocument.Save(xmlTarget);

                MessageBox.Show("Filen blev gemt som: " + xmlTarget);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error While saving XML-file: " + e.Message);
            }
        }

    }
}
