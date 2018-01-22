using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeStamper
{
    public static class Process
    {
        public static string xmlSource;
        public static string xmlTarget;
        public static string PathToXml;
        public static int Hour;
        public static int Minutes;

        public static  void RecieveData(DateTime date, int hour, int minutes, string pathToXml)
        {
            PathToXml = pathToXml;
            Hour = hour;
            Minutes = minutes;

            MessageBox.Show(PathToXml);
        }
    }
}
