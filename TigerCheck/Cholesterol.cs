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
    public partial class Cholesterol : Form
    {
        Patient patient = new Patient();
        public Cholesterol()
        {
            InitializeComponent();
            //SQL get patient height and weight
        }
        /*
        ________________________________________________________________
        submitButton
        Date Last Modified: 2/28/2014
        Name: Zach White

        Functionality: This function is called when the submit button is pressed.

        Parameters: No info being passed

        Returns: Nothing

        Important notes: At this point, the user should be dealing with a valid barcode number, so error checking should only *have to *relate to the numbers entered
        ________________________________________________________________
        */
        private void submitButton(object sender, EventArgs e)
        {
         
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

        /*
     ________________________________________________________________
     cancelButton
     Date Last Modified: 3/2/2014
     Name: Ethan Darby 

     Functionality: This function is called when the submit button in the panel is called

     Parameters: No info being passed

     Returns: Nothing

     Important notes: These functions that relate to the panel are where the user enters a patient's number first before entering data
     ________________________________________________________________
     */
        private void submitButtonInPanel_Click(object sender, EventArgs e)
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

                //put the current value in the text box
                cholesterolTextBox.Text = patient.Cholesterol;

            }
            else
            {
                MessageBox.Show("Invalid barcode number");
            }
            connection.Close();
        }


        /*
 ________________________________________________________________
 cancelButton
 Date Last Modified: 3/2/2014
 Name: Ethan Darby 

 Functionality: This function is called when the close button is clicked in the panel

 Parameters: No info being passed

 Returns: Nothing

 Important notes: These functions that relate to the panel are where the user enters a patient's number first before entering data
 ________________________________________________________________
 */
        private void closeButtonChol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cholesterol = Convert.ToInt32(cholesterolTextBox.Text);

            //ERROR HANDLING HERE
            patient.Cholesterol = cholesterolTextBox.Text;
            patient.updatePatientData("Cholesterol");
            this.Close();
        }
    }
}
