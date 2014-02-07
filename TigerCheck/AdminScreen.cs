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

            //disable everything on this window until the user has finished with the new session window
            newSessionButton.Enabled = false;
            checkInButton.Enabled = false;
            checkOutButton.Enabled = false;

            //If you don't refresh the form then you won't see any of the changes. The property is set, 
            //but the current intance of the form will be out of date
            this.Refresh();

            newSessionFormInstance.Show();
            newSessionFormInstance.TopMost = true;
            

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

      
        

      
    }
}
