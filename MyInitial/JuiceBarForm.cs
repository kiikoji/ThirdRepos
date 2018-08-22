
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyNameSpace
{
    public partial class JuiceBarForm : Form
    {
        // Declare class variables.
        decimal itemSizeDecimal, itemPriceDecimal, totalOrderDecimal, 
            totalSalesDecimal;
        int drinkTotalInteger, orderTotalInteger, itemCountInteger;
        public struct OrderItem
        {
            public string sizeString;
            public string drinkString;
            public int quantityInteger;
            public decimal priceDecimal;
        }
        // Create an array for the items in the order.
        OrderItem[] drinkOrder = new OrderItem[20];

        public JuiceBarForm()
        {
            InitializeComponent();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            // Add the current item price and quantity to the order.

            if (noSizeRadioButton.Checked 
                || drinkTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a drink and size.", 
                    "Missing required entry");
            }
            else
            {
                try
                {
                    drinkOrder[itemCountInteger].quantityInteger 
                        = int.Parse(quantityTextBox.Text);
                    if (drinkOrder[itemCountInteger].quantityInteger != 0)
                    {
                        drinkOrder[itemCountInteger].drinkString 
                            = drinkTypeComboBox.SelectedItem.ToString();
                        drinkOrder[itemCountInteger].priceDecimal 
                            = itemPriceDecimal;
                        totalOrderDecimal += itemPriceDecimal 
                            * drinkOrder[itemCountInteger].quantityInteger;
                        drinkTotalInteger += drinkOrder[itemCountInteger]
                            .quantityInteger;
                        clearForNextItem();
                        orderCompleteButton.Enabled = true;
                        itemCountInteger++;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.", 
                            "Missing Required Entry");
                        quantityTextBox.Focus();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid Quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }
            }
        }

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {
            // Order is complete, add to summary and clear order.

            // Verify that the last item was added to the total.
            if (!noSizeRadioButton.Checked 
                && drinkTypeComboBox.SelectedIndex != -1)
            {
                DialogResult responseDialogResult;
                string messageString = "Current item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                    "Verify Last Drink Purchase", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }
            // Display receipt for items purchased in this order.
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            // Add to summary totals.
            orderTotalInteger++;
            totalSalesDecimal += totalOrderDecimal;

            // Reset all for new order.
            summaryButton.Enabled = true;
            summaryToolStripMenuItem.Enabled = true;
            orderCompleteButton.Enabled = false;
            orderCompleteToolStripMenuItem.Enabled = false;
            totalOrderDecimal = 0m;
            itemCountInteger = 0;
            // Clear order array.
            for (int orderInteger = 0; orderInteger < 20; orderInteger++)
            {
                drinkOrder[orderInteger].quantityInteger = 0;
                drinkOrder[orderInteger].priceDecimal = 0;
                drinkOrder[orderInteger].drinkString = "";
            }
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Display the summary information in a summary form.

            // Display the summary form.
            SummaryForm aSummaryForm = new SummaryForm();

            aSummaryForm.DrinksSold = drinkTotalInteger;
            aSummaryForm.NumberOrders = orderTotalInteger;
            aSummaryForm.TotalSales = totalSalesDecimal;
            aSummaryForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the application.

            this.Close();
        }

        private void clearForNextItem()
        {
            // Clear option buttons, check boxes, text boxes.

            noSizeRadioButton.Checked = true;
            drinkTypeComboBox.SelectedIndex = -1;
            vitaminPackCheckBox.Checked = false;
            energyBoosterCheckBox.Checked = false;
            ladiesCheckBox.Checked = false;
            itemPriceTextBox.Clear();
            quantityTextBox.Text = "1";
        }

        private void twelveOunceRadioButton_CheckedChanged(object sender, 
            EventArgs e)
        {
            // Calculate and display the price for the selected item. 
            // Handles all size radio buttons.

            // Cast the sender to a RadioButton type.
            RadioButton selectedSizeRadioButton = (RadioButton)sender;

            switch (selectedSizeRadioButton.Name)
            {
                case "twelveOunceRadioButton":
                    itemSizeDecimal = 3m;
                    drinkOrder[itemCountInteger].sizeString = "12 oz";
                    break;
                case "sixteenOunceRadioButton":
                    itemSizeDecimal = 3.5m;
                    drinkOrder[itemCountInteger].sizeString = "16 oz";
                    break;
                case "twentyOunceRadioButton":
                    itemSizeDecimal = 4m;
                    drinkOrder[itemCountInteger].sizeString = "20 oz";
                    break;
            }
            itemPriceDecimal = itemSizeDecimal + findExtrasPrice();
            itemPriceTextBox.Text = itemPriceDecimal.ToString("C");
        }

        private decimal findExtrasPrice()
        {
            // Find price for additives.
            decimal extrasDecimal = 0m;

            if (vitaminPackCheckBox.Checked)
                extrasDecimal += .5m;
            if (energyBoosterCheckBox.Checked)
                extrasDecimal += .5m;
            if (ladiesCheckBox.Checked)
                extrasDecimal += .5m;

            return extrasDecimal;
        }

        private void vitaminPackCheckBox_CheckedChanged(object sender, 
            EventArgs e)
        {
            // Check price of additives and display current price.

            drinkOrder[itemCountInteger].priceDecimal 
                = itemSizeDecimal + findExtrasPrice();
            itemPriceTextBox.Text = drinkOrder[itemCountInteger]
                .priceDecimal.ToString("C");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display about form.
            AboutBox1 aboutForm = new AboutBox1();

            aboutForm.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the label's font.

            // Initialize the dialog box.
            fontDialog1.Font = titleLabel.Font;
            // Display the dialog box.
            fontDialog1.ShowDialog();
            // Assign the new font.
            titleLabel.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Change the form's ForeColor.
            // Applies to all conrols on the form that haven't had their
            //    ForeColor explicitly modified.

            // Initialize the dialog box.
            colorDialog1.Color = this.ForeColor;
            // Display the dialog box.
            colorDialog1.ShowDialog();
            // Assign the new color.
            this.ForeColor = colorDialog1.Color;
        }

        private void printDocument1_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Display the invoice in a Print Preview dialog box.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = (float)printFont.GetHeight() + 2f;
            float column1Float = e.MarginBounds.Left;
            float yFloat = e.MarginBounds.Top;
            float column2Float = 200f;
            float column3Float = 250f;
            float column4Float = 500f;
            float column5Float = 600f;
            string lineString;

            // Set up heading lines.
            lineString = "Look Sharp Fitness Center";
            e.Graphics.DrawString(lineString, headingFont, Brushes.Black,
                column3Float, yFloat);
            yFloat += (lineHeightFloat * 2);
            lineString = "Drink Sales Receipt  " + DateTime.Today.ToString("d");
            e.Graphics.DrawString(lineString, printFont, Brushes.Black,
                column3Float, yFloat);
            yFloat += (lineHeightFloat * 2);
            e.Graphics.DrawString("Quantity", headingFont, Brushes.Black,
                column1Float, yFloat);
            e.Graphics.DrawString("Size", headingFont, Brushes.Black,
                column2Float, yFloat);
            e.Graphics.DrawString("Drink Type", headingFont, Brushes.Black,
                column3Float, yFloat);
            e.Graphics.DrawString("Unit Price", headingFont, Brushes.Black,
                column4Float, yFloat);
            e.Graphics.DrawString("Extended Price", headingFont, Brushes.Black,
                column5Float, yFloat);
            column5Float += 30;
            yFloat += (lineHeightFloat * 2);

            // Loop through the transactions.
            foreach (OrderItem oneOrder in drinkOrder)
            {
                // Only print valid orders.
                if (oneOrder.quantityInteger != 0)
                {
                    // Set up a line.
                    // Quantity.
                    e.Graphics.DrawString(oneOrder.quantityInteger.ToString(),
                        printFont, Brushes.Black, column1Float, yFloat);

                    // Size.
                    e.Graphics.DrawString(oneOrder.sizeString,
                        printFont, Brushes.Black, column2Float, yFloat);

                    // Drink type.
                    e.Graphics.DrawString(oneOrder.drinkString, printFont,
                        Brushes.Black, column3Float, yFloat);

                    // Unit Price.
                    e.Graphics.DrawString(oneOrder.priceDecimal.ToString("c"),
                        printFont, Brushes.Black, column4Float, yFloat);

                    // Extended Price.
                    decimal extendedPriceDecimal = oneOrder.priceDecimal 
                        * oneOrder.quantityInteger;
                    e.Graphics.DrawString(extendedPriceDecimal.ToString("c"),
                        printFont, Brushes.Black, column5Float, yFloat);

                    // Increment the Y position for the next line.
                    yFloat += (lineHeightFloat * 2);
                }
            }

            // Print total.
            e.Graphics.DrawString("Total: ", headingFont, Brushes.Black, 
                column1Float, yFloat);
            e.Graphics.DrawString(totalOrderDecimal.ToString("c"), printFont, 
                Brushes.Black, column5Float, yFloat);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}