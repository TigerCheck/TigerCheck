using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TigerCheck
{
     public partial class Form1 : Form
     {
          Patient patient = new Patient();
          public HeightWeight()
          {
               InitializeComponent();
          }
          /*
          ________________________________________________________________
          submitButton_Click
          Date Last Modified: 4/14/2014
          
          Name: Ross Spears

          Functionality: This function is called when the submit button is pressed.

          Parameters: No info being passed

          Returns: Nothing returned is returned, but it does hit the sql database and stores the values of systolic and diatolic blood pressure

          Important notes:
          ________________________________________________________________
          */
          private void submitButton_Click(object sender, EventArgs e)
          {
               try //Check entered value is a number
               {
                    int heightFeet = Convert.ToInt32(HeightInFeetTextBox.Text);
                    int heightInch = Convert.ToInt32(HeightInInchesTextBox.Text);
                    int Weight = Convert.ToInt32(WeightTextBox.Text);
               }
               catch (FormatException error)
               {
                    MessageBox.Show("Please enter a number into the box");
               }
               patient.Height = (Convert.ToInt32(HeightInFeetTextBox.Text) * 12 + Convert.ToInt32(HeightInInchesTextBox.Text));
               patient.updatePatientData("Height");
               patient.Weight = Convert.ToInt32(WeightTextBox.Text);
               patient.updatePatientData("WEight");
               patient.BMI = Convert.ToInt32(WeightTextBox.Text) / (Convert.ToInt32(HeightInFeetTextBox.Text) * 12 + Convert.ToInt32(HeightInInchesTextBox.Text)) ^ 2;
               patient.updatePatientData("BMI");
               this.Close();
          }
          /*
          ________________________________________________________________
          cancelButton_Click
          Date Last Modified: 4/14/2014
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
          /*
          ________________________________________________________________
          barcodeSubmit_Click
          Date Last Modified: 4/14/2014
          Name: Ross Spears
          Functionality: This function is called when the submit button is pressed on the barcode panel.

          Parameters: No info being passed

          Returns: Nothing returned is returned, and returns to the previous screen

          Important notes:
          ________________________________________________________________
          */
          private void barcodeSubmit_Click(object sender, EventArgs e)
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

                    HeightInFeetTextBox.Text = patient.Height.ToString();
               }
               else
               {
                    MessageBox.Show("Invalid barcode number");
               }
               connection.Close();
          }
          /*
          ________________________________________________________________
          barcodeCancelButton_Click
          Date Last Modified: 4/14/2014
          Name: Ross Spears
          Functionality: This function is called when the cancel button is pressed on the barcode panel.

          Parameters: No info being passed

          Returns: Nothing returned is returned, and returns to the previous screen

          Important notes:
          ________________________________________________________________
          */
          private void barcodeCloseHW_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
