/* Vasudev Vijayaraman
 * 07/11/2017
 * Dr. Catherine Stringfellow
 * C# Programming
 * This is a program that replicates a pizza ordering app. 
 * User is able to select type, select toppings, select size, options for the customized pizza and
 * Select halves of the pizza they want topping to be added on. This is achieved by using RadioButtons, 
 * switch cases and mouse event handlers */


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
    public partial class PizzaOrderForm : Form
    {

        // Declaring all the images to resources so it can be used later
        // Its stored in specific variables and accessed through the Resources folder
        public Image leftSideJalapeno = Properties.Resource1.LeftSideJalapeno;
        public Image leftSideUnselected = Properties.Resource1.button_left;
        public Image leftSideSelected = Properties.Resource1.button_left_selected;
        public Image leftSideSpinach = Properties.Resource1.LeftSideSpinach;
        public Image RHJalapeno = Properties.Resource1.RHJalapeno;
        public Image RHOnion = Properties.Resource1.RHOnion;
        public Image RHPepper = Properties.Resource1.RHPepper;
        public Image RHMushroom = Properties.Resource1.RHMushroom;
        public Image RHPineapple = Properties.Resource1.RHPineapple;
        public Image WholeUnselected = Properties.Resource1.button_whole;
        public Image leftSideOnion = Properties.Resource1.LeftSideOnion;
        public Image Wholeselected = Properties.Resource1.button_whole_selected;
        public Image RightUnselected = Properties.Resource1.button_right;
        public Image RightSelected = Properties.Resource1.button_right_selected;
        public Image LHPineapple = Properties.Resource1.LHPineapple;
        public Image OnionPizza = Properties.Resource1.OnionPizza;
        public Image SpinachPizza = Properties.Resource1.SpinachPizza1;
        public Image PineapplePizza = Properties.Resource1.PineapplePizza1;
        public Image JalapenoPizza = Properties.Resource1.JalapenoPizza;
        public Image PeppersPizza = Properties.Resource1.GreenPepperPizza;
        public Image MushroomPizza = Properties.Resource1.MushroomPizza;
        public Image DefaultPizza = Properties.Resource1.DefaultPizza;
        public Image LeftHalfPepper = Properties.Resource1.LeftHalfPepper;

        // Initializing the toppings to its cost
        // Double type since it could have decimal points
        public double Personal = 5.99;
        public double Small = 7.99;
        public double Medium = 9.99;
        public double Large = 12.99;
        public double Alfredo = 0.99;
        public double Tomato = 0.99;
        public double Cheddar = 0.99;
        public double Mozarella = 0.99;
        public double Feta = 0.99;
        public double Chicken = 0.99;
        public double Pepperoni = 0.99;
        public double Sausage = 0.99;
        public double Onions = 0.99;
        public double Peppers = 0.99;
        public double Mushroom = 0.99;
        public double Jalapeno = 0.99;
        public double Spinach = 0.99;
        public double Pineapple = 0.99;

        // Instanting the order invoice form
        public static OrderInvoiceForm order = new OrderInvoiceForm();

        public static double Cost = 0.00; // Keeps track of total cost before Tax
        public static double Subtotal = 0.00; // Keeps track of cost after
        public static double TaxRate = 0.08; // Tax percent 8%

        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        // This method clears the form by creating a instance of the form
        // by using new keyword
        private void ClearButton_Click(object sender, EventArgs e)
        {

            PizzaOrderForm NewForm = new PizzaOrderForm();
            NewForm.Show();  // Show the new form
            this.Dispose(false); // Get rid of the old form

        }

        // This method takes care of everything that happens once the user clicks the submit order button'
        // It checks to see what radio button clicked and handles the case. Also it prints on the order invoice
        // form and switches to that form and hides the current form
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // If personal size pizza radio button is checked
            if (PersonalRadioButton.Checked == true)
            {
                // Print on the Order Invoice form
                ListViewItem item = new ListViewItem("Personal Pizza Size");
                item.SubItems.Add("5.99");
                order.SubTotalListView.Items.Add(item); // add it to the list view
            }
            // If small size pizza radio button is checked
            else if (SmallRadioButton.Checked == true)
            {
                ListViewItem item = new ListViewItem("Small Pizza Size");
                item.SubItems.Add("7.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If medium size pizza radio button is checked
            else if (MediumRadioButton.Checked == true)
            {
                ListViewItem item = new ListViewItem("Medium Pizza Size");
                item.SubItems.Add("9.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If large size pizza radio button is checked
            else if (LargeRadioButton.Checked == true)
            {
                ListViewItem item = new ListViewItem("Large Pizza Size");
                item.SubItems.Add("12.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If cheddar topping is checked 
            if (CheddarCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cheddar Cheese Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Alfredo topping is checked 
            if (AlfredoCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Alfredo Sauce");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Tomato topping is checked 
            if (TomatoCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Tomato Sauce");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Mozarella topping is checked 
            if (MozarellaCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mozarella Cheese Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Feta topping is checked 
            if (FetaCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Feta Cheese Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If chicken topping is checked 
            if (ChickenCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If pepperoni topping is checked 
            if (PepperoniCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pepperoni Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Sausage topping is checked 
            if (SausageCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sausage Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Onion topping is checked 
            if (OnionCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Mushroom topping is checked 
            if (MushroomCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Mushroom Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Spinach topping is checked 
            if (SpinachCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Spinach Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Pineapple topping is checked 
            if (PineapplecheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Pineapple Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If GreenPepper topping is checked 
            if (GreenPeppersCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Green Peppers Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }

            // If Jalapeno topping is checked 
            if (JalapenoCheckBox.Checked == true)
            {
                ListViewItem item = new ListViewItem("Jalapeno Topping");
                item.SubItems.Add("0.99");
                order.SubTotalListView.Items.Add(item);
            }


            order.Show(); // Shows the order invoice form because it is already instantiated
            this.Hide(); // Hides the current form


        }

        // This method handles the case when Alfredo Check box is checked.
        // This is designed in such a way that the user can either choose alfredo
        // or tomato sauce. 

        private void AlfredoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (AlfredoCheckBox.Checked == true)
            {
                TomatoCheckBox.Enabled = false;
            }

            else if (AlfredoCheckBox.Checked == false)
            {
                TomatoCheckBox.Enabled = true;
            }

        }

        // This method handles the case when Tomato Check box is checked.
        // This is designed in such a way that the user can either choose alfredo
        // or tomato sauce. 

        private void TomatoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (TomatoCheckBox.Checked == true)
            {
                AlfredoCheckBox.Enabled = false;

            }
            else if (TomatoCheckBox.Checked == false)
            {
                AlfredoCheckBox.Enabled = true;

            }
        }

        // This method happens when the user wants to build their own pizza
        // This program is built in such a way that the group containing toppings
        // gets enabled only when the user chooses to customize their pizza

        private void BuildOwnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BuildOwnRadioButton.Checked == true)
            {
                BuildOwnGroupBox.Enabled = true;
            }
            else if (BuildOwnRadioButton.Checked == false)
            {
                BuildOwnGroupBox.Enabled = false;
            }
        }

        // This is the method that takes care when the user wants to put onions
        // on the left hand side of the pizza. It prints a picture accordingly

        private void OnionsLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (OnionCheckBox.Checked)
            {

                OnionsLeftPictureBox.Image = leftSideSelected; // Select the left image 
                OnionsWholePictureBox.Image = WholeUnselected; // Unselect the other
                OnionsRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = leftSideOnion; // Prints the image

            }
        }

        // This is the method that takes care when the user wants to put onions
        // on the whole pizza. It prints a picture accordingly

        private void OnionsWholePictureBox_Click(object sender, EventArgs e)
        {
            if (OnionCheckBox.Checked)
            {
                OnionsWholePictureBox.Image = Wholeselected; // Select the left image
                OnionsLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                OnionsRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = OnionPizza;


            }
        }


        // This is the method that takes care when the user wants to put onions
        // on the right hand side of the pizza. It prints a picture accordingly

        private void OnionsRightPictureBox_Click(object sender, EventArgs e)
        {
            if (OnionCheckBox.Checked)
            {

                OnionsRightPictureBox.Image = RightSelected; // Select the left image
                OnionsLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                OnionsWholePictureBox.Image = WholeUnselected; // Unselect the other
                PizzaPictureBox.Image = RHOnion;
            }
        }

        // This is the method that takes care when the user wants to put Green peppers
        // on the left hand side of the pizza. It prints a picture accordingly

        private void PeppersLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (GreenPeppersCheckBox.Checked)
            {
                PeppersLeftPictureBox.Image = leftSideSelected;
                PeppersWholePictureBox.Image = WholeUnselected; // Unselect the other
                PeppersRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = LeftHalfPepper;
            }
        }

        // This is the method that takes care when the user wants to put Green peppers
        // on the whole pizza. It prints a picture accordingly

        private void PeppersWholePictureBox_Click(object sender, EventArgs e)
        {
            if (GreenPeppersCheckBox.Checked)
            {
                PeppersWholePictureBox.Image = Wholeselected;
                PeppersLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                PeppersRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = PeppersPizza;
            }
        }

        // This is the method that takes care when the user wants to put Green peppers
        // on the right hand side of the pizza. It prints a picture accordingly

        private void PeppersRightPictureBox_Click(object sender, EventArgs e)
        {
            if (GreenPeppersCheckBox.Checked)
            {
                PeppersRightPictureBox.Image = RightSelected;
                PeppersLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                PeppersWholePictureBox.Image = WholeUnselected; // Unselect the other
                PizzaPictureBox.Image = RHPepper;
            }

        }

        // This is the method that takes care when the user wants to put Mushrooms
        // on the left hand side of the pizza. Decided not to have a picture for this for
        // a change

        private void MushroomLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (MushroomCheckBox.Checked)
            {
                MushroomLeftPictureBox.Image = leftSideSelected;
                MushroomWholePictureBox.Image = WholeUnselected; // Unselect the other
                MushroomRightPictureBox.Image = RightUnselected; // Unselect the other
            }

        }

        // This is the method that takes care when the user wants to put Jalapenos
        // on the left hand side of the pizza. It prints a picture accordingly

        private void JalapenoLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (JalapenoCheckBox.Checked)
            {
                JalapenoLeftPictureBox.Image = leftSideSelected;
                JalapenoWholePictureBox.Image = WholeUnselected; // Unselect the other
                JalapenoRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = leftSideJalapeno;
            }
        }

        // This is the method that takes care when the user wants to put Spinach
        // on the left hand side of the pizza. It prints a picture accordingly

        private void SpinachLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (SpinachCheckBox.Checked)
            {
                SpinachLeftPictureBox.Image = leftSideSelected;
                SpinachWholePictureBox.Image = WholeUnselected; // Unselect the other
                SpinachRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = leftSideSpinach;

            }
        }

        // This is the method that takes care when the user wants to put Pineapple
        // on the left hand side of the pizza. It prints a picture accordingly. Pineapple 
        // does not exist in pizza btw. 

        private void PineappleLeftPictureBox_Click(object sender, EventArgs e)
        {
            if (PineapplecheckBox.Checked)
            {
                PineappleLeftPictureBox.Image = leftSideSelected;
                PineappleWholePictureBox.Image = WholeUnselected; // Unselect the other
                PineappleRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = LHPineapple;
            }
        }

        // This is the method that takes care when the user wants to put Mushrooms
        // on the whole pizza. It prints a picture accordingly

        private void MushroomWholePictureBox_Click(object sender, EventArgs e)
        {
            if (MushroomCheckBox.Checked)
            {
                MushroomWholePictureBox.Image = Wholeselected;
                MushroomLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                MushroomRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = MushroomPizza;
            }
        }

        // This is the method that takes care when the user wants to put Jalapeno
        // on the whole pizza. It prints a picture accordingly

        private void JalapenoWholePictureBox_Click(object sender, EventArgs e)
        {
            if (JalapenoCheckBox.Checked)
            {
                JalapenoWholePictureBox.Image = Wholeselected;
                JalapenoLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                JalapenoRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = JalapenoPizza;
            }
        }

        // This is the method that takes care when the user wants to put Spinach
        // on the whole pizza. It prints a picture accordingly

        private void SpinachWholePictureBox_Click(object sender, EventArgs e)
        {
            if (SpinachCheckBox.Checked)
            {
                SpinachWholePictureBox.Image = Wholeselected;
                SpinachLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                SpinachRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = SpinachPizza;
            }
        }

        // This is the method that takes care when the user wants to put Pineapple
        // on the whole pizza. It prints a picture accordingly. Nasty Pineapple again.

        private void PineappleWholePictureBox_Click(object sender, EventArgs e)
        {
            if (PineapplecheckBox.Checked)
            {
                PineappleWholePictureBox.Image = Wholeselected;
                PineappleLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                PineappleRightPictureBox.Image = RightUnselected; // Unselect the other
                PizzaPictureBox.Image = PineapplePizza;
            }
        }

        // This is the method that takes care when the user wants to put Mushrooms
        // on the right hand side of the pizza. It prints a picture accordingly

        private void MushroomRightPictureBox_Click(object sender, EventArgs e)
        {
            if (MushroomCheckBox.Checked)
            {
                MushroomRightPictureBox.Image = RightSelected;
                MushroomLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                MushroomWholePictureBox.Image = WholeUnselected; // Unselect the other
                PizzaPictureBox.Image = RHMushroom;
            }
        }

        // This is the method that takes care when the user wants to put Jalapeno
        // on the right hand side of the pizza. It prints a picture accordingly

        private void JalapenoRightPictureBox_Click(object sender, EventArgs e)
        {
            if (JalapenoCheckBox.Checked)
            {
                JalapenoRightPictureBox.Image = RightSelected;
                JalapenoLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                JalapenoWholePictureBox.Image = WholeUnselected; // Unselect the other
                PizzaPictureBox.Image = RHJalapeno;
            }
        }

        // This is the method that takes care when the user wants to put Spinach
        // on the right hand side of the pizza. No picture printed.

        private void SpinachRightPictureBox_Click(object sender, EventArgs e)
        {
            if (SpinachCheckBox.Checked)
            {
                SpinachRightPictureBox.Image = RightSelected;
                SpinachLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                SpinachWholePictureBox.Image = WholeUnselected; // Unselect the other
            }
        }

        // This is the method that takes care when the user wants to put Pineapple
        // on the right hand side of the pizza. It prints a picture accordingly.
        // Atleast you chose it just to put it on one side.

        private void PineappleRightPictureBox_Click(object sender, EventArgs e)
        {
            if (PineapplecheckBox.Checked)
            {
                PineappleRightPictureBox.Image = RightSelected;
                PineappleLeftPictureBox.Image = leftSideUnselected; // Unselect the other
                PineappleWholePictureBox.Image = WholeUnselected; // Unselect the other
                PizzaPictureBox.Image = RHPineapple;
            }
        }

        // This method executes when the Pizza Order form loads. It  prints a default pizza
        // image. 

        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {
            PizzaPictureBox.Image = DefaultPizza;
        }
    
    }
}
