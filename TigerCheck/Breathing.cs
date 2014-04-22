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
     public partial class Form6 : Form
     {
          Boolean Normal;
          public Form6()
          {
               
               InitializeComponent();
          }

          private void SubmitButton_Click(object sender, EventArgs e)
          {
               if (Normal)
                    patient.Lungs = "Normal";
               else
                    Patient.Lungs = "Abnormal";
               patient.updatePatientData("Lungs");
               this.Close();

          }

          private void CancelButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
          {
               Normal = true;
          }

          private void AbnormalRadioButton_CheckedChanged(object sender, EventArgs e)
          {
               Normal = false;
          }

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

                    Breathing.Text = patient.Breathing.ToString();
               }
               else
               {
                    MessageBox.Show("Invalid barcode number");
               }
               connection.Close();
          }

          private void CloseButtonH_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
