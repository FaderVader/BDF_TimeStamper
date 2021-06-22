using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TimeStamper
{
    public partial class TimeStamperGUI : Form
    {
        public string PathToXmlFile;
        string selectedSet;

        DateTime newDate;
        int hour;
        int minutes;
        int maxFiles;
        int intervalInMin;

        FileDialog dialog;
        ProcessXml process;

        public TimeStamperGUI()
        {
            InitializeComponent();
            dialog = new OpenFileDialog();

            btnProcess.Enabled = false;
            btnSelectEvent.Enabled = false;
            btnShowFirstItem.Enabled = false;

            nudMaxFiles.Value = 100;
            nudIntervalInMin.Value = 2;

            PathToXmlFile = "";
            txtChannelId.Text = "DX01;MX01";
        }

        private void AcceptPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPathToXml.Text)) return;
            var sourceFolderPath = Path.GetDirectoryName(txtPathToXml.Text); 

            process = new ProcessXml(sourceFolderPath, this);
            lstEvents.DataSource = process.BuildSourceFileList();

            btnSelectEvent.Enabled = true;
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {            
            dialog.InitialDirectory = Environment.SpecialFolder.MyComputer.ToString();
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK) { PathToXmlFile = dialog.FileName; txtPathToXml.Text = PathToXmlFile; }
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            if (selectedSet?.Length > 0)
            {
                // acquire values of Date, Hour and Minutes varibles from UI
                // call to xml-reader, process file and output to new file.
               
                Int32.TryParse(nudHours.Value.ToString(), out hour);
                Int32.TryParse(nudMinutes.Value.ToString(), out minutes);

                Int32.TryParse(nudMaxFiles.Value.ToString(), out maxFiles);
                Int32.TryParse(nudIntervalInMin.Value.ToString(), out intervalInMin);

                newDate = datePicker.Value.ChangeDate(hour, minutes);

                process.ModifySet(newDate, selectedSet, txtChannelId.Text, maxFiles, intervalInMin); 
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

        private void btnSelectEvent_Click(object sender, EventArgs e)
        {
            selectedSet = (string)lstEvents.SelectedItem;

            if (selectedSet?.Length > 0)
            {
                // activate go-button
                btnProcess.Enabled = true;
                btnShowFirstItem.Enabled = true;
            }
        }

        private void btnShowFirstItem_Click(object sender, EventArgs e)
        {

        }
    }
}