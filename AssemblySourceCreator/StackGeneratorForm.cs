using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyDocumentationFormater
{
    public partial class StackGeneratorForm : Form
    {
        public StackGeneratorForm()
        {
            InitializeComponent();
        }

        private void buttonGenerateStack_Click(object sender, EventArgs e)
        {
            String prefix = "";
            String suffix = "";
            int stackRaise = 0;
            if (checkBoxS0.Checked)
            {
                prefix += $"sw $s0, {stackRaise}($sp)\r\n";
                suffix += $"lw $s0, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxS1.Checked)
            {
                prefix += $"sw $s1, {stackRaise}($sp)\r\n";
                suffix += $"lw $s1, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxS2.Checked)
            {
                prefix += $"sw $s2, {stackRaise}($sp)\r\n";
                suffix += $"lw $s2, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxS3.Checked)
            {
                prefix += $"sw $s3, {stackRaise}($sp)\r\n";
                suffix += $"lw $s3, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxS4.Checked)
            {
                prefix += $"sw $s4, {stackRaise}($sp)\r\n";
                suffix += $"lw $s4, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxS5.Checked)
            {
                prefix += $"sw $s5, {stackRaise}($sp)\r\n";
                suffix += $"lw $s5, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if (checkBoxRa.Checked)
            {
                prefix += $"sw $ra, {stackRaise}($sp)\r\n";
                suffix += $"lw $ra, {stackRaise}($sp)\r\n";
                stackRaise += 4;
            }
            if(stackRaise == 0)
            {
                returnBox.Text = "Stack did not change!";
            }
            else
            {
                prefix = $"addi $sp, $sp, {-(stackRaise)}\r\n" + prefix;
                suffix = suffix + $"addi $sp, $sp, {stackRaise}\r\n";
                returnBox.Text = "Generated Stack Changes Sucessfully!\r\n\r\n" + prefix + "\r\n" + suffix;
            }
        }

        private void StackGeneratorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
