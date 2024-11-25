namespace _2024_25_02_02_02
{
    partial class FizzBuzzForm
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
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.OutcomeBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(148, 215);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(202, 26);
            this.NumberTextBox.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(148, 247);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(202, 95);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // OutcomeBox
            // 
            this.OutcomeBox.FormattingEnabled = true;
            this.OutcomeBox.ItemHeight = 20;
            this.OutcomeBox.Location = new System.Drawing.Point(148, 25);
            this.OutcomeBox.Name = "OutcomeBox";
            this.OutcomeBox.Size = new System.Drawing.Size(202, 184);
            this.OutcomeBox.TabIndex = 2;
            // 
            // FizzBuzzForm
            // 
            this.ClientSize = new System.Drawing.Size(493, 354);
            this.Controls.Add(this.OutcomeBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.NumberTextBox);
            this.Name = "FizzBuzzForm";
            this.Load += new System.EventHandler(this.FizzBuzzForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox fizzBuzzOutcome;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ListBox OutcomeBox;
    }
}