using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFeeder
{
    public class FileMove
    {
        private readonly string sourceFolder;
        private readonly string targetRootFolder;

        private List<string> sourceFiles = new List<string>();
        private List<string> completedFiles = new List<string>();

        public FileMove()
        {
            sourceFolder = Properties.Settings.Default.SourceFolder;
            targetRootFolder = Properties.Settings.Default.TargetRootFolder;
        }

        public void Start()
        {
            // create list of files in source 
            LoadSourceFiles();

            // start loop:
            Loop();
        }

        private void LoadSourceFiles()
        {
            sourceFiles = Directory.GetFiles(sourceFolder).ToList();
        }

        private void Loop()
        {
            while (true)
            {
                var currentTime = DateTime.Now;

                foreach (var file in sourceFiles)
                {
                    DateTime time;
                    var fileName = Path.GetFileName(file);

                    // did we already copy?
                    if (completedFiles.Contains(fileName)) continue;

                    var timePart = fileName.Split('_').First();

                    var year = timePart.Substring(0, 4);
                    var month = timePart.Substring(4, 2);
                    var days = timePart.Substring(6, 2);
                    var hours = timePart.Substring(8, 2);
                    var mins = timePart.Substring(10, 2);
                    var secs = timePart.Substring(12, 2);
                    var timeString = $"{year}-{month}-{days} {hours}:{mins}:{secs}";

                    DateTime.TryParse(timeString, out time);

                    if (currentTime > time)
                    {
                        // copy file to target
                        var sourcePath = $"{sourceFolder}\\{fileName}";
                        var newPath = $"{targetRootFolder}\\{year}-{month}-{days}\\{hours}\\{fileName}";
                        Directory.CreateDirectory($"{targetRootFolder}\\{year}-{month}-{days}\\{hours}");

                        try
                        {
                            File.Copy(sourcePath, newPath);
                        }
                        catch (IOException)
                        {
                            // ignore and continue;
                        }
                        catch (Exception e)
                        {
                            throw;
                        }

                        // add to black-list
                        completedFiles.Add(fileName);
                        Console.WriteLine($"copied file: {newPath}");
                    }

                }
            }
        }
    }
}
