namespace AssemblyDocumentationFormater
{
    partial class LineCommentFixerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineCommentFixerForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectFile = new System.Windows.Forms.Button();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.customSpacing = new System.Windows.Forms.CheckBox();
            this.amountSpacing = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.amountSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.AddExtension = false;
            this.openFileDialog.DefaultExt = "s";
            this.openFileDialog.Filter = "MIPS Files (*.s)|*.s";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(14, 17);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(81, 27);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Select File";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectedFileName
            // 
            this.selectedFileName.AutoSize = true;
            this.selectedFileName.Location = new System.Drawing.Point(139, 24);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(85, 13);
            this.selectedFileName.TabIndex = 1;
            this.selectedFileName.Text = "No File Selected";
            // 
            // customSpacing
            // 
            this.customSpacing.AutoSize = true;
            this.customSpacing.Enabled = false;
            this.customSpacing.Location = new System.Drawing.Point(75, 60);
            this.customSpacing.Name = "customSpacing";
            this.customSpacing.Size = new System.Drawing.Size(103, 17);
            this.customSpacing.TabIndex = 2;
            this.customSpacing.Text = "Custom Spacing";
            this.customSpacing.UseVisualStyleBackColor = true;
            this.customSpacing.CheckedChanged += new System.EventHandler(this.customSpacing_CheckedChanged);
            // 
            // amountSpacing
            // 
            this.amountSpacing.Enabled = false;
            this.amountSpacing.Location = new System.Drawing.Point(69, 83);
            this.amountSpacing.Name = "amountSpacing";
            this.amountSpacing.Size = new System.Drawing.Size(120, 20);
            this.amountSpacing.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(74, 115);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 42);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(29, 168);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(195, 23);
            this.progressBar.TabIndex = 5;
            // 
            // LineCommentFixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 203);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.amountSpacing);
            this.Controls.Add(this.customSpacing);
            this.Controls.Add(this.selectedFileName);
            this.Controls.Add(this.selectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineCommentFixerForm";
            this.Text = "Line Comment Fixer";
            ((System.ComponentModel.ISupportInitialize)(this.amountSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Label selectedFileName;
        private System.Windows.Forms.CheckBox customSpacing;
        private System.Windows.Forms.NumericUpDown amountSpacing;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}