
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNameSpace
{
    public partial class SummaryForm : Form
    {
        decimal totalSalesDecimal;
        int numberOrdersInteger, drinksSoldInteger;

        public decimal TotalSales
        {
            set
            {
                totalSalesDecimal = value;
            }
        }

        public int NumberOrders
        {
            set
            {
                numberOrdersInteger = value;
            }
        }

        public int DrinksSold
        {
            set
            {
                drinksSoldInteger = value;
            }
        }

        public SummaryForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Close the summary form.

            this.Close();
        }

        private void SummaryForm_Activated(object sender, EventArgs e)
        {
            // Get and display the summary data.

            drinksSoldTextBox.Text = drinksSoldInteger.ToString();
            numberOrdersTextBox.Text = numberOrdersInteger.ToString();
            totalSalesTextBox.Text = totalSalesDecimal.ToString("C");
        }
    }
}