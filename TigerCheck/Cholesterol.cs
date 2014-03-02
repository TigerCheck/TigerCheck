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

        Important notes:
        ________________________________________________________________
        */
        private void submitButton(object sender, EventArgs e)
        {
            int cholesterol = Convert.ToInt32(cholesterolTextBox.Text);
            this.Close();
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

        private void submitButtonInPanel_Click(object sender, EventArgs e)
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

        private void closeButtonChol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
