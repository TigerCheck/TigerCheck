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

Returns: Nothing returned is returned, but it does hit the sql database and add a patient record

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
    }
}
