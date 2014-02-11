/*
-----------------------------------------------------------------------------
NewSessionScreen.cs
Date Created: 2/5/2014
Date Last Modified: 2/6/2014
Author of Last Change: Ethan Darby

Function: NewSessionScreen is called from the admin screen and is used to fill in data about a new session. The users access this screen when they
 * arrive at the school and are beginning the day.

Important Notes: As of now, there is nothing here but a layout and the functions are stubbed out. 
-----------------------------------------------------------------------------
*/
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TigerCheck
{
    public partial class newSessionScreen : Form
    {

        public newSessionScreen()
        {
            InitializeComponent();
        }

/*
________________________________________________________________
createNewSessionButton_Click
Date Last Modified: 2/7/2014
Name: Ethan Darby
         
Functionality: This function is called when the Create New Session button is clicked

Parameters: Event args, nothing from us. 

Returns: None

Important notes: This will save the data to the database and also enable buttons on the main form to be used now that a sessino
 * has been created.
________________________________________________________________
*/
        private void createNewSessionButton_Click(object sender, EventArgs e)
        {

            //submit the session data to the database
            
            //First, make an object with an address that will be able to connect to the database
            SqlConnection session_Data_Connection = new SqlConnection("Data Source=tcp:172.17.72.109;Initial Catalog=TigerCheckProduction;User ID=sa;Password=kidcheck2010");

            //Open the connection
            session_Data_Connection.Open();

            //check to see if it exists, if not, then add it
            if (!checkIfRecordExists(session_Data_Connection, countyComboBox.Text, schoolComboBox.Text, DateTime.Today))
            {
                DialogResult goAheadAndAddRecord;
                goAheadAndAddRecord = MessageBox.Show("This will clear any other active sessions. Continue", "Continue?", MessageBoxButtons.YesNo);
                if (goAheadAndAddRecord == DialogResult.Yes)
                {
                    clearActiveFlags(session_Data_Connection);
                    addRecordToDatabase(session_Data_Connection, countyComboBox.Text, schoolComboBox.Text, DateTime.Today);
                }
                
            }
            

            this.Owner.Controls["checkInButton"].Enabled = true;
            this.Owner.Controls["checkOutButton"].Enabled = true;
            session_Data_Connection.Close();
            this.Close();
        }

/*
________________________________________________________________
createNewSessionButton_Click
Date Last Modified: 2/7/2014
Name: Ethan Darby
         
Functionality: This function is called when the Create New Session button is clicked

Parameters: Event args, nothing from us. 

Returns: None

Important notes: This will save the data to the database and also enable buttons on the main form to be used now that a sessino
 * has been created.
________________________________________________________________
*/
        private bool checkIfRecordExists(SqlConnection connectionIn, string countyIn, string schoolIn, DateTime dateIn)
        {
            bool itExists = false;

            //Make a sql command object, with both the command string and the connection object 
            SqlCommand checkForRecord = new SqlCommand("IF Exists(Select 1 From TigerCheckProduction.dbo.sessionData WHERE [County] = @County and [School_Name] = @School_Name and [Date] = @Date) Select 1 Else Select 0", connectionIn);

            //Insert the parameters
            checkForRecord.Parameters.AddWithValue("@School_Name", schoolIn);
            checkForRecord.Parameters.AddWithValue("@County", countyIn);
            checkForRecord.Parameters.AddWithValue("@Date", DateTime.Today);
           
            //execute the command. If there is no record, it will return 0, if there is it will return 1
            if (Convert.ToInt32(checkForRecord.ExecuteScalar()) == 1)
            {
                itExists = true;

            }
            
            return itExists;
        }

/*
________________________________________________________________
addRecordToDatabase
Date Last Modified: 2/10/2014
Name: Ethan Darby
         
Functionality: This adds a session to the database and sets it's active.

Parameters: //FILL THIS IN

Returns: //FILL THIS IN

Important notes: This will save the data to the database and also enable buttons on the main form to be used now that a sessino
 * has been created.
________________________________________________________________
*/
        private void addRecordToDatabase(SqlConnection connectionIn, string schoolIn, string countyIn, DateTime dateIn)
        {
            
            
            
            //check if each checkbox is selected or not
            int heightAndWeight = 0;
            int cholesterol = 0;
            int vision = 0;
            int heart = 0;
            int dental = 0;
            int bloodPressure = 0;
            int bloodSugar = 0;
            int hearing = 0;
            int lungs = 0;
            int ears = 0;
            int throat = 0;
            int nose = 0;
            int scoliosis = 0;

            if (heightAndWeightCheckBox.Checked)
            {
                heightAndWeight = 1;
            }

            if (cholesterolCheckBox.Checked)
            {
                cholesterol = 1;
            }

            if (visionCheckBox.Checked)
            {
                vision = 1;
            }

            if (heartCheckBox.Checked)
            {
                heart = 1;
            }

            if (dentalCheckBox.Checked)
            {
                dental = 1;
            }

            if (bloodPressureCheckBox.Checked)
            {
                bloodPressure = 1;
            }

            if (bloodSugarCheckBox.Checked)
            {
                bloodSugar = 1;
            }
            if (hearingCheckBox.Checked)
            {
            }
            if (lungsCheckBox.Checked)
            {
                lungs = 1;
            }
            if (earsCheckBox.Checked)
            {
            }
            if (throatCheckBox.Checked)
            {
                throat = 1;
            }
            if (noseCheckBox.Checked)
            {
                nose = 1;
            }
            if (scoliosisCheckBox.Checked)
            {
                scoliosis = 1;
            }

            SqlCommand setNewSession = new SqlCommand("INSERT INTO TigerCheckProduction.dbo.sessionData (Session_ID,School_Name,County,Date,Height_and_Weight,Cholesterol,Vision,Heart,Dental,Blood_Pressure,Blood_Sugar,Hearing,Lungs,Ears,Throat,Nose,Scoliosis,ActiveFlag) VALUES (@Session_ID,@School_Name,@County,@Date,@Height_and_Weight,@Cholesterol,@Vision,@Heart,@Dental,@Blood_Pressure,@Blood_Sugar,@Hearing,@Lungs,@Ears,@Throat,@Nose,@Scoliosis,@ActiveFlag)", connectionIn);

            //make a sessionID
            string sessionID = countyIn.Substring(0, 3) + schoolIn.Substring(0, 3) + dateIn;


            setNewSession.Parameters.AddWithValue("@Session_ID",sessionID);
            setNewSession.Parameters.AddWithValue("@School_Name",schoolIn);
            setNewSession.Parameters.AddWithValue("@County",countyIn);
            setNewSession.Parameters.AddWithValue("@Date", dateIn);
            setNewSession.Parameters.AddWithValue("@Height_and_Weight", heightAndWeight);
            setNewSession.Parameters.AddWithValue("@Cholesterol", cholesterol);
            setNewSession.Parameters.AddWithValue("@Vision", vision);
            setNewSession.Parameters.AddWithValue("@Heart", heart);
            setNewSession.Parameters.AddWithValue("@Dental", dental);
            setNewSession.Parameters.AddWithValue("@Blood_Pressure",bloodPressure);
            setNewSession.Parameters.AddWithValue("@Blood_Sugar", bloodSugar);
            setNewSession.Parameters.AddWithValue("@Hearing", hearing);
            setNewSession.Parameters.AddWithValue("@Lungs", lungs);
            setNewSession.Parameters.AddWithValue("@Ears", ears);
            setNewSession.Parameters.AddWithValue("@Throat", throat);
            setNewSession.Parameters.AddWithValue("@Nose",nose);
            setNewSession.Parameters.AddWithValue("@Scoliosis",scoliosis);
            setNewSession.Parameters.AddWithValue("@ActiveFlag",1);

            
            //CATCH ERRORS HERE                                     !!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            setNewSession.ExecuteNonQuery();

           

        }

/*
________________________________________________________________
clearActiveFlags
Date Last Modified: 2/10/2014
Name: Ethan Darby
         
Functionality: This clears any active flags

Parameters: //FILL THIS IN

Returns: //FILL THIS IN

Important notes: This will save the data to the database and also enable buttons on the main form to be used now that a sessino
 * has been created.
________________________________________________________________
*/
        private void clearActiveFlags(SqlConnection connectionIn)
        {
            SqlCommand clearFlags = new SqlCommand("UPDATE TigerCheckProduction.dbo.sessionData SET ActiveFlag = 0 WHERE ActiveFlag = 1", connectionIn);
            clearFlags.ExecuteNonQuery();
        }
    }
}
