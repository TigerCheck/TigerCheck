/*
 * HeartRate.cs
 * 
 * Date Created: 2/28/2014
 * 
 * Date Last Modified: 2/28/2014
 * 
 * Function: Get data from windows form
 * 
 * Important Notes:
 * 
 * */
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
    public partial class HeartRate : Form
    {
        Patient patient = new Patient();
        public HeartRate()
        {
            InitializeComponent();
            //SQL get patient
        }
     
        /*

        ________________________________________________________________

        cancelButton_Click

        Date Last Modified: 2/28/2014

        Name: Ross Spears

        Functionality: cancel button on Windows form, returns to previous screen

        Parameters: n/a

        Returns: n/a

        Important notes:

        ________________________________________________________________

        */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButtonHR_Click(object sender, EventArgs e)
        {
            //If this is valid then close the panel and show the info
            //Check if this barcode exists in the database
            //This code is the same in ever single station other than what data it should pull
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
            SqlCommand ifExists = new SqlCommand("IF Exists(Select 1 From TigerCheckProduction.dbo.PatientRecords WHERE [ID_Num] = @barcodeNum) Select 1 Else Select 0", connection);
            ifExists.Parameters.AddWithValue("@barcodeNum", barcodeTextBox.Text);
            connection.Open();
            if (Convert.ToInt32(ifExists.ExecuteScalar()) == 1)
            {

                barcodePanel.Visible = false;
                //Since it exists, make a new patient object and load the data
               
                patient.getPatientData(Convert.ToInt32(barcodeTextBox.Text));

                HeartRateTextBox.Text = patient.Heart_Rate.ToString();
            }
            else
            {
                MessageBox.Show("Invalid barcode number");
            }
            connection.Close();
        }

        private void closeButtonHR_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        /*

     ________________________________________________________________

     submitButton_Click

     Date Last Modified: 2/28/2014

     Name: Ross Spears

     Functionality: OK button on Windows form, returns value of heartRate to SQL database

     Parameters: n/a

     Returns: n/a

     Important notes:

     ________________________________________________________________

     */
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            try //Check to ensure entered value is a number
            {
                int heartRate = Convert.ToInt32(HeartRateTextBox.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Please enter a number into this box");
            }

            //Store value in database
            patient.Heart_Rate = Convert.ToInt32(HeartRateTextBox.Text);
            patient.updatePatientData("Heart_Rate");

            this.Close();
        }

    }
}
