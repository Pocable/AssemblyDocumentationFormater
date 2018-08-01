using AssemblyDocumentationFormater;
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
                maxLength += (int)forceSizeAmount.Value;
            }

            if (endDocGen.Checked)
            {
                if(maxLength - 4 < titleText.Length)
                {
                    maxLength = titleText.Length + 4;
                }
            }


            // Add added #_ and now format.
            maxLength += 4; // Increase to include #_ and _#
            output = new String('#', maxLength) + "\n";
            output += "# " + centerText(titleText, maxLength - 4) + " #\n";
            output += new String('#', maxLength) + "\n";
            String current;

            if (!string.IsNullOrEmpty(inputText)) { 
                output += "# Input:" + new string(' ', maxLength - "# Input:".Length - 2) + " #\n";
                foreach (String a in inputTextEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 4) + " #\n";
                }
                output += new String('#', maxLength) + "\n";
            }

            if (!string.IsNullOrEmpty(outputText))
            {
                output += "# Output:" + new string(' ', maxLength - "# Output:".Length - 2) + " #\n";
                foreach (String a in outputTextEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 4) + " #\n";
                }
                output += new String('#', maxLength) + "\n";
            }

            if (!string.IsNullOrEmpty(usedRegText))
            {
                output += "# Used Registers:" + new string(' ', maxLength - "# Used Registers:".Length - 2) + " #\n";
                foreach (String a in usedRegEntries)
                {
                    current = Regex.Replace(a, @"\t|\n|\r", "");
                    output += "# " + current + new string(' ', maxLength - current.Length - 4) + " #\n";
                }

                output += new String('#', maxLength) + "\n";
            }

            if (endDocGen.Checked)
            {
                output += "\n\n";
                output += new String('#', maxLength) + "\n";
                output += "# " + centerText("End " + titleText, maxLength - 4) + " #\n";
                output += new String('#', maxLength) + "\n";

            }

            returnBox.Lines = output.Split('\n');
        }

        private void forceSize_CheckedChanged(object sender, EventArgs e)
        {
            forceSizeAmount.Enabled = forceSize.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineCommentFixerForm childForm = new LineCommentFixerForm();
            childForm.Show();
        }


        /// <summary>
        /// Generate centered text in a given space.
        /// </summary>
        /// <param name="text">The text to center.</param>
        /// <param name="space">The space provided.</param>
        /// <returns>Returns the modified string.</returns>
        private String centerText(string text, int space)
        {
            if(space < text.Length)
            {
                throw new ArgumentException($"Not enough space for centered string. Difference of {space - text.Length}");
            }


            int pad = (space - text.Length) / 2;
            if ((space - text.Length) % 2 != 0)
            {
                text += " ";
            }

            return new string(' ', pad) + text + new string(' ', pad);
        }

        private void buttonStackGenerator_Click(object sender, EventArgs e)
        {
            StackGeneratorForm childForm = new StackGeneratorForm();
            childForm.Show();
        }
    }
}
