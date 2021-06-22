using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TimeStamper
{
    public partial class TimeStamperGUI : Form
    {
        public string PathToXmlFile;

        public DateTime newDate;
        public int hour;
        public int minutes;
        FileDialog dialog;
        ProcessXml process;

        public TimeStamperGUI()
        {
            InitializeComponent();
            dialog = new OpenFileDialog();
            process = new ProcessXml();
            PathToXmlFile = "";
            txtChannelId.Text = "DX01;MX01";
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

                process.ModifyTimeStamp(newDate, PathToXmlFile, txtChannelId.Text); 
            }
        }

        private void BtnOpenExplorer_Click(object sender, EventArgs e)
        {
            // open folder as specified by configuration
            string targetFolder = Properties.Settings.Default.OutputDirectory;

            if (Directory.Exists(targetFolder))
            {
                var startInfo = new ProcessStartInfo
                {
                    Arguments = targetFolder,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
        }

        private void BtnOpenSourceFile_Click(object sender, EventArgs e)
        {
            // open source-file with default application
            if (dialog.FileName.Length > 0)
            {
                Process.Start(dialog.FileName);
            }
        }
    }
}