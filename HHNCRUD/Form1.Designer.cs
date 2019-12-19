namespace HHNCRUD
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
            this.searchText = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.crfBox = new System.Windows.Forms.ListBox();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.viewRecordButton = new System.Windows.Forms.Button();
            this.viewCRFButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(21, 42);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(224, 20);
            this.searchText.TabIndex = 0;
            this.searchText.Text = "search";
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.Location = new System.Drawing.Point(21, 142);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(513, 251);
            this.resultsBox.TabIndex = 1;
            // 
            // crfBox
            // 
            this.crfBox.FormattingEnabled = true;
            this.crfBox.Location = new System.Drawing.Point(577, 142);
            this.crfBox.Name = "crfBox";
            this.crfBox.Size = new System.Drawing.Size(156, 251);
            this.crfBox.TabIndex = 2;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(252, 42);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(28, 19);
            this.addRecordButton.TabIndex = 3;
            this.addRecordButton.Text = "+";
            this.addRecordButton.UseVisualStyleBackColor = true;
            // 
            // viewRecordButton
            // 
            this.viewRecordButton.Location = new System.Drawing.Point(459, 399);
            this.viewRecordButton.Name = "viewRecordButton";
            this.viewRecordButton.Size = new System.Drawing.Size(75, 23);
            this.viewRecordButton.TabIndex = 4;
            this.viewRecordButton.Text = "View";
            this.viewRecordButton.UseVisualStyleBackColor = true;
            // 
            // viewCRFButton
            // 
            this.viewCRFButton.Location = new System.Drawing.Point(657, 398);
            this.viewCRFButton.Name = "viewCRFButton";
            this.viewCRFButton.Size = new System.Drawing.Size(75, 23);
            this.viewCRFButton.TabIndex = 5;
            this.viewCRFButton.Text = "View";
            this.viewCRFButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCRFButton);
            this.Controls.Add(this.viewRecordButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.crfBox);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.searchText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.ListBox crfBox;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button viewRecordButton;
        private System.Windows.Forms.Button viewCRFButton;
    }
}

