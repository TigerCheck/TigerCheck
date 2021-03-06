/*
-----------------------------------------------------------------------------
CheckInScreen.cs
Date Created: 2/5/2014
Date Last Modified: 2/7/2014
Author of Last Change: Zach White

Function: CheckInScreen is called when the Check-In button is clicked from the main screen. It is a form where the user enters data pertinent to the patient. They get general
      information and assign them a barcode. When they click submit, the forms are checked and validated before sending it to the SQL server.

Important Notes: Right now I am using a "hardcoded" sql connection instance at the top, using the PatientRecordsDataSet would be ideal here instead. But I am trying to get
      a working baseline as soon as possible. THIS NEEDS TO BE CHANGED ASAP AND NOT REPLICATED ANYWHERE ELSE
-----------------------------------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TigerCheck.TigerCheckProductionDataSetTableAdapters;

namespace TigerCheck
{
    public partial class checkInScreen : Form
    {
        //new SQL Connection object
        SqlConnection _patientRecordsConnection = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
        
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
                age = (int)Convert.ToDecimal(ageComboBox.Text); //Got a work around in place by converting it into a float then dropping the decimal
                barcodeNumber = Convert.ToInt32(barcodeNumberTextbox.Text);
                //Check the radio buttons to see what is selected and then store it
                if (maleRadioButton.Checked)
                {
                    sex = "M";
                }

                if (femaleRadioButton.Checked)
                {
                    sex = "F";
                }



                addPatientToDatabase(firstName, lastName, age, sex, race, barcodeNumber);//Have some error handling here just in case
                resultsTextBox.Text = resultsTextBox.Text + Environment.NewLine + lastName + ", " + firstName + " added successfully";
                
                clearTheForm();
                

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
                return isValid;
            }
            
            //make sure that the age is in the required range
            if (ageComboBox.Text != string.Empty)
            {
                int valueOfAgeComboBox = 0;
                try
                {
                    valueOfAgeComboBox = Convert.ToInt32(ageComboBox.Text);
                }
                catch(FormatException error)
                {
                    valueOfAgeComboBox = -1;
                }
                if (valueOfAgeComboBox > 120 || valueOfAgeComboBox < 1)
                {
                    isValid = false;
                    MessageBox.Show("Age entered was out of range or is invalid. Age must be greater than 0 and less than 120");
                    ageComboBox.Focus();
                    return isValid;
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
                    return isValid;
                }
                if (isNumber)
                {
                    if (numberParseResult < 0 || numberParseResult > 9999)
                    {
                        isValid = false;
                        MessageBox.Show("Barcode Value is less than 0 or greater than 4 digits long");
                        barcodeNumberTextbox.Focus();
                        return isValid;
                    }

                }
            }


            if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                isValid = false;
                MessageBox.Show("No button selected for sex of the patient");
                return isValid;
            }
            return isValid;
    
        }


/*
________________________________________________________________
addPatientToDatabse
Date Last Modified: 2/7/2014
Name: Zach White

Functionality: After the submit button has been pressed and the values have been verified/analyzed, this function is called to commit the values
                to the database. 

Parameters: The values from the text boxes, buttons, and combo boxes are passed. 

Returns: A true or false value is returned, indicicating whether or not the value was added to the database. A false value would indicated some value was wrong, the connection was lost, or something had failed.

Important notes: 
________________________________________________________________
*/

        private bool addPatientToDatabase(string firstNameIn, string lastNameIn, int ageIn, string sexIn, string raceIn, int barcodeIn)
        {

            SqlConnection connection = new SqlConnection("Data Source=tcp:172.17.72.79;Initial Catalog=TigerCheckProduction;User ID=sa;Password=kidcheck2010");

            //Make a command to check if the record exists befor inserting, otherwise may overwrite
            //This scenario could occur should the user try to check in the same child twice.
            SqlCommand doesItExist = new SqlCommand("IF EXISTS(SELECT 1 FROM TigerCheckProduction.dbo.PatientRecords WHERE [ID_Num] = @Barcode) SELECT 1 ELSE SELECT 0", _patientRecordsConnection);

            //add the parameters to the doesItExist command
 
            doesItExist.Parameters.AddWithValue("@Barcode", barcodeIn);

            _patientRecordsConnection.Open();
            //execute the doesItExist command, should return a 1 or 0 if it finds one or not
            int doesItExistResult = Convert.ToInt32(doesItExist.ExecuteScalar());

            if (doesItExistResult == 0)
            {
                SqlCommand command = _patientRecordsConnection.CreateCommand();
                command.CommandText = "INSERT INTO PatientRecords (First_Name, Last_Name, Age, Sex, Race,ID_Num) VALUES (@First_Name, @Last_Name, @Age, @Sex, @Race, @Barcode)";
                command.Parameters.AddWithValue("@First_Name", firstNameIn);
                command.Parameters.AddWithValue("@Last_Name", firstNameIn);
                command.Parameters.AddWithValue("@Age", ageIn);
                command.Parameters.AddWithValue("@Sex", sexIn);
                command.Parameters.AddWithValue("@Race", raceIn);
                command.Parameters.AddWithValue("@Barcode", barcodeIn);
                command.ExecuteNonQuery();
            }
            //else error message
            
            
            _patientRecordsConnection.Close();
            return true;
        }


/*
________________________________________________________________
clearTheForm
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: This function is called afer the patient has been checked in. It clears the values in the form automatically. 

Parameters: No info being passed

Returns: None

Important notes: 
________________________________________________________________
*/

        private void clearTheForm()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            ageComboBox.SelectedIndex = -1;
            femaleRadioButton.Checked = false;
            maleRadioButton.Checked = false;
            raceComboBox.SelectedIndex = -1;
            barcodeNumberTextbox.Clear();

        }

     

    }
}