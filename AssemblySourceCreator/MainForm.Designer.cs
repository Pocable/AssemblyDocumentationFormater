namespace AssemblySourceCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.UsedReg = new System.Windows.Forms.Label();
            this.usedRegBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBox = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.forceSize = new System.Windows.Forms.CheckBox();
            this.forceSizeAmount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.endDocGen = new System.Windows.Forms.CheckBox();
            this.buttonStackGenerator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.forceSizeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleLabel.Location = new System.Drawing.Point(132, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(122, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Algorithm Name";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(28, 43);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(324, 20);
            this.titleBox.TabIndex = 1;
            // 
            // UsedReg
            // 
            this.UsedReg.AutoSize = true;
            this.UsedReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsedReg.Location = new System.Drawing.Point(131, 407);
            this.UsedReg.Name = "UsedReg";
            this.UsedReg.Size = new System.Drawing.Size(119, 20);
            this.UsedReg.TabIndex = 12;
            this.UsedReg.Text = "Used Registers";
            // 
            // usedRegBox
            // 
            this.usedRegBox.AcceptsReturn = true;
            this.usedRegBox.Location = new System.Drawing.Point(28, 430);
            this.usedRegBox.Multiline = true;
            this.usedRegBox.Name = "usedRegBox";
            this.usedRegBox.Size = new System.Drawing.Size(324, 127);
            this.usedRegBox.TabIndex = 4;
            // 
            // inputBox
            // 
            this.inputBox.AcceptsReturn = true;
            this.inputBox.Location = new System.Drawing.Point(28, 98);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(324, 127);
            this.inputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Input";
            // 
            // outputBox
            // 
            this.outputBox.AcceptsReturn = true;
            this.outputBox.Location = new System.Drawing.Point(28, 261);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(324, 127);
            this.outputBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(162, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output";
            // 
            // returnBox
            // 
            this.returnBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBox.Location = new System.Drawing.Point(410, 107);
            this.returnBox.Multiline = true;
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(404, 491);
            this.returnBox.TabIndex = 8;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(551, 24);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(263, 64);
            this.generate.TabIndex = 7;
            this.generate.Text = "Format Documentation";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // forceSize
            // 
            this.forceSize.AutoSize = true;
            this.forceSize.Location = new System.Drawing.Point(432, 28);
            this.forceSize.Name = "forceSize";
            this.forceSize.Size = new System.Drawing.Size(81, 17);
            this.forceSize.TabIndex = 5;
            this.forceSize.Text = "Add Length";
            this.forceSize.UseVisualStyleBackColor = true;
            this.forceSize.CheckedChanged += new System.EventHandler(this.forceSize_CheckedChanged);
            // 
            // forceSizeAmount
            // 
            this.forceSizeAmount.Location = new System.Drawing.Point(410, 48);
            this.forceSizeAmount.Name = "forceSizeAmount";
            this.forceSizeAmount.Size = new System.Drawing.Size(120, 20);
            this.forceSizeAmount.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Line Comment Spacer Tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // endDocGen
            // 
            this.endDocGen.AutoSize = true;
            this.endDocGen.Location = new System.Drawing.Point(409, 74);
            this.endDocGen.Name = "endDocGen";
            this.endDocGen.Size = new System.Drawing.Size(136, 17);
            this.endDocGen.TabIndex = 14;
            this.endDocGen.Text = "Generate End Function";
            this.endDocGen.UseVisualStyleBackColor = true;
            // 
            // buttonStackGenerator
            // 
            this.buttonStackGenerator.Location = new System.Drawing.Point(211, 575);
            this.buttonStackGenerator.Name = "buttonStackGenerator";
            this.buttonStackGenerator.Size = new System.Drawing.Size(141, 23);
            this.buttonStackGenerator.TabIndex = 15;
            this.buttonStackGenerator.Text = "Stack Generator";
            this.buttonStackGenerator.UseVisualStyleBackColor = true;
            this.buttonStackGenerator.Click += new System.EventHandler(this.buttonStackGenerator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 622);
            this.Controls.Add(this.buttonStackGenerator);
            this.Controls.Add(this.endDocGen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.forceSizeAmount);
            this.Controls.Add(this.forceSize);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.returnBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usedRegBox);
            this.Controls.Add(this.UsedReg);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Assembly Documentation Formater";
            ((System.ComponentModel.ISupportInitialize)(this.forceSizeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label UsedReg;
        private System.Windows.Forms.TextBox usedRegBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnBox;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.CheckBox forceSize;
        private System.Windows.Forms.NumericUpDown forceSizeAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox endDocGen;
        private System.Windows.Forms.Button buttonStackGenerator;
    }
}

