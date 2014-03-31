//AdminScreen.cs
//Date Created: 2/5/2014
//Date Last Modified: 2/5/2014
//Author of Last Change: Ethan Darby
//
//Function: AdminScreen is the first screen users see. When they open the program, this screen will come up and
// gives them options. They can create a new session, manage sessions, check in or check out patients, and basically do 
// any admin functions.
//
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
using System.Data.SqlClient;
using System.Configuration;



namespace TigerCheck
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }



/*
________________________________________________________________
AdminScreen_Load
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: This function is called when the window loads.

Parameters: No info being passed

Returns: Nothing returned

Important notes:
________________________________________________________________
*/


        private void AdminScreen_Load(object sender, EventArgs e)
        {

            //Let's set the current session label to whatever is active. This will tell someone what's up. Also, if for some reason the program is closed, then the users can just pick up
            //where they left off

            setActiveSessionLabel();




        }



/*
________________________________________________________________
newSessinButton_Click
Date Last Modified: 2/5/2014
Name: Ethan Darby

Functionality: The function is called whenever the user clicks the New Session button (newSessionButton). It loads
          another screen where the user can select/input data for a new session and create it.

Parameters: It accepts the sender, the button, as it's input. We aren't passing any values.

Returns:    Nothing

Important notes:
________________________________________________________________
*/


        private void newSessionButton_Click(object sender, EventArgs e)
        {

            //Make a new instance of newSessionScreen and show it
            Form newSessionFormInstance = new newSessionScreen();
            
            newSessionFormInstance.Show(this);
            //newSessionFormInstance.TopMost = true;
            

        }


/*
________________________________________________________________
checkInButton_Click
Date Last Modified: 2/5/2014
Name: Ethan Darby
         
Functionality: This function opens checkInScreen.

Parameters: None

Returns: None

Important notes:
________________________________________________________________
*/

        private void checkInButton_Click(object sender, EventArgs e)
        {
            //Make a new instance of checkInScreen and show it
            Form checkInFormInstance = new checkInScreen();
            checkInFormInstance.Show();

        }



/*
________________________________________________________________
checkOutButton_Click
Date Last Modified: 2/5/2014
Name: Ethan Darby
         
Functionality: This function opens checkOutScreen.

Parameters: None

Returns: None

Important notes:
________________________________________________________________
*/

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            //Make a new instance of checkOutScren and show it
            Form CheckOutScreenInstance = new checkOutScreen();
            CheckOutScreenInstance.Show();

        }


/*
________________________________________________________________
setActiveSessionLabel
Date Last Modified: 25/25/2014
Name: Ethan Darby
         
Functionality: The active session screen is set here, to either -None- or the name of whatever session is active

Parameters: None

Returns: None

Important notes: THIS IS NOT TESTED AND PROBABLY NOT FINISHED
________________________________________________________________
        */
       
        public void setActiveSessionLabel(){
            //first lets check to see if there is an active session
            //Make a connection
            SqlConnection connectionToTigerCheckProduction = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
            connectionToTigerCheckProduction.Open();
            //make command ------- EDIT THIS, IT'S NOT CHECKING FOR ACTIVE FLAG, IT'S A COPIED QUERY -------
            SqlCommand checkIfActiveSessionExists = new SqlCommand("IF Exists(Select 1 From TigerCheckProduction.dbo.sessionData WHERE [ActiveFlag] = 1) Select 1 Else Select 0", connectionToTigerCheckProduction);
            //execture command
            if (Convert.ToInt32(checkIfActiveSessionExists.ExecuteScalar()) == 1)
            {
                //get the value of the currently active session
                SqlCommand getActiveSession = new SqlCommand("Select [County], [School_Name] from TigerCheckProduction.dbo.sessionData Where [ActiveFlag] = 1", connectionToTigerCheckProduction);
                //make a SqlDataReader to get the actual field value from the table that is already active
                //Note, we are getting the school name here to put in the label
                SqlDataReader getSession = getActiveSession.ExecuteReader();
                getSession.Read();

                //now set the label to the school name
                currentSessionLabel.Text =Convert.ToString(getSession["School_Name"]) + ", " + Convert.ToString(getSession["County"]);
                
                //enable the labels
                currentSessionLabel.Enabled = true;
                currentSessionNoChange.Enabled = true;
                checkInButton.Enabled = true;
                checkOutButton.Enabled = true;
                manageSessionsButton.Enabled = true;
                
            
            }
            else
            {
                currentSessionLabel.Text = "-None-";
            }


        }




        /*

        The following is absent of any headers for each function. These are just the button click events
         * for the stations. They are self explanatory and all do the same thing for each button.
         * THERE IS NO MORE CODE OF ANY COMPLEXITY BELOW HERE, IT'S JUST BUTTON CLICK EVENTS
         
        */

        private void bloodSugarButton_Click(object sender, EventArgs e)
        {
            BloodSugar newBloodSugarScreen = new BloodSugar();
            newBloodSugarScreen.Show();
        
        }

        private void heartRateButton_Click(object sender, EventArgs e)
        {
            HeartRate newHeartRateScreen = new HeartRate();
            newHeartRateScreen.Show();
        }

        private void cholesterolButton_Click(object sender, EventArgs e)
        {
            Cholesterol newCholesterolScreen = new Cholesterol();
            newCholesterolScreen.Show();
        }

        private void bloodPressureButton_Click(object sender, EventArgs e)
        {
            BloodPressure newBloodPressureScreen = new BloodPressure();
            newBloodPressureScreen.Show();
        }

        private void heightWeightButton_Click(object sender, EventArgs e)
        {

        }

       

        

       
      
    }
}
