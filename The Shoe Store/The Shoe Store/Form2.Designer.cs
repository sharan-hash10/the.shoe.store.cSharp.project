namespace SharanPranav_BAP_Assignment4
{
    partial class SalesReportForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.AverageTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.NumberofShoesSoldTextBox = new System.Windows.Forms.TextBox();
            this.TotalSalesTextBox = new System.Windows.Forms.TextBox();
            this.TotalTransactionsTextbox = new System.Windows.Forms.TextBox();
            this.AverageTransactionsLabel = new System.Windows.Forms.Label();
            this.NumberofShoesSoldLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Shoe Store";
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(413, 261);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 32);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ToolTip.SetToolTip(this.ExitButton, "Click to Close the Form");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.AverageTransactionsTextBox);
            this.SummaryGroupBox.Controls.Add(this.ExitButton);
            this.SummaryGroupBox.Controls.Add(this.NumberofShoesSoldTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalSalesTextBox);
            this.SummaryGroupBox.Controls.Add(this.TotalTransactionsTextbox);
            this.SummaryGroupBox.Controls.Add(this.AverageTransactionsLabel);
            this.SummaryGroupBox.Controls.Add(this.NumberofShoesSoldLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalSalesLabel);
            this.SummaryGroupBox.Controls.Add(this.TotalTransactionsLabel);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(433, 128);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Size = new System.Drawing.Size(578, 345);
            this.SummaryGroupBox.TabIndex = 24;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Sales Report Summary";
            // 
            // AverageTransactionsTextBox
            // 
            this.AverageTransactionsTextBox.Enabled = false;
            this.AverageTransactionsTextBox.Location = new System.Drawing.Point(357, 188);
            this.AverageTransactionsTextBox.Name = "AverageTransactionsTextBox";
            this.AverageTransactionsTextBox.ReadOnly = true;
            this.AverageTransactionsTextBox.Size = new System.Drawing.Size(162, 28);
            this.AverageTransactionsTextBox.TabIndex = 28;
            // 
            // NumberofShoesSoldTextBox
            // 
            this.NumberofShoesSoldTextBox.Enabled = false;
            this.NumberofShoesSoldTextBox.Location = new System.Drawing.Point(357, 136);
            this.NumberofShoesSoldTextBox.Name = "NumberofShoesSoldTextBox";
            this.NumberofShoesSoldTextBox.ReadOnly = true;
            this.NumberofShoesSoldTextBox.Size = new System.Drawing.Size(162, 28);
            this.NumberofShoesSoldTextBox.TabIndex = 27;
            // 
            // TotalSalesTextBox
            // 
            this.TotalSalesTextBox.Enabled = false;
            this.TotalSalesTextBox.Location = new System.Drawing.Point(357, 90);
            this.TotalSalesTextBox.Name = "TotalSalesTextBox";
            this.TotalSalesTextBox.ReadOnly = true;
            this.TotalSalesTextBox.Size = new System.Drawing.Size(162, 28);
            this.TotalSalesTextBox.TabIndex = 26;
            // 
            // TotalTransactionsTextbox
            // 
            this.TotalTransactionsTextbox.Enabled = false;
            this.TotalTransactionsTextbox.Location = new System.Drawing.Point(357, 38);
            this.TotalTransactionsTextbox.Name = "TotalTransactionsTextbox";
            this.TotalTransactionsTextbox.ReadOnly = true;
            this.TotalTransactionsTextbox.Size = new System.Drawing.Size(162, 28);
            this.TotalTransactionsTextbox.TabIndex = 25;
            // 
            // AverageTransactionsLabel
            // 
            this.AverageTransactionsLabel.AutoSize = true;
            this.AverageTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageTransactionsLabel.Location = new System.Drawing.Point(28, 194);
            this.AverageTransactionsLabel.Name = "AverageTransactionsLabel";
            this.AverageTransactionsLabel.Size = new System.Drawing.Size(298, 22);
            this.AverageTransactionsLabel.TabIndex = 24;
            this.AverageTransactionsLabel.Text = "Average of Transaction Amount:\r\n";
            // 
            // NumberofShoesSoldLabel
            // 
            this.NumberofShoesSoldLabel.AutoSize = true;
            this.NumberofShoesSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofShoesSoldLabel.Location = new System.Drawing.Point(28, 142);
            this.NumberofShoesSoldLabel.Name = "NumberofShoesSoldLabel";
            this.NumberofShoesSoldLabel.Size = new System.Drawing.Size(216, 22);
            this.NumberofShoesSoldLabel.TabIndex = 23;
            this.NumberofShoesSoldLabel.Text = "Number of Shoes Sold:";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(28, 93);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(175, 22);
            this.TotalSalesLabel.TabIndex = 22;
            this.TotalSalesLabel.Text = "Total Sales Value:";
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.AutoSize = true;
            this.TotalTransactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(28, 44);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(282, 22);
            this.TotalTransactionsLabel.TabIndex = 21;
            this.TotalTransactionsLabel.Text = "Total Number of Transactions:";
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1464, 740);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.Text = "The Shoe Store";
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.TextBox AverageTransactionsTextBox;
        private System.Windows.Forms.TextBox NumberofShoesSoldTextBox;
        private System.Windows.Forms.TextBox TotalSalesTextBox;
        private System.Windows.Forms.TextBox TotalTransactionsTextbox;
        private System.Windows.Forms.Label AverageTransactionsLabel;
        private System.Windows.Forms.Label NumberofShoesSoldLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label TotalTransactionsLabel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}