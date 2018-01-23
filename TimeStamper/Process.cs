using System;
using System.Xml.Linq;

namespace TimeStamper
{
    public class Process
    {
        public string xmlSource;
        public string xmlTarget;
        public string PathToXml;
        public DateTime Date;
        public int Hour;
        public int Minutes;

        public string oldDate;
        public string oldTimeCode;
        XDocument inDocument;
        XDocument outDocument = new XDocument(new XDeclaration("1.0", "UTF-8", null));

        public void ModifyTimeStamp(DateTime date, int hour, int minutes, string pathToXml)
        {
            Date = date.ChangeDate(hour, minutes);
            PathToXml = pathToXml;
            Hour = hour;
            Minutes = minutes;

            
            string time4blocks = hour.ToString() + ":" + minutes.ToString() + ":00:00";
            string time1block = hour.ToString() + minutes.ToString() + "00000";
            string dateYourMonthDay = Date.ToString("yyyy") + "-" + Date.ToString("MM") + "-" + Date.ToString("dd"); // .Year    .Month   .Day

            // create string for BDFTimeStampUTC
            string bdfTimeStampUTC = dateYourMonthDay + "T" + Date.TimeOfDay + "+00:00";

            // create string for BDFTimestamp
            string bdfTimestamp = dateYourMonthDay + "T" + Date.TimeOfDay + "00000+00:00";

            inDocument = XDocument.Load(PathToXml);
            XElement body = inDocument.Element("OdfBody");
            XElement log = body.Element("Log");

            //update OdfBody
            body.Attribute("BDFTimeStampUTC").Value = bdfTimeStampUTC;                   //BDFTimeStampUTC="2017-11-15T21:06:22+09:00" // date.ToUniversalTime().ToString()
            body.Attribute("BDFTimestamp").Value = bdfTimestamp;                         // BDFTimestamp="2017-12-15T16:44:07.2103067+09:00""
            body.Attribute("Date").Value = dateYourMonthDay ;                            // Date="2017-11-15"
            body.Attribute("Time").Value = time1block;                                   // Time = "210602218"
            body.Attribute("LogicalDate").Value = dateYourMonthDay;                      // LogicalDate="2012-07-28"


            log.Element("Date").Value = dateYourMonthDay;  // 2017-12-15
            log.Element("TimeCode").Value = time4blocks;  //16:44:07:21


            outDocument.Add(body);
            outDocument.Save(@"C:\temp\outDocument.xml");      
        }        
    }
}
