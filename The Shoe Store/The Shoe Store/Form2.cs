using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharanPranav_BAP_Assignment4
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        // Getting Parameters from the Summary Button click and Displaying the values in this form
        public void SetSummary(int TotalTransactions, int TotalTransactionsAmount, int TotalShoesSold, int AverageTransactions)
        {
            TotalTransactionsTextbox.Text = TotalTransactions.ToString();
            TotalSalesTextBox.Text = TotalTransactionsAmount.ToString("C2");
            NumberofShoesSoldTextBox.Text = TotalShoesSold.ToString();
            AverageTransactionsTextBox.Text = AverageTransactions.ToString("C2");
        }

        //To Exit from the Form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
