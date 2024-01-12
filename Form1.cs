using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace logDumper;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    [RequiresAssemblyFiles("Calls System.Reflection.Assembly.Location")]
    private void btnDumpLogs_Click(object sender, EventArgs e)
    {
        var result = EventLog.GetEventLogs();

        if (result != null)
        {
            // loop through each log and find the two we want
            // Application log
            // System log
            foreach (EventLog log in result)
            {
                if (log.Log == "Application" || log.Log == "System")
                {
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;
                    progressBar1.Maximum = log.Entries.Count;

                    foreach (EventLogEntry entry in log.Entries)
                    {
                        string[] arr = new string[]
                        {
                            entry.EntryType.ToString(),
                            entry.Message.ToString(),
                            entry.TimeGenerated.ToString()
                        };

                        WriteToCsv(arr, log.Log + ".log");

                        progressBar1.Value++;
                    }
                }
            }
        }

        progressBar1.Visible = false;
        MessageBox.Show("Export Complete", "Complete!", MessageBoxButtons.OK);

        // open file explorer to the location of the export files.
        Process.Start("explorer.exe", Environment.CurrentDirectory);
    }

    static void WriteToCsv(string[] data, string filePath)
    {
        // Create a new StreamWriter and write the entire array as a single line
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            // Join the array elements into a single string with a comma separator
            string line = string.Join(",", data);

            // Write the line to the CSV file
            writer.WriteLine(line);
        }
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
