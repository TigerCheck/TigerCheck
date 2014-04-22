using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigerCheck
{
     public partial class Dental : Form
     {
          public Dental()
          {
               InitializeComponent();
          }

          private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
          {
               patient.Dental = "Normal";
               patient.updatePatientData("Dental");
               this.Close();
          }

          private void AbnormalRadioButton_CheckedChanged(object sender, EventArgs e)
          {
               HideCommentsPanel.Visible = false;
          }
          private void submitButtonD_Click(object sender, EventArgs e)
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

                    Dental.Text = patient.Dental.ToString();
               }
               else
               {
                    MessageBox.Show("Invalid barcode number");
               }
               connection.Close();
          }

          private void closeButtonD_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void CancelButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void SubmitButton_Click(object sender, EventArgs e)
          {
               patient.Dental = IssuesTextBox.Text;
               patient.updatePatientData("Dental");
               this.Close();
          }

     }
}
