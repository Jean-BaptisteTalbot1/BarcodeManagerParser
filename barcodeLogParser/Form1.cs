using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace barcodeLogParser
{
    public partial class Form1 : Form
    {
        private const string FILE_TO_READ = "log.txt";
        private const string FILE_TO_WRITE = "LogParsed.txt";

        private const string headerStartRequest =
            "\n\n//////////////////////\n/// START REQUEST ////\n//////////////////////";

        private const string headerStartReset = "\n\t/////////// START RESET ///////////////";

        private const string headerStopRequest =
            "\n\t//////////////////////\n\t/// STOP REQUEST ////\n\t//////////////////////";

        private const string headerStopReset = "\n\t//////////// STOP RESET ///////////////";

        private readonly string exePath = AppDomain.CurrentDomain.BaseDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void ParsingBtn_Click(object sender, EventArgs e)
        {
            progressGroup.BringToFront();
            progressGroup.Visible = true;

            ParsingBtn.Visible = false;
            actionsGroup.Visible = false;
            actionsGroup.SendToBack();

            var logContent =
                new List<string>(LocalFileCheckBox.Checked ? extractLocalFileLines(exePath) : extractFtpFileLines());

            WrtieToParsedFile(ParsingStartStopAcquisition(logContent.Select(s => s.Replace("\r", "")).ToList()));

            progressGroup.SendToBack();
            progressGroup.Visible = false;
            actionsGroup.BringToFront();
            actionsGroup.Visible = true;
            ParsingBtn.Visible = true;

            var result = MessageBox.Show("Open the parsed file?","The file is parsed",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                Process.Start("notepad.exe", exePath + FILE_TO_WRITE);
            }

        }

        private void LocalFileCheckBox_Click(object sender, EventArgs e)
        {
            FtpFileCheckBox.Checked = false;
            FtpGroup.SendToBack();
            LocalGroup.BringToFront();
        }

        private void FtpFile_Click(object sender, EventArgs e)
        {
            LocalFileCheckBox.Checked = false;
            FtpGroup.BringToFront();
            LocalGroup.SendToBack();
        }

        private List<string> extractLocalFileLines(string path)
        {
            var fileLines = new List<string>();

            if (!File.Exists(path + FILE_TO_READ))
                MessageBox.Show("The selected file doesn't exist");

            // Start reading the file to parse
            using (var sr = new StreamReader(exePath.Replace(path, FILE_TO_READ)))
            {
                string currentLine;
                // currentLine will be null when the StreamReader reaches the end of file
                while ((currentLine = sr.ReadLine()) != null)
                {
                    // Only keeps the lector lines
                    if (!currentLine.Contains("[INFO]") || !currentLine.Contains("ector")) continue;

                    fileLines.Add(currentLine);
                }
            }

            return fileLines;
        }

        private List<string> extractFtpFileLines()
        {
            var IPAddress = "10.105.240.223";

            var filename = "/Numove_10_0034_0001/";

            //var request = (FtpWebRequest)WebRequest.Create($"ftp://{IPAddress}:2021/{filename}");
            var request =
                (FtpWebRequest)WebRequest.Create("ftp://10.105.240.223/Numove_10_0034_0001/Output%20Error/log.txt");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential("user", "1000340001");
            using (var response = (FtpWebResponse)request.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd().Split('\n').Where(r => r.Contains("[INFO]") && r.Contains("ector"))
                        .ToList();
                }
            }
        }

        private List<string> ParsingStartStopAcquisition(List<string> fileLines)
        {
            progressBar.Value = 0;
            progressBar.Maximum = fileLines.Count;
            ProgressStatus.Text = "Parsing the file";

            for (var i = 0; i < fileLines.Count - 2; i++)
            {
                progressBar.Value = i < progressBar.Maximum ? i : progressBar.Maximum;

                if (fileLines[i].Contains("StartScanningIndex changed, the PLC sent a message to start the barcode"))
                {
                    if (fileLines[i + 2].Contains("The barcode start request is 1, so to start the Lector"))
                    {
                        fileLines.Insert(i, headerStartRequest);
                        i++;
                    }
                    else
                    {
                        fileLines.Insert(i, headerStartReset);
                        i++;
                    }
                }
                else if (fileLines[i].Contains("StopScanningIndex changed, the PLC sent a message to stop the barcode"))
                {
                    if (fileLines[i + 1].Contains("The barcode stop request is 1, so to stop the lector"))
                    {
                        fileLines.Insert(i, headerStopRequest);
                        i++;
                    }
                    else
                    {
                        fileLines.Insert(i, headerStopReset);
                        i++;
                    }
                }
            }

            progressBar.Value = 0;
            return fileLines;
        }

        private void WrtieToParsedFile(List<string> fileLines)
        {
            progressBar.Value = 0;
            progressBar.Maximum = fileLines.Count;
            ProgressStatus.Text = "Writing the file";

            // Create the file to write into
            var fileParsed = new StreamWriter(exePath + FILE_TO_WRITE, false);

            foreach (var line in fileLines)
            {
                fileParsed.WriteLine($"\t{line}");
                progressBar.Value++;
            }

            progressBar.Value = 0;
        }

        private static void parseLine(string line, out string date, out string message)
        {
            // The message is to the right of the "()"
            message = line.Replace(')', ' ').Split('(').Last();
            // The date is on the left side
            date = line.Split(',').First();
        }
    }
}