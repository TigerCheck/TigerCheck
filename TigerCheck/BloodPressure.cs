using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TigerCheck
{
    public partial class BloodPressure : Form
    {
        public BloodPressure()
        {
            InitializeComponent();
            //SQL get patient
        }
        /*
        ________________________________________________________________
        submitButton_Click
        Date Ross Spears

        Functionality: This function is called when the submit button is pressed.

        Parameters: No info being passed

        Returns: Nothing returned is returned, but it does hit the sql database and stores the values of systolic and diatolic blood pressure

        Important notes:
        ________________________________________________________________
        */
        private void submitButton_Click(object sender, EventArgs e)
        {
            try //Check to ensure entered value is a number
            {
                int systolicBloodPressure = Convert.ToInt32(SystolicBloodPressureTextBox.Text);
                int diatolicBloodPressure = Convert.ToInt32(DiatolicBloodPressureTextBox.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Please enter a number into this box");
            }
            //SQL write Systolic/Diatolic
            this.Close();
        }
/*
        ________________________________________________________________
cancelButton_Click
Date Last Modified: 2/28/2014
Name: Ross Spears
Functionality: This function is called when the cancel button is pressed.

Parameters: No info being passed

Returns: Nothing returned is returned, and returns to the previous screen

Important notes:
        ________________________________________________________________
*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloodPressure_Load(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            //If this is valid then close the panel and show the info
            //Check if this barcode exists in the database
            //This code is the same in ever single station other than what data it should pull
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
            SqlCommand ifExists = new SqlCommand("IF Exists(Select 1 From TigerCheckProduction.dbo.PatientData WHERE [ID_Num] = @barcodeNum) Select 1 Else Select 0", connection);
            ifExists.Parameters.AddWithValue("@barcodeNum", barcodeTextBox.Text);
            if (Convert.ToInt32(ifExists.ExecuteScalar()) == 1)
            {

                barcodePanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid barcode number");
            }
        }

        private void closeButtonBP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        
    }
}
