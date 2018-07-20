using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblySourceCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            forceSizeAmount.Enabled = false;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            String titleText = titleBox.Text;
            String usedRegText = usedRegBox.Text;
            String inputText = inputBox.Text;
            String outputText = outputBox.Text;
            String output = "";

            // Figure out how wide we need the box
            int maxLength = titleText.Length;
            String[] usedRegEntries = usedRegText.Split('\n');
            foreach (String a in usedRegEntries)
            {
                if (a.Length > maxLength)
                {
                    maxLength = a.Length;
                }
            }
            String[] inputTextEntries = inputText.Split('\n');
            foreach (String a in inputTextEntries)
            {
                if (a.Length > maxLength)
                {
                    maxLength = a.Length;
                }
            }
            String[] outputTextEntries = outputText.Split('\n');
            foreach (String a in outputTextEntries)
            {
                if (a.Length > maxLength)
                {
                    maxLength = a.Length;
                }
            }

            if (maxLength < "# Used Registers:".Length)
            {
                maxLength = "# Used Registers:".Length;
            }


            if (string.IsNullOrEmpty(titleText))
            {
                returnBox.Text = "Algorithm Name cannot be empty!";
                return;
            }

            if (forceSize.Checked)
            {
                if(forceSizeAmount.Value > maxLength)
                {
                    maxLength = (int)forceSizeAmount.Value;
                }
                else
                {
                    returnBox.Text = "Force size too small to fit formating!";
                    return;
                }
            }

            if (titleText.Length % 2 == 0)
            {
                titleText += "  ";
            }
            // Add padding for max length and now format.
            maxLength = maxLength + 2;
            output = new String('#', maxLength + 2) + "\n";
            int titlePad = (maxLength - titleText.Length - 2) / 2;
            output += "# " + new string(' ', titlePad) + titleText + (titleText.Length % 2 == 0 ? "" : " ") +  new string(' ', titlePad) + " #\n";
            output += new String('#', maxLength + 2) + "\n";
            String current;

            if (!string.IsNullOrEmpty(inputText)) { 
                output += "# Input:" + new string(' ', maxLength - "# Input:".Length) + " #\n";
                foreach (String a in inputTextEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 2) + " #\n";
                }
                output += new String('#', maxLength + 2) + "\n";
            }

            if (!string.IsNullOrEmpty(outputText))
            {
                output += "# Output:" + new string(' ', maxLength - "# Output:".Length) + " #\n";
                foreach (String a in outputTextEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 2) + " #\n";
                }
                output += new String('#', maxLength + 2) + "\n";
            }

            if (!string.IsNullOrEmpty(usedRegText))
            {
                output += "# Used Registers:" + new string(' ', maxLength - "# Used Registers:".Length) + " #\n";
                foreach (String a in usedRegEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 2) + " #\n";
                }

                output += new String('#', maxLength + 2) + "\n";
            }

            returnBox.Lines = output.Split('\n');

            Console.WriteLine(output);
        }

        private void forceSize_CheckedChanged(object sender, EventArgs e)
        {
            forceSizeAmount.Enabled = forceSize.Checked;
        }
    }
}
