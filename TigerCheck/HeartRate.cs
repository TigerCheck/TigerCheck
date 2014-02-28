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

namespace Project1
{
    public partial class HeartRate : Form
    {

        public HeartRate()
        {
            InitializeComponent();
            //SQL get patient
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
        private void submitButton_Click(object sender, EventArgs e)
        {
            try //Check to ensure entered value is a number
            {
                int heartRate = Convert.ToInt32(HeartRateTextBox.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Please enter a number into this box");
            }

            //SQL return heartRate
            this.Close();
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

    }
}
