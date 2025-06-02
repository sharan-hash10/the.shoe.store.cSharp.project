using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SharanPranav_Assignment3_BAP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Toggling Visibility
            PasswordPanel.Visible = true;
            InvestmentPanel.Visible = false;
        }

        //CONSTANT VARIABLE DECLARATION
        public const int MONTH = 12, TERM1 = 1, TERM2 = 3, TERM3 = 5, TERM4 = 10, NO_OF_LINES = 8;

        public const string PASSWORD = "1234", FILENAME = "Transactions.txt";

        public decimal PRINCIPAL_BAND_VALUE = 100000M, PRINCIPAL_BONUS_VALUE = 1000000m, BONUS_AMOUNT = 25000m, RATE1 = 0.005000m, RATE2 = 0.006250m, RATE3 = 0.007125m, RATE4 = 0.011250m, RATE5 = 0.006000m,
                             RATE6 = 0.007250m, RATE7 = 0.007125m, RATE8 = 0.012500m, MaturityAmount1 = 0m, MaturityAmount2 = 0, MaturityAmount3 = 0m, MaturityAmount4 = 0m;

        //Field Variable Declaration
        public decimal PrincipalAmount = 0m, OverallMaturityIterest = 0m;
        public int Term = 0, TranscationNumber = 0;
        public decimal InterestRate1 = 0m, InterestRate2 = 0m, InterestRate3 = 0m, InterestRate4 = 0m, MaturityInterest =0m, TotalInterest = 0m, TotalPrincipal = 0m;
        public int TotalTerm = 0;

        //On Clicking SignIn Button 
        public int PasswordAttempts = 3;
        private void SignInButton_Click_1(object sender, EventArgs e)
        {
            //Using if elseif Condition for Password Check
            if (PasswordTextBox.Text.Equals(PASSWORD))
            {
                //Using Counter for 3 password try
                PasswordAttempts++;
                PasswordPanel.Visible = false;
                InvestmentPanel.Visible = true;
                PrincipalAmountTextBox.Focus();
            }
            else if (PasswordAttempts > 1)
            {
                PasswordAttempts--;
                MessageBox.Show("The Password you entered is Incorrect\n\n" + "----- " + PasswordAttempts + " Chances left -----", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
            }
            else
            {
                MessageBox.Show("The Password you entered is Incorrect\n\n" + "Sorry, you have exceeded the chances left", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PrincipalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            //To limit the Principal Textbox to 10spaces
            if (PrincipalAmountTextBox.Text.Length > 10)
            {
                PrincipalAmountTextBox.Text = PrincipalAmountTextBox.Text.Substring(0, 10);
                PrincipalAmountTextBox.SelectionStart = PrincipalAmountTextBox.Text.Length;
            }
        }

        //On Clicking Display Button
        private void DisplayButton_Click_1(object sender, EventArgs e)
        {
            //Toggling Visibility
            PrincipalAmountTextBox.Enabled = false;
            ProceedButton.Enabled = true;
            DisplayButton.Enabled = false;

            //Using if Condition for Input Handling
            if (decimal.TryParse(PrincipalAmountTextBox.Text, out PrincipalAmount))
            {
                //Using if elseif Condition for Assigning Interest Rate
                CalculationListBox.Visible = true;
                if (PrincipalAmount <= PRINCIPAL_BAND_VALUE)
                {
                    InterestRate1 = RATE1;
                    InterestRate2 = RATE2;
                    InterestRate3 = RATE3;
                    InterestRate4 = RATE4;
                }
                else if (PrincipalAmount > PRINCIPAL_BAND_VALUE)
                {
                    InterestRate1 = RATE5;
                    InterestRate2 = RATE6;
                    InterestRate3 = RATE7;
                    InterestRate4 = RATE8;
                }

                //Calling MaturityCalculation for Calculating Compound Interest 
                PrincipalAmount = decimal.Parse(PrincipalAmountTextBox.Text);
                MaturityAmount1 = MaturityCalculation(InterestRate1, TERM1);
                MaturityAmount2 = MaturityCalculation(InterestRate2, TERM2);
                MaturityAmount3 = MaturityCalculation(InterestRate3, TERM3);
                MaturityAmount4 = MaturityCalculation(InterestRate4, TERM4);

                //Using if Condition for Checking adding Bonus 
                if (PrincipalAmount >= PRINCIPAL_BONUS_VALUE)
                {
                    BonusLabel.Text = "Є25000 bonus applied for 5 years and 10 years term";
                    MaturityAmount3 += BONUS_AMOUNT;
                    MaturityAmount4 += BONUS_AMOUNT;
                }

                //Displaying the Selection Items in Listbox
                CalculationListBox.Items.Add(" Term Period: " + TERM1 + " Year" + "     Interest Rate: " + InterestRate1 + "%     Maturity Amount: " + MaturityAmount1.ToString("0.00"));
                CalculationListBox.Items.Add(" Term Period: " + TERM2 + " Years" + "     Interest Rate: " + InterestRate2 + "%     Maturity Amount: " + MaturityAmount2.ToString("0.00"));
                CalculationListBox.Items.Add(" Term Period: " + TERM3 + " Years" + "     Interest Rate: " + InterestRate3 + "%     Maturity Amount: " + MaturityAmount3.ToString("0.00"));
                CalculationListBox.Items.Add(" Term Period: " + TERM4 + " Years" + "    Interest Rate: " + InterestRate4 + "%    Maturity Amount: " + MaturityAmount4.ToString("0.00"));
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrincipalAmountTextBox.Enabled = true;
                DisplayButton.Enabled = true;
                PrincipalAmountTextBox.Text = string.Empty;
                PrincipalAmountTextBox.Focus();
            }
        }

        //On Clicking Clear Button
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            //Toggling Visibility, Clearing Textboxes
            PrincipalAmountTextBox.Enabled = true;
            PrincipalAmountTextBox.Text = "";
            CalculationListBox.Items.Clear();
            DisplayButton.Enabled = true;
            ProceedButton.Enabled = false;
            BonusLabel.Text = "";
        }

        //On Clicking Proceed Button
        private void ProceedButton_Click_1(object sender, EventArgs e)
        {

            //Using if Condition for Input Handling
            if (CalculationListBox.SelectedIndex != -1)
            {
                //Toggling Visibility, Clearing Textboxes
                CustomerDetailsGroupBox.Visible = true;
                CalculationListBox.Enabled = false;
                ClearButton.Enabled = false;
                ProceedButton.Enabled = false;
                BonusLabel.Text = "";

                //Assigning Unique Random Numbers
                String RandomNumber;
                Random random = new Random();
                RandomNumber = random.Next(100000, 1000000).ToString();
                TransactionTextBox.Text = RandomNumber.ToString();
            }
            else
            {
                MessageBox.Show("Please Select a Term Period", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On Clicking Submit Button
        DialogResult result;
        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            //Calling tempselection
            this.tempselection();
            string TransactionNo = TransactionTextBox.Text, Name = NameTextBox.Text, EmailID = EmailTextBox.Text;
            
            //Using try catch for Input Validation
            try
            {
                int ContactNo = int.Parse(ContactTextBox.Text);
                int Date = int.Parse(DateTextBox.Text);

                //Nested if for Input validation
                if (Name != "")
                {
                    if (this.EmailTextBox.Text.Contains('@') || this.EmailTextBox.Text.Contains('.'))
                    {
                        result = MessageBox.Show(("Transaction Number: " + TransactionNo + "\nName: " + Name + "\nEmail Address: " + EmailID + "\nContact Number: " + ContactNo.ToString() + "\nPrincipal Amount: " + PrincipalAmount + "\nRate Of Interest: " + tempInterest + "%\nTerm Period: " + tempTerm + "\nMaturity Amount: " + tempMaturity.ToString("0.00") + "\n\nDo you want to Confirm the Investment?"), "Booking Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        
                        //On Clicking Yes from Dialog
                        if (result == DialogResult.Yes)
                        {
                            //Using StreamWriter to Append Text to Textfile 
                            using (StreamWriter CustomerDetailsTextFile = new StreamWriter("CustomerDetails.txt", true))
                            {
                                CustomerDetailsTextFile.WriteLine(TransactionNo);
                                CustomerDetailsTextFile.WriteLine(EmailID);
                                CustomerDetailsTextFile.WriteLine(Date.ToString());
                                CustomerDetailsTextFile.WriteLine(Name);
                                CustomerDetailsTextFile.WriteLine(PrincipalAmount);
                                CustomerDetailsTextFile.WriteLine(tempInterest);
                                CustomerDetailsTextFile.WriteLine(tempTerm);
                                CustomerDetailsTextFile.WriteLine(tempMaturity);
                                CustomerDetailsTextFile.WriteLine(ContactNo.ToString());
                            }

                            //Calculation for Accuring Interest
                            decimal TotalMaturityInterest = tempMaturity - PrincipalAmount;
                            OverallMaturityIterest += TotalMaturityInterest;

                            ////Toggling Visibility, Clearing Textboxes
                            MessageBox.Show("The Details have been saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SearchGroupBox.Visible = true;
                            SummaryGroupBox.Visible = true;
                            NameTextBox.Text = string.Empty;
                            EmailTextBox.Text = string.Empty;
                            ContactTextBox.Text = string.Empty;
                            DateTextBox.Text = string.Empty;
                            TransactionTextBox.Text = string.Empty;
                            PrincipalAmountTextBox.Text = "";
                            CalculationListBox.Items.Clear();
                            PrincipalAmountTextBox.Enabled = true;
                            DisplayButton.Enabled = true;
                            CalculationListBox.Visible = false;
                            ProceedButton.Enabled = true;
                            CustomerDetailsGroupBox.Visible = false;
                            CalculationListBox.Enabled = true;
                            ClearButton.Enabled = true;
                        }
                        else
                        {
                            //Toggling Visibility, Clearing Textboxes
                            NameTextBox.Text = string.Empty;
                            EmailTextBox.Text = string.Empty;
                            ContactTextBox.Text = string.Empty;
                            DateTextBox.Text = string.Empty;
                            TransactionTextBox.Text = string.Empty;
                            PrincipalAmountTextBox.Text = "";
                            CalculationListBox.Items.Clear();
                            PrincipalAmountTextBox.Enabled = true;
                            DisplayButton.Enabled = true;
                            CalculationListBox.Visible = false;
                            ProceedButton.Enabled = false;
                            CustomerDetailsGroupBox.Visible = false;
                            CalculationListBox.Enabled = true;
                            ClearButton.Enabled = true;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please Enter a valid Email ID", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EmailTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter your Name", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NameTextBox.Focus();
                }

            }
            catch(Exception)
            {
                    MessageBox.Show("Please Enter a valid Contact and Date", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //On Clicking Search Button
        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            // Declaring Local Variables, Using StreamWriter
            string TransactionNumber, EmailID, Date;
            StreamReader datastream;
            SearchResultListBox.Items.Clear();

            //Exceptional Handling
            try
            {

                datastream = File.OpenText("CustomerDetails.txt");
                SearchResultListBox.Items.Add("Search Result:");

                //Using while for Checking the Textfile to the End
                while (!datastream.EndOfStream)
                {
                    bool found = false;
                    TransactionNumber = datastream.ReadLine();
                    EmailID = datastream.ReadLine();
                    Date = datastream.ReadLine();

                    //Using if elseif condition for finding the Records and Assigning Found to True
                    if (EmailRadioButton.Checked)
                    {
                        found = SearchTextBox.Text.Equals(EmailID);
                    }
                    else if (TransactionRadioButton.Checked)
                    {
                        found = SearchTextBox.Text.Equals(TransactionNumber);
                    }
                    else if(DateRadioButton.Checked)
                    {
                        found = SearchTextBox.Text.Equals(Date);
                    }

                    //If found, Displaying the Records and Skipping Other Unwanted Records
                    if (found)
                    {
                        SearchResultListBox.Items.Add("\n");
                        SearchResultListBox.Items.Add("Transaction: ");
                        SearchResultListBox.Items.Add(TransactionNumber);
                        SearchResultListBox.Items.Add(EmailID);
                        SearchResultListBox.Items.Add(Date);
                        for (int i = 3; i <= NO_OF_LINES; i++)
                        {
                            string temp = datastream.ReadLine();
                            if (found)
                            {
                                SearchResultListBox.Items.Add(temp);
                            }
                        }
                    }
                }
            }
            catch
            {
                throw new Exception();
            }
        }

        //On Clicking Clear Button
        private void Clear2Button_Click(object sender, EventArgs e)
        {

            ////Toggling Visibility, Clearing Textboxes
            SearchTextBox.Text = "";
            SearchTextBox.Focus();
            SearchResultListBox.Items.Clear();
            EmailRadioButton.Checked = false;
            TransactionRadioButton.Checked = false;
            DateRadioButton.Checked = false;
        }

        //On Clicking Summary Button
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            //Assigning Local Variables
            decimal AveragePrincipalAmount = 0m;
            int AverageTerms = 0;
            int TransactionNo = 0;
            StreamReader datastream;
            string TransactionNumber = "";
            decimal TotalFilePrincipal = 0m;
            int TotalFileTerm = 0;
            SummaryListBox.Items.Clear();

            //Displaying the Records and Skipping Other Unwanted Records and Incrementing the variables for Summary Calculation
            datastream = File.OpenText("CustomerDetails.txt");
            SummaryListBox.Items.Add("Transaction Numbers:");
            while (!datastream.EndOfStream)
            {
                TransactionNumber = datastream.ReadLine();
                SummaryListBox.Items.Add(TransactionNumber);
                for (int i = 1; i <= NO_OF_LINES; i++)
                {
                    if (i == 4)
                    {
                        TotalPrincipal = decimal.Parse(datastream.ReadLine());
                        TotalFilePrincipal += TotalPrincipal;
                    }
                    else if(i == 6)
                    {
                        TotalTerm = int.Parse(datastream.ReadLine());
                        TotalFileTerm += TotalTerm;
                    }
                    else
                    {
                        datastream.ReadLine();
                    }
                    
                }
                TransactionNo++;
            }
            SummaryListBox.Items.Add("\n");
            SummaryListBox.Items.Add("Total Principal Amount: " + TotalFilePrincipal.ToString("C"));
            SummaryListBox.Items.Add("Total Accuring Interest: " + OverallMaturityIterest.ToString("C"));
            AveragePrincipalAmount = TotalFilePrincipal / TransactionNo;
            SummaryListBox.Items.Add("Average Principal Amount: " + AveragePrincipalAmount.ToString("C"));
            AverageTerms = (TotalFileTerm * MONTH) / TransactionNo;
            SummaryListBox.Items.Add("Average Number of Terms: " + AverageTerms.ToString() + " Months");
        }

        //Compound Interest Calculation
        private decimal MaturityCalculation(decimal Rate, int Term)
        {
            decimal MonthlyInterest = Rate / 100;
            return PrincipalAmount * (decimal)Math.Pow((double)(1 + MonthlyInterest), Term * MONTH);
        }


        //For Assigning values to the Changing Variables
        decimal tempInterest = 0m, tempTerm = 0m, tempMaturity = 0m;
        public void tempselection()
        {
            if (CalculationListBox.SelectedIndex == 0)
            {
                tempInterest = InterestRate1;
                tempTerm = TERM1;
                tempMaturity = MaturityAmount1;
            }
            else if (CalculationListBox.SelectedIndex == 1)
            {
                tempInterest = InterestRate2;
                tempTerm = TERM2;
                tempMaturity = MaturityAmount2;
            }
            else if (CalculationListBox.SelectedIndex == 2)
            {
                tempInterest = InterestRate3;
                tempTerm = TERM3;
                tempMaturity = MaturityAmount3;
            }
            else
            {
                tempInterest = InterestRate4;
                tempTerm = TERM4;
                tempMaturity = MaturityAmount4;
            }
        
        }

        //On Clicking Exit Button
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


