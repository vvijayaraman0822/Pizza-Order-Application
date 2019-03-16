/* Vasudev Vijayaraman
 * This form is where the calculation of cost is done and taxes are added to it.
 * Final price can hence be seen. You can also the current order including the toppings.
 * Has an exit button that exits the application.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class OrderInvoiceForm : Form
    {
        public OrderInvoiceForm()
        {
            InitializeComponent();
        }


        // This method is executed when the user clicks the exit Button.
        // The application just exits. This also makes sure the processes gets shut off 
        // correctly

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // This method executes when the user confirms his order after he sees it on the screen.
        // This is where the final price of the pizza is also calculated and printed.

        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            double tax = 0.08; // 8% tax held in a double
            double taxAmount = 0.00; // Tax amount
            double SubTotal = 0.00; // Total Price including tax
            double total = 0.00; // total price before taxes
      
            // This loop adds all the numbers in the list view column to give the total 
            // Easier to calculate the final total rather than keeping track 

            foreach (ListViewItem item in SubTotalListView.Items)
            {
                total += Convert.ToDouble(item.SubItems[1].Text);  // Second column
            }

            taxAmount = tax * total; // Calculating the tax amount
            SubTotal = total + taxAmount; // Calculating the total amount

            PizzaPrice.Text = "$" + total.ToString("0.00"); // Prints upto two decimal places
            taxPriceLabel.Text = "$" + taxAmount.ToString("0.00"); // Printing the tax price
            TotalPrice.Text = "$" + SubTotal.ToString("0.00"); // Printing total price

            // Message Box to show that the user has placed the order succesfully

            MessageBox.Show("Your order has been received by us. Thank you and Enjoy!",
                "VV's Pizza", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                  

        }
    }
}
