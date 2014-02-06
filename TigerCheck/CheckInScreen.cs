//CheckInScreen.cs
//Date Created: 2/5/2014
//Date Last Modified: 2/5/2014
//Author of Last Change: Ethan Darby
//
//Function: CheckInScreen is called when the Check-In button is clicked from the mains creen. It is a form where the user enters data pertinent to the patient. Thet get general
//      information and assign them a barcode. When they click submit, the forms are checked and validated before then sending it to the SQL server.
//
//Important Notes: The SQL server code is not added here yet, still needs to be done.
//
//


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TigerCheck
{
    public partial class checkInScreen : Form
    {
        public checkInScreen()
        {
            InitializeComponent();
        }
/*
________________________________________________________________
submitButton_Click
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: This function is called when the submit button is pressed.

Parameters: No info being passed

Returns: Nothing returned is returned, but it does hit the sql database and add a patient record

Important notes:
________________________________________________________________
*/
        private void submitButton_Click(object sender, EventArgs e)
        {

            //First, lets meke sure that none of them are empty or have invalid values
            if (allValuesAreValid())
              {
                //Declare variables that will be used to capture each value in the boxes
                String firstName, lastName, race, sex;
                int age, barcodeNumber;

                //initalize sex variable
                sex = "None";
          
                //Get the values
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                race = raceComboBox.Text;
                age = Convert.ToInt32(ageComboBox.Text);
                barcodeNumber = Convert.ToInt32(barcodeNumberTextbox.Text);
                
                //Check the radio buttons to see what is selected and then store it
                if (maleRadioButton.Checked)
                {
                    sex = "M";
                }

                if (femailRadioButton.Checked)
                {
                    sex = "F";
                }




                this.Close();

            } 
        }


/*
________________________________________________________________
allValuesAreValid
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: This function is called when the submit button is pressed and analyzes all the values in the form.

Parameters: No info being passed

Returns: A bool value is returned indicating True if the values are all valid and False if they are not

Important notes: THIS FUNCTION IS LONGER THAN 30 LINES
________________________________________________________________
*/
        private bool allValuesAreValid()
        {
            //local value that will be returned indicating what the function found
            bool isValid = true;

            //If any of them are blank, then return is not valid
            if (firstNameTextBox.Text == string.Empty || lastNameTextBox.Text == string.Empty || ageComboBox.Text == string.Empty || barcodeNumberTextbox.Text == string.Empty)
            {
                isValid = false;
                MessageBox.Show("Please enter a value for every required field.");
            }
            
            //make sure that the age is in the required range
            if (ageComboBox.Text != string.Empty)
            {
                int valueOfAgeComboBox = Convert.ToInt32(ageComboBox.Text);
                if (valueOfAgeComboBox > 120 || valueOfAgeComboBox < 1)
                {
                    isValid = false;
                    MessageBox.Show("Age entered was out of range. Age must be greater than 0 and less than 120");
                    ageComboBox.Focus();
                }
            }


            //Make sure that the barcode entered was actually a barcode, no letters or symbols, and that it is only 4 numbers long
            if (barcodeNumberTextbox.Text != string.Empty)
            {
                int numberParseResult = 0;
                bool isNumber = int.TryParse(barcodeNumberTextbox.Text, out  numberParseResult);

                //if it's not a number, then it's invalid
                if (!isNumber)
                {
                    isValid = false;
                    MessageBox.Show("Barcode value is not a number!");
                    barcodeNumberTextbox.Focus();
                }
                if (isNumber)
                {
                    if (numberParseResult < 0 || numberParseResult > 9999)
                    {
                        isValid = false;
                        MessageBox.Show("Barcode Value is less than 0 or greater than 4 digits long");
                        barcodeNumberTextbox.Focus();
                    }


                }
            }


            if (maleRadioButton.Checked == false && femailRadioButton.Checked == false)
            {
                isValid = false;
                MessageBox.Show("No button selected for sex of the patient");
            }
            return isValid;
    
        }

    }
}
