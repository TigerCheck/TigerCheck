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
    public partial class BloodSugar : Form
    {
        public BloodSugar()
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
            int bloodSugar = Convert.ToInt32(bloodSugarTextBox.Text);
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
    }
}
