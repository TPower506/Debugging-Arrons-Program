using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilburyLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetTrip()
        {
            //Hide the trip information groupbox
            grpTripInfo.Visible = false;

            //Check the cuba radio buton
            radCuba.Checked = true;

            //Blank out the textbox for people
            txtPeople.Text = "";

            //Blank out the textbox for the price
            lblOutputPrice.Text = "";

            //Check the credit card radio button
            radCredit.Checked = true;

            //Move the cursor to the top textbox
            txtPeople.Focus();
        }

        //Make the flight checkbox checked unless the florida radio button is checked
        private void SetFlight()
        {

            if (radFlorida.Checked == true)
            {
                chkFlight.Checked = false;
            }
            else
            {
                chkFlight.Checked = true;
            }
        }
        //This is a function to show a message box when it is called
        private void DisplayMsg(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        /* Name: Aaron Milbury
         * Due date: November 17th, 2022
         * Short Description
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTrip();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }

        //Apply the SetFlight function to the Cuba radiobutton
        private void radCuba_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

        //Apply the SetFlight function to the Florida radiobutton
        private void radFlorida_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

        //Apply the SetFlight function to the Mexico radiobutton
        private void radMexico_CheckedChanged(object sender, EventArgs e)
        {
            SetFlight();
        }

            private void btnBook_Click(object sender, EventArgs e)
            {
                //Declare constants for this instance
                const double LOCATIONS = 2150.50;
                const double MEXICO = 2300.79;
                const double CASHBACK = .10;
                int data = 0;

            //Verify if the textbox is using an integer
            if (!int.TryParse(txtPeople.Text, out data))
                { 
                    DisplayMsg("People must be a whole number", "Input Error");
                    txtPeople.Focus();
                    txtPeople.SelectAll();
                }
                else if (data < 1 || data > 10)
                {
                    DisplayMsg("People must be between 1-10", "Input Error");
                    txtPeople.Focus();
                    txtPeople.SelectAll();
                }
                else
                {
                    //Make the trip info group box visible
                    grpTripInfo.Visible = true;

                    //Clear the display label
                    lblDisplay.Text = "";

                    //Add information about the person who booked the trip
                    lblDisplay.Text += "Booked by Aaron" + "\n";

                    int people = Convert.ToInt32(txtPeople.Text);

                    //For the amount of people entered in the textbox, display it in the label
                    lblDisplay.Text += "\n" + "People: " + people.ToString("d2");

                    //For the location that was checked display it in the label
                    lblDisplay.Text += "\n" + "Location: ";

                    //Display text in the label for which country you signed up for
                    if (radCuba.Checked == true)
                    {
                        lblDisplay.Text += "CUBA";
                    }
                    else if (radFlorida.Checked == true)
                    {
                        lblDisplay.Text += "FLORIDA";
                    }

                    else if (radMexico.Checked == true)
                    {
                        lblDisplay.Text += "MEXICO";
                    }
                    else
                    {
                    }

                    // Check to see if the flight is included
                    if (!radFlorida.Checked == true)
                    {
                        lblDisplay.Text += "\n" + "Flight Included";
                    }

                    //Calculate the price
                    if (radMexico.Checked == true)
                    {
                        //Declare variables for this instance
                        double total = people * MEXICO;
                        double percentTotal = CASHBACK * total;
                        if (radCash.Checked == true)
                        {
                            double newTotal = total - percentTotal;

                            //Display the calculated price in both the price label and the label in the trip info groupbox
                            lblDisplay.Text += "\n" + "Cash Discount Applied" + "\n" + "Price: " + newTotal.ToString("C");

                            lblOutputPrice.Text = newTotal.ToString("C");

                        }
                        else
                        {
                            //Display the price in both of the labels
                            lblDisplay.Text += "\n" + "Price: " + total.ToString("C");

                            lblOutputPrice.Text = total.ToString("C");
                        }
                    }
                    else
                    {
                        //Declare variables for this instance
                        double total = people * LOCATIONS;
                        if (radCash.Checked == true)
                        {
                            double percentTotal = CASHBACK * total;
                            double newTotal = total - percentTotal;

                            //Display the price that was calculated
                            lblDisplay.Text += "\n" + "Cash Discount Applied" + "\n" + "Price: " + newTotal.ToString("C");

                            lblOutputPrice.Text = newTotal.ToString("C");
                        }
                        else
                        {
                            //Display the price that was calculated
                            lblDisplay.Text += "\n" + "Price: " + total.ToString("C");

                            lblOutputPrice.Text = total.ToString("C");
                        }
                    }
                    //Discount appears for when their are either 1 person or 3
                    switch (people)
                    {
                        case 1: case 3:
                            DisplayMsg("Special when booking single or triple." + "\n" +
                                "BOGO Sepecial - Call 555-1212 to recieve another person free!", "Limited time offer");
                            break;
                    }
                    //Disable the booking groupbox
                    grpBook.Enabled = false;
                }
            }

            //This event is for the confirm button
            private void btnConfirm_Click(object sender, EventArgs e)
            {
                //Re-calculate to display in message box at the end
                //Declare constants for this instance
                int people = Convert.ToInt32(txtPeople.Text);
                const double MEXICO = 2300.79;
                const double CASHBACK = .10;
                const double LOCATIONS = 2150.50;
                if (radMexico.Checked == true)
                {
                    double total = people * MEXICO;
                    if (radCash.Checked == true)
                    {
                        //Declare variables for this instance
                        double percentTotal = CASHBACK * total;
                        double newTotal = total - percentTotal;

                        //Display a message box with the new total after the cash back
                        DisplayMsg("Trip booked and paid" + "\n" + "Price: " + newTotal.ToString("C"), "Confirmation Email Sent");
                    }
                    else
                    {
                        //Display a message box with the total
                        DisplayMsg("Trip booked and paid" + "\n" + "Price: " + total.ToString("C"), "Confirmation Email Sent");
                    }
                }
                else
                {
                    if (radCash.Checked == true)
                    {
                        //Declare variables for this instance
                        double total = people * LOCATIONS;
                        double percentTotal = CASHBACK * total;
                        double newTotal = total - percentTotal;

                        //Display a message box with the new total after cashback
                        DisplayMsg("Trip booked and paid" + "\n" + "Price: " + newTotal.ToString("C"), "Confirmation Email Sent");
                    }
                    else
                    {
                        //Declare total as a variable for this instance and do math with it
                        double total = people * LOCATIONS;

                        //Display a message box with the total
                        DisplayMsg("Trip booked and paid" + "\n" + "Price: " + total.ToString("C"), "Confirmation Email Sent");
                    }
                }

                //This resets the form
                ResetTrip();

                //This enables the booking group box
                grpBook.Enabled = true;
            }
        }
    }
