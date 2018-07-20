using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyDocumentationFormater
{
    public partial class LineCommentFixerForm : Form
    {
        public LineCommentFixerForm()
        {
            InitializeComponent();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            selectedFileName.Text = openFileDialog.SafeFileName;
            startButton.Enabled = true;
            customSpacing.Enabled = true;
            progressBar.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!openFileDialog.CheckFileExists)
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            int longestLine = 0;
            int lineCount = 0;

            // Determine longest line
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    String current;
                    bool seenText = false;
                    while (!sr.EndOfStream)
                    {
                        current = sr.ReadLine();
                        if (!seenText)
                        {
                            if (current.Contains(".text"))
                            {
                                seenText = true;
                            }
                        }
                        else
                        {
                            lineCount++;
                            if (string.IsNullOrEmpty(current)) { continue; }
                            if (Regex.Replace(current, @"\t|\n|\r", "")[0].Equals('#')) { continue; }
                            current = current.Split('#')[0].Trim();
                            if (longestLine < current.Length)
                            {
                                longestLine = current.Length;
                            }
                        }
                    }
                }
            }

            if (customSpacing.Checked)
            {
                longestLine += (int) amountSpacing.Value;
            }

            if (longestLine <= 2)
            {
                MessageBox.Show("Longest line is less than the required max!");
                return;
            }

            int linesDone = 0;

            // Begin formating code
            using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fz = new FileStream(openFileDialog.FileName.Replace(".s", "") + "Out.s", FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fz))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            String current;
                            String write;
                            while (!sr.EndOfStream)
                            {
                                current = sr.ReadLine();
                                write = current;
                                // Check if its already a comment line or the line is empty
                                if (!string.IsNullOrEmpty(current))
                                {
                                    if (!Regex.Replace(current, @"\t|\n|\r", "")[0].Equals('#'))
                                    {
                                        String[] parts = current.Split('#');
                                        if (parts.Length > 1)
                                        {
                                            parts[0] = parts[0].TrimEnd();
                                            parts[1] = parts[1].TrimStart();
                                            write = parts[0];
                                            if(longestLine + 4 - parts[0].Length > 0)
                                            {
                                                write += new string(' ', longestLine + 4 - parts[0].Length);
                                                write += "# ";
                                                write += parts[1];

                                                // Add rest of the parts
                                                for (int i = 2; i < parts.Length; i++)
                                                {
                                                    write += parts[i];
                                                }
                                            }
                                            else
                                            {
                                                write = current;
                                            }
                                        }

                                    }
                                }

                                sw.WriteLine(write);
                                linesDone++;
                                progressBar.Value = (linesDone / lineCount) * 100;

                            }
                        }
                    }
                }
            }

            MessageBox.Show("File modified sucessfully!");
        }

        private void customSpacing_CheckedChanged(object sender, EventArgs e)
        {
            amountSpacing.Enabled = customSpacing.Checked;
        }
    }
}
