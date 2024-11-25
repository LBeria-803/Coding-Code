namespace _2024_25_02_02_02
{
    partial class MainForm
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
            this.LaunchEvenOddForm = new System.Windows.Forms.Button();
            this.LaunchFizzBuzzForm = new System.Windows.Forms.Button();
            this.LaunchDigitCounterForm = new System.Windows.Forms.Button();
            this.LaunchSecretNumberForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchEvenOddForm
            // 
            this.LaunchEvenOddForm.Location = new System.Drawing.Point(50, 29);
            this.LaunchEvenOddForm.Name = "LaunchEvenOddForm";
            this.LaunchEvenOddForm.Size = new System.Drawing.Size(714, 94);
            this.LaunchEvenOddForm.TabIndex = 0;
            this.LaunchEvenOddForm.Text = "Launch Even Odd";
            this.LaunchEvenOddForm.UseVisualStyleBackColor = true;
            this.LaunchEvenOddForm.Click += new System.EventHandler(this.LaunchEvenOddForm_Click);
            // 
            // LaunchFizzBuzzForm
            // 
            this.LaunchFizzBuzzForm.Location = new System.Drawing.Point(50, 129);
            this.LaunchFizzBuzzForm.Name = "LaunchFizzBuzzForm";
            this.LaunchFizzBuzzForm.Size = new System.Drawing.Size(714, 94);
            this.LaunchFizzBuzzForm.TabIndex = 1;
            this.LaunchFizzBuzzForm.Text = "Launch Fizz Buzz";
            this.LaunchFizzBuzzForm.UseVisualStyleBackColor = true;
            this.LaunchFizzBuzzForm.Click += new System.EventHandler(this.LaunchFizzBuzzForm_Click);
            // 
            // LaunchDigitCounterForm
            // 
            this.LaunchDigitCounterForm.Location = new System.Drawing.Point(50, 229);
            this.LaunchDigitCounterForm.Name = "LaunchDigitCounterForm";
            this.LaunchDigitCounterForm.Size = new System.Drawing.Size(714, 94);
            this.LaunchDigitCounterForm.TabIndex = 2;
            this.LaunchDigitCounterForm.Text = "Launch Digit Counter";
            this.LaunchDigitCounterForm.UseVisualStyleBackColor = true;
            this.LaunchDigitCounterForm.Click += new System.EventHandler(this.LaunchDigitCounterForm_Click);
            // 
            // LaunchSecretNumberForm
            // 
            this.LaunchSecretNumberForm.Location = new System.Drawing.Point(50, 329);
            this.LaunchSecretNumberForm.Name = "LaunchSecretNumberForm";
            this.LaunchSecretNumberForm.Size = new System.Drawing.Size(714, 94);
            this.LaunchSecretNumberForm.TabIndex = 3;
            this.LaunchSecretNumberForm.Text = "Launch Secret Number";
            this.LaunchSecretNumberForm.UseVisualStyleBackColor = true;
            this.LaunchSecretNumberForm.Click += new System.EventHandler(this.LaunchSecretNumberForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaunchSecretNumberForm);
            this.Controls.Add(this.LaunchDigitCounterForm);
            this.Controls.Add(this.LaunchFizzBuzzForm);
            this.Controls.Add(this.LaunchEvenOddForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LaunchEvenOddForm;
        private System.Windows.Forms.Button LaunchFizzBuzzForm;
        private System.Windows.Forms.Button LaunchDigitCounterForm;
        private System.Windows.Forms.Button LaunchSecretNumberForm;
    }
}

