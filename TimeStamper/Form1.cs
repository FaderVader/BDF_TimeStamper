using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeStamper
{
    public partial class Form1 : Form
    {
        public string PathToXmlFile;

        public DateTime newDate;
        public int hour;
        public int minutes;
        FileDialog dialog;
        Process process;

        public Form1()
        {
            InitializeComponent();
            dialog = new OpenFileDialog();
            process = new Process();
            PathToXmlFile = "";
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {            
            dialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK) { PathToXmlFile = dialog.FileName; txtPathToXml.Text = PathToXmlFile; }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (dialog.FileName.Length > 0)
            {
                // acquire values of Date, Hour and Minutes varibles from UI
                // call to xml-reader, process file and output to new file.
               
                Int32.TryParse(nudHours.Value.ToString(), out hour);
                Int32.TryParse(nudMinutes.Value.ToString(), out minutes);
                
                newDate = datePicker.Value.ChangeDate(hour, minutes);

                process.ModifyTimeStamp(newDate, PathToXmlFile); 

            }
        }
    }
}
