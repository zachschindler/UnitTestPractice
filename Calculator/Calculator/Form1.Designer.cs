namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.value2TextBox = new System.Windows.Forms.TextBox();
            this.value1TextBox = new System.Windows.Forms.TextBox();
            this.solutionLabel = new System.Windows.Forms.Label();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 43);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Please enter values into each text box and choose an operation to perform";
            // 
            // value2TextBox
            // 
            this.value2TextBox.Location = new System.Drawing.Point(214, 101);
            this.value2TextBox.Name = "value2TextBox";
            this.value2TextBox.Size = new System.Drawing.Size(100, 22);
            this.value2TextBox.TabIndex = 14;
            // 
            // value1TextBox
            // 
            this.value1TextBox.Location = new System.Drawing.Point(74, 101);
            this.value1TextBox.Name = "value1TextBox";
            this.value1TextBox.Size = new System.Drawing.Size(100, 22);
            this.value1TextBox.TabIndex = 13;
            // 
            // solutionLabel
            // 
            this.solutionLabel.AutoSize = true;
            this.solutionLabel.Location = new System.Drawing.Point(172, 180);
            this.solutionLabel.Name = "solutionLabel";
            this.solutionLabel.Size = new System.Drawing.Size(46, 17);
            this.solutionLabel.TabIndex = 12;
            this.solutionLabel.Text = "label1";
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(279, 130);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 11;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click_1);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(198, 130);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 10;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click_1);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(117, 130);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(75, 23);
            this.subtractionButton.TabIndex = 9;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click_1);
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(36, 130);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(75, 23);
            this.additionButton.TabIndex = 8;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 228);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.value2TextBox);
            this.Controls.Add(this.value1TextBox);
            this.Controls.Add(this.solutionLabel);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox value2TextBox;
        private System.Windows.Forms.TextBox value1TextBox;
        private System.Windows.Forms.Label solutionLabel;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button additionButton;
    }
}

