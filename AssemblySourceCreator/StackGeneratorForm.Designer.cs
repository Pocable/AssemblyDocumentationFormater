namespace AssemblyDocumentationFormater
{
    partial class StackGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StackGeneratorForm));
            this.checkBoxS0 = new System.Windows.Forms.CheckBox();
            this.checkBoxS1 = new System.Windows.Forms.CheckBox();
            this.returnBox = new System.Windows.Forms.TextBox();
            this.checkBoxS3 = new System.Windows.Forms.CheckBox();
            this.checkBoxS2 = new System.Windows.Forms.CheckBox();
            this.checkBoxS5 = new System.Windows.Forms.CheckBox();
            this.checkBoxS4 = new System.Windows.Forms.CheckBox();
            this.checkBoxRa = new System.Windows.Forms.CheckBox();
            this.buttonGenerateStack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxS0
            // 
            this.checkBoxS0.AutoSize = true;
            this.checkBoxS0.Location = new System.Drawing.Point(53, 126);
            this.checkBoxS0.Name = "checkBoxS0";
            this.checkBoxS0.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS0.TabIndex = 0;
            this.checkBoxS0.Text = "s0";
            this.checkBoxS0.UseVisualStyleBackColor = true;
            // 
            // checkBoxS1
            // 
            this.checkBoxS1.AutoSize = true;
            this.checkBoxS1.Location = new System.Drawing.Point(53, 149);
            this.checkBoxS1.Name = "checkBoxS1";
            this.checkBoxS1.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS1.TabIndex = 1;
            this.checkBoxS1.Text = "s1";
            this.checkBoxS1.UseVisualStyleBackColor = true;
            // 
            // returnBox
            // 
            this.returnBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBox.Location = new System.Drawing.Point(227, 12);
            this.returnBox.Multiline = true;
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(318, 385);
            this.returnBox.TabIndex = 9;
            // 
            // checkBoxS3
            // 
            this.checkBoxS3.AutoSize = true;
            this.checkBoxS3.Location = new System.Drawing.Point(53, 195);
            this.checkBoxS3.Name = "checkBoxS3";
            this.checkBoxS3.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS3.TabIndex = 11;
            this.checkBoxS3.Text = "s3";
            this.checkBoxS3.UseVisualStyleBackColor = true;
            // 
            // checkBoxS2
            // 
            this.checkBoxS2.AutoSize = true;
            this.checkBoxS2.Location = new System.Drawing.Point(53, 172);
            this.checkBoxS2.Name = "checkBoxS2";
            this.checkBoxS2.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS2.TabIndex = 10;
            this.checkBoxS2.Text = "s2";
            this.checkBoxS2.UseVisualStyleBackColor = true;
            // 
            // checkBoxS5
            // 
            this.checkBoxS5.AutoSize = true;
            this.checkBoxS5.Location = new System.Drawing.Point(124, 162);
            this.checkBoxS5.Name = "checkBoxS5";
            this.checkBoxS5.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS5.TabIndex = 13;
            this.checkBoxS5.Text = "s5";
            this.checkBoxS5.UseVisualStyleBackColor = true;
            // 
            // checkBoxS4
            // 
            this.checkBoxS4.AutoSize = true;
            this.checkBoxS4.Location = new System.Drawing.Point(124, 139);
            this.checkBoxS4.Name = "checkBoxS4";
            this.checkBoxS4.Size = new System.Drawing.Size(37, 17);
            this.checkBoxS4.TabIndex = 12;
            this.checkBoxS4.Text = "s4";
            this.checkBoxS4.UseVisualStyleBackColor = true;
            // 
            // checkBoxRa
            // 
            this.checkBoxRa.AutoSize = true;
            this.checkBoxRa.Location = new System.Drawing.Point(124, 185);
            this.checkBoxRa.Name = "checkBoxRa";
            this.checkBoxRa.Size = new System.Drawing.Size(35, 17);
            this.checkBoxRa.TabIndex = 14;
            this.checkBoxRa.Text = "ra";
            this.checkBoxRa.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateStack
            // 
            this.buttonGenerateStack.Location = new System.Drawing.Point(25, 228);
            this.buttonGenerateStack.Name = "buttonGenerateStack";
            this.buttonGenerateStack.Size = new System.Drawing.Size(168, 53);
            this.buttonGenerateStack.TabIndex = 15;
            this.buttonGenerateStack.Text = "Generate Stack Code";
            this.buttonGenerateStack.UseVisualStyleBackColor = true;
            this.buttonGenerateStack.Click += new System.EventHandler(this.buttonGenerateStack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Registers Needing to be Saved";
            // 
            // StackGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerateStack);
            this.Controls.Add(this.checkBoxRa);
            this.Controls.Add(this.checkBoxS5);
            this.Controls.Add(this.checkBoxS4);
            this.Controls.Add(this.checkBoxS3);
            this.Controls.Add(this.checkBoxS2);
            this.Controls.Add(this.returnBox);
            this.Controls.Add(this.checkBoxS1);
            this.Controls.Add(this.checkBoxS0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StackGeneratorForm";
            this.Text = "Stack Generator";
            this.Load += new System.EventHandler(this.StackGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxS0;
        private System.Windows.Forms.CheckBox checkBoxS1;
        private System.Windows.Forms.TextBox returnBox;
        private System.Windows.Forms.CheckBox checkBoxS3;
        private System.Windows.Forms.CheckBox checkBoxS2;
        private System.Windows.Forms.CheckBox checkBoxS5;
        private System.Windows.Forms.CheckBox checkBoxS4;
        private System.Windows.Forms.CheckBox checkBoxRa;
        private System.Windows.Forms.Button buttonGenerateStack;
        private System.Windows.Forms.Label label1;
    }
}