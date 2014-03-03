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
    public partial class BloodSugar : Form
    {
        Patient patient = new Patient();
        public BloodSugar()
        {
            InitializeComponent();
            //SQL get patient height and weight
        }
    
       
        /*
        ________________________________________________________________
        cancelButton
        Date Last Modified: 2/28/2014
        Name: Zach White 

        Functionality: This function is called when the cancel button is pressed.

        Parameters: No info being passed

        Returns: Nothing

        Important notes:
        ________________________________________________________________
        */
        private void cancelButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButtonBS_Click(object sender, EventArgs e)
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

                bloodSugarTextBox.Text = patient.Blood_Sugar.ToString();
            }
            else
            {
                MessageBox.Show("Invalid barcode number");
            }
            connection.Close();
        }

        private void closeButtonBS_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*
    ________________________________________________________________
    submitButton
    Date Last Modified: 2/28/2014
    Name: Zach White

    Functionality: This function is called when the submit button is pressed.

    Parameters: No info being passed

    Returns: Nothing

    Important notes:
    ________________________________________________________________
    */
        private void button2_Click(object sender, EventArgs e)
        {
            int bloodSugar = Convert.ToInt32(bloodSugarTextBox.Text);
            patient.Blood_Sugar = bloodSugar;
            patient.updatePatientData("Blood_Sugar");
            this.Close();
        }
    }
}
