using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SharanPranav_BAP_Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //CONSTANT VARIABLE DECLARATION
        const string PRICE_TXT = "ShoePriceArray.txt", STOCK_TXT = "ShoeStockInventory.txt", TRANSACTIONS_TXT = "Transactions.txt";

        //Field Variable Declaration
        public static string[] ShoeList = { "Nike ZoomX Vaporfly", "Nike Air Zoom Alphafly", "Saucony Endrophin Pro", "Adidas Adizero Afios", "Asics Metaspeed Sky", "Nike Airforce", "Nike dunk low",
               "Air Jordan", "Adidas San Smith", "Reebok club", "Zara chelsea boots", "Tommy Hilfiger formals", "Oxford Black Brogue", "John White Ivy black", "Highgate Tassel Loafers" };
        public static string[] ShoeSize = { "7", "8", "9", "10", "11" };

        public static int GlobalTotalPrice, GlobalQuantityCount, TotalValue, TotalTransactions, TotalShoesSold, TotalTransactionsAmount, AverageTransactions;
        public static int ShoeTypeLength = 15;
        public static int ShoeSizeLength = 5;
        public static int TotalSelectedShoePrice, Quantity, SelectedShoeIndex, SelectedSizeIndex;
        public string SelectedShoeDetails, GlobalSelectedShoeDetails;
        public static int[,] ShoePrice = new int[ShoeTypeLength, ShoeSizeLength];


        // Form Loading
        private void Form1_Load(object sender, EventArgs e)
        {
            // Exceptional Handling for Reading the TextFile
            try
            {
                //Using StreamReader to Read the Array in the TextFile
                using (StreamReader FileRead1 = new StreamReader(PRICE_TXT, true))
                {
                    string[] Read1 = File.ReadAllLines(PRICE_TXT);
                    // Using For loop for Reading the 2D Array TextFile and Assigning the Prices in a 2D Array
                    for (int i = 0; i < ShoeList.Length; i++)
                    {
                        string[] Read2 = Read1[i].Split(',');
                        for (int j = 0; j < ShoeSize.Length; j++)
                        {
                            ShoePrice[i, j] = int.Parse(Read2[j]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Price File Could not be loaded", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                using (StreamReader FileRead2 = new StreamReader(STOCK_TXT, true))
                {
                    string[] Read3 = File.ReadAllLines(PRICE_TXT);
                    // Using For loop for Reading the 2D Array TextFile and Assigning the Shoesize in a 2D Array
                    for (int i = 0; i < ShoeList.Length; i++)
                    {
                        string[] Read4 = Read3[i].Split(',');
                        for (int j = 0; j < ShoeSize.Length; j++)
                        {
                            StockInventory[i, j] = int.Parse(Read4[j]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Stock File could not be Loaded", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int[,] StockInventory = new int[ShoeTypeLength, ShoeSizeLength];

        // Clicking on Add To Cart Button
        private void AddtoCartButton_Click(object sender, EventArgs e)
        {

            // If Condition for Error Handling
            if (ShoeListBox.SelectedIndex != -1)
            {
                if (SizeListBox.SelectedIndex != -1)
                {
                    try
                    {
                        Quantity = int.Parse(QuantityTextbox.Text);
                        if (Quantity > 0)
                        {
                            //Assigning the Values for Writing the Results in the TextFile  
                            SelectedShoeDetails = ShoeListBox.SelectedItem.ToString() + " " + SizeListBox.SelectedItem.ToString() + " " + Quantity.ToString() + " " + TotalSelectedShoePrice.ToString("C") + " - ";
                            GlobalSelectedShoeDetails += SelectedShoeDetails;

                            // Adding the Items Description to the ListView for the Shopping Cart Details
                            ListViewItem ListView = new ListViewItem(ShoeListBox.SelectedItem.ToString());
                            ListView.SubItems.Add(Quantity.ToString());
                            ListView.SubItems.Add(SizeListBox.SelectedItem.ToString());
                            ListView.SubItems.Add(TotalSelectedShoePrice.ToString("C2"));
                            ShoppingCartListView.Items.Add(ListView);

                            // Incrementing the Variables for Summary Function
                            GlobalQuantityCount += Quantity;
                            GlobalTotalPrice += TotalSelectedShoePrice;

                            // Displaying the Total Cart Value in the Textbox
                            TotalCartValueTextBox.Text = GlobalTotalPrice.ToString("C");

                            //Calling the Clear Method for Clearing the Shoelist Tab after Adding the Items to the Cart
                            this.Clear();
                            //QuantityTextbox.Enabled = false;
                            Quantity = 0;
                            Cleared = 0;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Quantity", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Size", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Shoe", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On Clicking Clear Button
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }



        // Method to Clear the Selections, Textboxes
        int Cleared = 0;
        public void Clear()
        {
            Cleared = 1;
            Quantity = 0;
            ShoeListBox.SelectedIndex = -1;
            SizeListBox.SelectedIndex = -1;
            QuantityTextbox.Text = "";
            TotalValueListBox.Text = "";
            QuantityTextbox.Enabled = false;
        }

        // For Dynmaic Changes When the Selection are done
        private void SizeListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ShoeListBox.SelectedIndex != -1)
            {
                this.TotalPrice();
                QuantityTextbox.Enabled = true;
            }
        }

        // For Dynmaic Changes When the Selection are done
        private void ShoeListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (SizeListBox.SelectedIndex != -1)
            {
                this.TotalPrice();
            }
        }

        // For Dynmaic Changes When the Selection are done
        private void QuantityListbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cleared == 0)
                {
                    Quantity = int.Parse(QuantityTextbox.Text);
                }
                if (SizeListBox.SelectedIndex != -1 && ShoeListBox.SelectedIndex != -1 && Quantity > 0)
                {
                    this.TotalPrice();
                    AddtoCartButton.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Quantity", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        // To Calculate the Total Price of the Selected Shoe
        public void TotalPrice()
        {
            if (SizeListBox.SelectedIndex != -1 && ShoeListBox.SelectedIndex != -1 && Quantity > 0)
            {
                QuantityTextbox.Enabled = true;
                SelectedShoeIndex = ShoeListBox.SelectedIndex;
                SelectedSizeIndex = SizeListBox.SelectedIndex;
                int SelectedShoePrice = ShoePrice[SelectedShoeIndex, SelectedSizeIndex];
                TotalSelectedShoePrice = SelectedShoePrice * Quantity;
                TotalValueListBox.Text = TotalSelectedShoePrice.ToString("C2");
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Error Handling for Radio Button Selection and Empty Textbox 
            try
            {
                // Using StreamReader to Read all the Lines of the TextFile and Using for loop to Assign Each Line to a String
                int SearchText = int.Parse(SearchTextBox.Text);
                using (StreamReader TxtFile = new StreamReader(TRANSACTIONS_TXT))
                {
                    string[] Transactions = File.ReadAllLines(TRANSACTIONS_TXT);
                    for (int i = 0; i < Transactions.Length; i++)
                    {
                        if (TransactionNumberRadioButton.Checked)
                        {
                            if (Transactions[i].Contains(SearchTextBox.Text))
                            {
                                DisplayTransactionDetails(Transactions[i]);
                            }
                        }
                        else if (DateRadioButton.Checked)
                        {
                            if (Transactions[i].Contains(SearchTextBox.Text))
                            {
                                DisplayTransactionDetails(Transactions[i]);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Value and Select an Option", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to Display all the Transaction Details in the ListBox
        private void DisplayTransactionDetails(string Transactions)
        {
            //Spliting each line into Individual Items and Displating them
            string[] TransactionValues = Transactions.Split('-');
            SearchResultListBox.Items.Add("Transaction Number:  " + TransactionValues[0]);
            SearchResultListBox.Items.Add("Date & Time:  " + TransactionValues[1]);
            for (int i = 2; i < TransactionValues.Length; i++)
            {
                SearchResultListBox.Items.Add("Order Details:  " + TransactionValues[i]);

            }
            SearchResultListBox.Items.Add("Total Price:  " + TransactionValues[-1]);
            SearchResultListBox.Items.Add("----------------------------------------------------------------------------");
            this.ClearSearch();
        }


        // To Clear the Search Tab, the Radiobuttons and the Text Fields
        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            this.ClearSearch();
        }

        public void ClearSearch()
        {
            DateRadioButton.Checked = false;
            TransactionNumberRadioButton.Checked = false;
            SearchTextBox.Text = "";
            SearchResultListBox.Items.Clear();
        }

        // Method for Creating Unique Transaction Number
        private string UniqueTransactionID()
        {
            Random random = new Random();
            string Aplhabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Concat = Aplhabet[random.Next(25)] + Aplhabet[random.Next(25)] + random.Next(1000, 10000).ToString();
            return Concat;
        }
        
        // On CLicking Place Order Button
        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            // If Condition used for error handling 
            if (ShoppingCartListView.Items.Count > 0)
            {
                string TransactionNo;
                TransactionNo = this.UniqueTransactionID();
                DateTime Date = DateTime.Now;

                // Increasing the Counts for Sales Report Calculation
                TotalTransactions++;
                TotalTransactionsAmount += GlobalTotalPrice;
                AverageTransactions = TotalTransactionsAmount / TotalTransactions;
                TotalShoesSold += GlobalQuantityCount;

                SummaryButton.Enabled = true;

                // Displaying the Order Confirmation Details
                DialogResult OrderConfirmation = MessageBox.Show("Transaction Number :  " + TransactionNo + "\nDate and Time:  " + Date + "\nFinal Price:  " +
                    GlobalTotalPrice.ToString("C2") + "\nDo you want to Confirm the Order?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (OrderConfirmation == DialogResult.Yes)
                {
                    // Using StreamWriter to Write the Transactions Details to the Textfile
                    try
                    {
                        using (StreamWriter TransactionsFile = new StreamWriter(TRANSACTIONS_TXT, true))
                        {
                            TransactionsFile.WriteLine(TransactionNo + " - " + Date + " - " + GlobalSelectedShoeDetails + TotalCartValueTextBox.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot Write as file is Missing", "Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Thank you for purchasing with 'The Shoe Store'.\nHope to see you soon", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShoppingCartListView.Items.Clear();
                    TotalCartValueTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("The Order has been Cancelled", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Add atleast one Shoe to the Cart", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // To Clear the Cart 
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            //Toggling Visibility and Clearing Textboxes
            this.Clear();
            ShoppingCartListView.Items.Clear();
            GlobalTotalPrice = 0;
            TotalCartValueTextBox.Text = "";
        }

        // Checking the Condition and Sending the Parameters to the Method in Form 2 for Sales Report Calculations
        private void SummaryButton_Click(object sender, EventArgs e)
        {

            if (TotalTransactions > 0)
            {
                SalesReportForm f2 = new SalesReportForm();
                f2.SetSummary(TotalTransactions, TotalTransactionsAmount, TotalShoesSold, AverageTransactions);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no Transactions yet", "Transaction Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On Clicking Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}