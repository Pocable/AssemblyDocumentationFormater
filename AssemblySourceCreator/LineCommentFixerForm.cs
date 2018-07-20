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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void customSpacing_CheckedChanged(object sender, EventArgs e)
        {
            amountSpacing.Enabled = customSpacing.Checked;
        }
    }
}
