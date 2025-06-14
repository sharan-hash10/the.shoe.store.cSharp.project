namespace SharanPranav_BAP_Assignment4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.POSPanel = new System.Windows.Forms.Panel();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchResultListBox = new System.Windows.Forms.ListBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.TransactionNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.DateRadioButton = new System.Windows.Forms.RadioButton();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalCartValueTextBox = new System.Windows.Forms.TextBox();
            this.TotalCartValueLabel = new System.Windows.Forms.Label();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.ShoppingCartListView = new System.Windows.Forms.ListView();
            this.ShoeNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.ShoeListGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalValueListBox = new System.Windows.Forms.TextBox();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.ShoeListBox = new System.Windows.Forms.ListBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ShoecollectionLabel = new System.Windows.Forms.Label();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddToCartToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearCartToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PlaceOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SalesReportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearSearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.POSPanel.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.ShoppingCartGroupBox.SuspendLayout();
            this.ShoeListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // POSPanel
            // 
            this.POSPanel.BackColor = System.Drawing.Color.Salmon;
            this.POSPanel.Controls.Add(this.SearchGroupBox);
            this.POSPanel.Controls.Add(this.SummaryButton);
            this.POSPanel.Controls.Add(this.ExitButton);
            this.POSPanel.Controls.Add(this.ShoppingCartGroupBox);
            this.POSPanel.Controls.Add(this.ShoeListGroupBox);
            this.POSPanel.Controls.Add(this.label1);
            this.POSPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSPanel.Location = new System.Drawing.Point(0, 0);
            this.POSPanel.Name = "POSPanel";
            this.POSPanel.Size = new System.Drawing.Size(1482, 872);
            this.POSPanel.TabIndex = 0;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchResultListBox);
            this.SearchGroupBox.Controls.Add(this.ClearSearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchByLabel);
            this.SearchGroupBox.Controls.Add(this.TransactionNumberRadioButton);
            this.SearchGroupBox.Controls.Add(this.DateRadioButton);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(140, 437);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(955, 261);
            this.SearchGroupBox.TabIndex = 22;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Tab";
            // 
            // SearchResultListBox
            // 
            this.SearchResultListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResultListBox.FormattingEnabled = true;
            this.SearchResultListBox.ItemHeight = 22;
            this.SearchResultListBox.Location = new System.Drawing.Point(273, 27);
            this.SearchResultListBox.Name = "SearchResultListBox";
            this.SearchResultListBox.Size = new System.Drawing.Size(653, 224);
            this.SearchResultListBox.TabIndex = 28;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearchButton.Location = new System.Drawing.Point(82, 203);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(116, 32);
            this.ClearSearchButton.TabIndex = 27;
            this.ClearSearchButton.Text = "Clea&r";
            this.ClearSearchToolTip.SetToolTip(this.ClearSearchButton, "Click to Clear the Search Tab");
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(82, 159);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(116, 32);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "&Search";
            this.SearchToolTip.SetToolTip(this.SearchButton, "Click to Search the Transaction Details");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(50, 121);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(199, 28);
            this.SearchTextBox.TabIndex = 26;
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.Location = new System.Drawing.Point(6, 33);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(78, 18);
            this.SearchByLabel.TabIndex = 25;
            this.SearchByLabel.Text = "Search by:";
            // 
            // TransactionNumberRadioButton
            // 
            this.TransactionNumberRadioButton.AutoSize = true;
            this.TransactionNumberRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionNumberRadioButton.Location = new System.Drawing.Point(37, 89);
            this.TransactionNumberRadioButton.Name = "TransactionNumberRadioButton";
            this.TransactionNumberRadioButton.Size = new System.Drawing.Size(212, 26);
            this.TransactionNumberRadioButton.TabIndex = 24;
            this.TransactionNumberRadioButton.TabStop = true;
            this.TransactionNumberRadioButton.Text = "Transaction Number";
            this.TransactionNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // DateRadioButton
            // 
            this.DateRadioButton.AutoSize = true;
            this.DateRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRadioButton.Location = new System.Drawing.Point(37, 57);
            this.DateRadioButton.Name = "DateRadioButton";
            this.DateRadioButton.Size = new System.Drawing.Size(79, 26);
            this.DateRadioButton.TabIndex = 23;
            this.DateRadioButton.TabStop = true;
            this.DateRadioButton.Text = "Date ";
            this.DateRadioButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Enabled = false;
            this.SummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SummaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryButton.Location = new System.Drawing.Point(1180, 510);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(106, 58);
            this.SummaryButton.TabIndex = 19;
            this.SummaryButton.Text = "S&ales Report";
            this.SalesReportToolTip.SetToolTip(this.SummaryButton, "Click to Display the Sales Report");
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1180, 596);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(106, 32);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Click to Exit the Application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShoppingCartGroupBox
            // 
            this.ShoppingCartGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShoppingCartGroupBox.Controls.Add(this.TotalCartValueTextBox);
            this.ShoppingCartGroupBox.Controls.Add(this.TotalCartValueLabel);
            this.ShoppingCartGroupBox.Controls.Add(this.PlaceOrderButton);
            this.ShoppingCartGroupBox.Controls.Add(this.ShoppingCartListView);
            this.ShoppingCartGroupBox.Controls.Add(this.ClearCartButton);
            this.ShoppingCartGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShoppingCartGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartGroupBox.Location = new System.Drawing.Point(670, 60);
            this.ShoppingCartGroupBox.Name = "ShoppingCartGroupBox";
            this.ShoppingCartGroupBox.Size = new System.Drawing.Size(699, 371);
            this.ShoppingCartGroupBox.TabIndex = 12;
            this.ShoppingCartGroupBox.TabStop = false;
            this.ShoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // TotalCartValueTextBox
            // 
            this.TotalCartValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCartValueTextBox.Location = new System.Drawing.Point(198, 279);
            this.TotalCartValueTextBox.Name = "TotalCartValueTextBox";
            this.TotalCartValueTextBox.ReadOnly = true;
            this.TotalCartValueTextBox.Size = new System.Drawing.Size(127, 28);
            this.TotalCartValueTextBox.TabIndex = 17;
            // 
            // TotalCartValueLabel
            // 
            this.TotalCartValueLabel.AutoSize = true;
            this.TotalCartValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCartValueLabel.Location = new System.Drawing.Point(29, 285);
            this.TotalCartValueLabel.Name = "TotalCartValueLabel";
            this.TotalCartValueLabel.Size = new System.Drawing.Size(163, 22);
            this.TotalCartValueLabel.TabIndex = 17;
            this.TotalCartValueLabel.Text = "Total Cart Value:";
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PlaceOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderButton.Location = new System.Drawing.Point(531, 323);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(142, 32);
            this.PlaceOrderButton.TabIndex = 18;
            this.PlaceOrderButton.Text = "&Place Order";
            this.PlaceOrderToolTip.SetToolTip(this.PlaceOrderButton, "Click to Place the Order");
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // ShoppingCartListView
            // 
            this.ShoppingCartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ShoeNameHeader,
            this.QuantityHeader,
            this.SizeHeader,
            this.PriceHeader});
            this.ShoppingCartListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListView.GridLines = true;
            this.ShoppingCartListView.HideSelection = false;
            this.ShoppingCartListView.Location = new System.Drawing.Point(33, 27);
            this.ShoppingCartListView.Name = "ShoppingCartListView";
            this.ShoppingCartListView.Size = new System.Drawing.Size(640, 246);
            this.ShoppingCartListView.TabIndex = 3;
            this.ShoppingCartListView.UseCompatibleStateImageBehavior = false;
            this.ShoppingCartListView.View = System.Windows.Forms.View.Details;
            // 
            // ShoeNameHeader
            // 
            this.ShoeNameHeader.Text = "Shoe Name";
            this.ShoeNameHeader.Width = 255;
            // 
            // QuantityHeader
            // 
            this.QuantityHeader.Text = "Quantity";
            this.QuantityHeader.Width = 114;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Size";
            this.SizeHeader.Width = 96;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "Shoe Price";
            this.PriceHeader.Width = 166;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCartButton.Location = new System.Drawing.Point(402, 323);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(106, 32);
            this.ClearCartButton.TabIndex = 17;
            this.ClearCartButton.Text = "C&lear Cart";
            this.ClearCartToolTip.SetToolTip(this.ClearCartButton, "Click to Clear the Shopping Cart");
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // ShoeListGroupBox
            // 
            this.ShoeListGroupBox.Controls.Add(this.label2);
            this.ShoeListGroupBox.Controls.Add(this.TotalValueListBox);
            this.ShoeListGroupBox.Controls.Add(this.SizeListBox);
            this.ShoeListGroupBox.Controls.Add(this.ShoeListBox);
            this.ShoeListGroupBox.Controls.Add(this.QuantityTextbox);
            this.ShoeListGroupBox.Controls.Add(this.SizeLabel);
            this.ShoeListGroupBox.Controls.Add(this.ShoecollectionLabel);
            this.ShoeListGroupBox.Controls.Add(this.TotalValueLabel);
            this.ShoeListGroupBox.Controls.Add(this.QuantityLabel);
            this.ShoeListGroupBox.Controls.Add(this.AddtoCartButton);
            this.ShoeListGroupBox.Controls.Add(this.ClearButton);
            this.ShoeListGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeListGroupBox.Location = new System.Drawing.Point(134, 60);
            this.ShoeListGroupBox.Name = "ShoeListGroupBox";
            this.ShoeListGroupBox.Size = new System.Drawing.Size(509, 371);
            this.ShoeListGroupBox.TabIndex = 11;
            this.ShoeListGroupBox.TabStop = false;
            this.ShoeListGroupBox.Text = "Shoe List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 80);
            this.label2.TabIndex = 20;
            this.label2.Text = "Note:\r\nDifferent \r\nSizes have \r\ndifferent \r\nprices";
            // 
            // TotalValueListBox
            // 
            this.TotalValueListBox.Enabled = false;
            this.TotalValueListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValueListBox.Location = new System.Drawing.Point(370, 231);
            this.TotalValueListBox.Name = "TotalValueListBox";
            this.TotalValueListBox.ReadOnly = true;
            this.TotalValueListBox.Size = new System.Drawing.Size(127, 28);
            this.TotalValueListBox.TabIndex = 16;
            // 
            // SizeListBox
            // 
            this.SizeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.ItemHeight = 22;
            this.SizeListBox.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.SizeListBox.Location = new System.Drawing.Point(334, 51);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(162, 114);
            this.SizeListBox.TabIndex = 10;
            this.SizeListBox.SelectedIndexChanged += new System.EventHandler(this.SizeListBox_SelectedIndexChanged_1);
            // 
            // ShoeListBox
            // 
            this.ShoeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoeListBox.FormattingEnabled = true;
            this.ShoeListBox.ItemHeight = 20;
            this.ShoeListBox.Items.AddRange(new object[] {
            "Nike ZoomX Vaporfly",
            "Nike Air Zoom Alphafly",
            "Saucony Endrophin Pro",
            "Adidas Adizero Afios",
            "Asics Metaspeed sky",
            "Nike Airforce ",
            "Nike dunk low",
            "Air Jordan ",
            "Adidas San Smith",
            "Reebok club ",
            "Zara chelsea boots",
            "Tommy Hilfiger formals",
            "Oxford Black Brogue",
            "John White Ivy black",
            "Highgate Tassel Loafers"});
            this.ShoeListBox.Location = new System.Drawing.Point(6, 51);
            this.ShoeListBox.Name = "ShoeListBox";
            this.ShoeListBox.Size = new System.Drawing.Size(215, 304);
            this.ShoeListBox.TabIndex = 7;
            this.ShoeListBox.SelectedIndexChanged += new System.EventHandler(this.ShoeListBox_SelectedIndexChanged_1);
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Enabled = false;
            this.QuantityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextbox.Location = new System.Drawing.Point(370, 197);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(127, 28);
            this.QuantityTextbox.TabIndex = 15;
            this.QuantityTextbox.TextChanged += new System.EventHandler(this.QuantityListbox_TextChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(330, 26);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(48, 22);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "Size";
            // 
            // ShoecollectionLabel
            // 
            this.ShoecollectionLabel.AutoSize = true;
            this.ShoecollectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoecollectionLabel.Location = new System.Drawing.Point(2, 26);
            this.ShoecollectionLabel.Name = "ShoecollectionLabel";
            this.ShoecollectionLabel.Size = new System.Drawing.Size(151, 22);
            this.ShoecollectionLabel.TabIndex = 2;
            this.ShoecollectionLabel.Text = "Shoe Collection";
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValueLabel.Location = new System.Drawing.Point(239, 234);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(119, 22);
            this.TotalValueLabel.TabIndex = 14;
            this.TotalValueLabel.Text = "Total Value:";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(239, 200);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(91, 22);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.Enabled = false;
            this.AddtoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddtoCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCartButton.Location = new System.Drawing.Point(355, 323);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(142, 32);
            this.AddtoCartButton.TabIndex = 11;
            this.AddtoCartButton.Text = "A&dd to Cart";
            this.AddToCartToolTip.SetToolTip(this.AddtoCartButton, "Add Selected Item to Cart");
            this.AddtoCartButton.UseVisualStyleBackColor = true;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(380, 285);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(116, 32);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "&Clear";
            this.ClearToolTip.SetToolTip(this.ClearButton, "Clears the ShoeList");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(611, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Shoe Store";
            // 
            // ClearToolTip
            // 
            this.ClearToolTip.IsBalloon = true;
            // 
            // AddToCartToolTip
            // 
            this.AddToCartToolTip.IsBalloon = true;
            // 
            // ClearCartToolTip
            // 
            this.ClearCartToolTip.IsBalloon = true;
            // 
            // PlaceOrderToolTip
            // 
            this.PlaceOrderToolTip.IsBalloon = true;
            // 
            // SalesReportToolTip
            // 
            this.SalesReportToolTip.IsBalloon = true;
            // 
            // ExitToolTip
            // 
            this.ExitToolTip.IsBalloon = true;
            // 
            // SearchToolTip
            // 
            this.SearchToolTip.IsBalloon = true;
            // 
            // ClearSearchToolTip
            // 
            this.ClearSearchToolTip.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1494, 710);
            this.Controls.Add(this.POSPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Shoe Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.POSPanel.ResumeLayout(false);
            this.POSPanel.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ShoppingCartGroupBox.ResumeLayout(false);
            this.ShoppingCartGroupBox.PerformLayout();
            this.ShoeListGroupBox.ResumeLayout(false);
            this.ShoeListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel POSPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShoecollectionLabel;
        private System.Windows.Forms.ListBox ShoeListBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.GroupBox ShoeListGroupBox;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.TextBox TotalValueListBox;
        private System.Windows.Forms.GroupBox ShoppingCartGroupBox;
        private System.Windows.Forms.ListView ShoppingCartListView;
        private System.Windows.Forms.ColumnHeader ShoeNameHeader;
        private System.Windows.Forms.ColumnHeader QuantityHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Label TotalCartValueLabel;
        private System.Windows.Forms.TextBox TotalCartValueTextBox;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.RadioButton DateRadioButton;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.RadioButton TransactionNumberRadioButton;
        private System.Windows.Forms.ListBox SearchResultListBox;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ToolTip ClearToolTip;
        private System.Windows.Forms.ToolTip AddToCartToolTip;
        private System.Windows.Forms.ToolTip ClearCartToolTip;
        private System.Windows.Forms.ToolTip PlaceOrderToolTip;
        private System.Windows.Forms.ToolTip SalesReportToolTip;
        private System.Windows.Forms.ToolTip ExitToolTip;
        private System.Windows.Forms.ToolTip SearchToolTip;
        private System.Windows.Forms.ToolTip ClearSearchToolTip;
    }
}

