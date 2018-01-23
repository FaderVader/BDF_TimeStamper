using System;
using System.IO;
using System.Xml.Linq;

namespace TimeStamper
{
    public class Process
    {
        public string PathToXml;
        public string xmlSource;
        public string xmlTarget;
      
        public DateTime Date;
        public int Hour;
        public int Minutes;

        XDocument inDocument;
        XDocument outDocument; 

        public void ModifyTimeStamp(DateTime date, int hour, int minutes, string pathToXml)
        {
            Date = date.ChangeDate(hour, minutes);
            PathToXml = pathToXml;
            Hour = hour;
            Minutes = minutes;

            string time4blocks = Hour.ToString() + ":" + Minutes.ToString() + ":00:00";
            string time1block = Hour.ToString() + Minutes.ToString() + "00000";
            string dateYearMonthDay = Date.ToString("yyyy") + "-" + Date.ToString("MM") + "-" + Date.ToString("dd");

            string bdfTimeStampUTC = dateYearMonthDay + "T" + Date.TimeOfDay + "+00:00";
            string bdfTimestamp = dateYearMonthDay + "T" + Date.TimeOfDay + "00000+00:00";           

            inDocument = XDocument.Load(PathToXml);
            XElement body = inDocument.Element("OdfBody");
            XElement log = body.Element("Log");
           
            body.Attribute("BDFTimeStampUTC").Value = bdfTimeStampUTC;                   //BDFTimeStampUTC="2017-11-15T21:06:22+09:00" // date.ToUniversalTime().ToString()
            body.Attribute("BDFTimestamp").Value = bdfTimestamp;                         // BDFTimestamp="2017-12-15T16:44:07.2103067+09:00""
            body.Attribute("Date").Value = dateYearMonthDay ;                            // Date="2017-11-15"
            body.Attribute("Time").Value = time1block;                                   // Time = "210602218"
            body.Attribute("LogicalDate").Value = dateYearMonthDay;                      // LogicalDate="2012-07-28"

            log.Element("Date").Value = dateYearMonthDay;  // 2017-12-15
            log.Element("TimeCode").Value = time4blocks;  //16:44:07:21

            outDocument = new XDocument(new XDeclaration("1.0", "UTF-8", null));
            xmlSource = Path.GetFileName(PathToXml);
            xmlTarget = Properties.Settings.Default.OutputDirectory + xmlSource;

            outDocument.Add(body);
            outDocument.Save(xmlTarget);      
        }        
    }
}
