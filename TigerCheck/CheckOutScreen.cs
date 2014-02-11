//CheckOutScreen.cs
//Date Created: 2/5/2014
//Date Last Modified: 2/5/2014
//Author of Last Change: Ethan Darby
//
//Function: This screen is called when the user clicks on the Check-Out button on the admin screen. It allows them to scan or enter a barcode that will then be matched to a student on the
//      SQL database and they will be checked out.      
//
//Important Notes:
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
using System.Data.SqlClient;

namespace TigerCheck
{
    public partial class checkOutScreen : Form
    {
        public checkOutScreen()
        {
            InitializeComponent();
        }

/*
________________________________________________________________
checOutScreen_Load
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: This function is called automatically when the checkOutScreen loads.

Parameters: No info being passed

Returns: Nothing is returned, but it does hit the sql database and add a patient record

Important notes: This method is used to set things up as they should be for when the screen is loaded. 
________________________________________________________________
*/
        private void checkOutScreen_Load(object sender, EventArgs e)
        {
            //The text box should be focused already so that the scanner can put the value in or they can enter it without having to select it.
            //This should be defaulted, but just in case we will force it to here. 
            barcodeTextBox.Focus();


            //

        }

        /*
________________________________________________________________
checkOutStudent
Date Last Modified: 2/10/2014
Name: Zach White

Functionality:

Parameters: 

Returns: 

Important notes: 
________________________________________________________________
*/

        private void checkOutStudent()
        {
            SqlConnection _patientRecordsConnection = new SqlConnection("Data Source=tcp:172.17.72.109;Initial Catalog=TigerCheckProduction;User ID=sa;Password=kidcheck2010");
            //Make a command to check if the record exists before checking the student out
            //This scenario could occur should the user try to check out the child if he/she is not checked in first
            SqlCommand doesItExist = new SqlCommand("IF EXISTS(SELECT 1 FROM TigerCheckProduction.dbo.PatientRecords WHERE [User_ID] = @barcode) Select 1 ELSE Select 0", _patientRecordsConnection);

            doesItExist.Parameters.AddWithValue("@barcode", barcodeTextBox.Text);

            _patientRecordsConnection.Open();
            //execute the doesItExist command, should return a 1 or 0 if it finds one or not
            int doesItExistResult = Convert.ToInt32(doesItExist.ExecuteScalar());


            if (doesItExistResult == 1)
            {
                SqlCommand command = _patientRecordsConnection.CreateCommand();
                command.CommandText = "UPDATE PatientRecords SET [User_ID] = @NullValue WHERE [User_ID] = @Barcode";
                command.Parameters.AddWithValue("@NullValue", null);
                command.Parameters.AddWithValue("@Barcode", barcodeTextBox.Text);
                command.ExecuteNonQuery();
            }
            //else error message

            
            _patientRecordsConnection.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            checkOutStudent();
            this.Close();
           
        }
    }
}