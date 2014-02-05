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
            //Declare variables that will be used to capture each value in the boxes
            String firstName, lastName, race, sex;
            int age, barcodeNumber;

            //initalize sex variable
            sex = "None";
            age = 0;
            barcodeNumber = 0;

            //Get the values
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            race = raceComboBox.Text;

            //Catch exceptions here for if the box is empty. Can't covert a string.empty to an int
            if (ageComboBox.Text != string.Empty)
            {
                
                age = Convert.ToInt32(ageComboBox.Text);
            }
            
            //Catch exception here for if the box is empty. can't covert a string.empty to an int
            if (barcodeNumberTextbox.Text != string.Empty)
            {
                barcodeNumber = Convert.ToInt32(barcodeNumberTextbox.Text);
            }
            

            //Check the radio buttons to see what is selected and then store it
            if (maleRadioButton.Checked)
            {
                sex = "M";
            }

            if(femailRadioButton.Checked)
            {
                sex = "F";
            }

            if (firstName == string.Empty)
            {
                MessageBox.Show("You must fill in required fields");

            }
            else
            {
                MessageBox.Show(firstName + ", " + lastName + ", " + race + " , " + age + ", " + barcodeNumber + ", " + sex);
                this.Close();
            }
          
        }
    }
}
