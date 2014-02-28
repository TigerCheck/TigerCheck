/*
-----------------------------------------------------------------------------
Patient.cs
Date Created: 2/19/2014
Date Last Modified: 2/19/2014
Author of Last Change: Ethan Darby

Function: This is the patient object that will be used throughout the program.

Important Notes: 
-----------------------------------------------------------------------------
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace TigerCheck
{



    class Patient
    {
        //All of these variables are named the exact same as the SQL columns in the database PatientRecords
       public int ID_NUM, Age;
       public  string Last_Name, First_Name, Sex, Race, Blood_Pressure, Lungs, Dental, Vision, Cholesterol, Ears, Throat, Nose, Heart, Scoliosis, Session_ID;
       public float Heart_Rate, Height, Weight, BMI, Blood_Sugar;
       public SqlConnection _connection;



        /*
        ________________________________________________________________
        Patient
        Date Last Modified: 2/19/2014
        Name: Ethan Darby
         
        Functionality: This is the constructor for Patient. It sets all the fields to initial values, whether that is 0 or null

        Parameters: None 

        Returns: None

        Important notes: Make this pull from the config file and not a hardcoded string
        ________________________________________________________________
        */
        public Patient()
        {
            SqlConnection _connection = new SqlConnection("Data Source=tcp:172.17.72.79;Initial Catalog=TigerCheckProduction;User ID=sa;Password=kidcheck2010");
        }


        /*
________________________________________________________________
addNewSessoin
Date Last Modified: 2/18/2014
Name: Ethan Darby
         
Functionality: This adds a session to the database and sets it as active.

Parameters: schoolIn is the school name
*  countyIn is the county name
*  dateIn is the date
*  checkBoxesChecked is a string array containing which check boxes have been checked

Returns: //FILL THIS IN

Important notes: 
________________________________________________________________
*/
        public void addNewSession(string schoolIn, string countyIn, DateTime dateIn, string[] checkBoxesChecked)
        {

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


            foreach (string checkedBox in checkBoxesChecked)
            {
                switch (checkedBox)
                {

                    case "Height and Weight":
                        heightAndWeight = 1;
                        break;
                    case "Cholesterol":
                        cholesterol = 1;
                        break;
                    case "Vision":
                        vision = 1;
                        break;
                    case "Heart":
                        heart = 1;
                        break;
                    case "Dental":
                        dental = 1;
                        break;
                    case "Hearing":
                        hearing = 1;
                        break;
                    case "Blood Pressure":
                        bloodPressure = 1;
                        break;
                    case "Blood Sugar":
                        bloodSugar = 1;
                        break;
                    case "Ears":
                        ears = 1;
                        break;
                    case "Lungs":
                        lungs = 1;
                        break;
                    case "Throat":
                        throat = 1;
                        break;
                    case "Scoliosis":
                        scoliosis = 1;
                        break;
                    case "Nose":
                        nose = 1;
                        break;
                    default:
                        break;
                }
            }



            SqlCommand insertNewSession = new SqlCommand("INSERT INTO TigerCheckProduction.dbo.sessionData (Session_ID,School_Name,County,Date,Height_and_Weight,Cholesterol,Vision,Heart,Dental,Blood_Pressure,Blood_Sugar,Hearing,Lungs,Ears,Throat,Nose,Scoliosis,ActiveFlag) VALUES (@Session_ID,@School_Name,@County,@Date,@Height_and_Weight,@Cholesterol,@Vision,@Heart,@Dental,@Blood_Pressure,@Blood_Sugar,@Hearing,@Lungs,@Ears,@Throat,@Nose,@Scoliosis,@ActiveFlag)", _connection);

            //make a sessionID
            string sessionID = countyIn.Substring(0, 3) + schoolIn.Substring(0, 3) + dateIn;


            insertNewSession.Parameters.AddWithValue("@Session_ID", sessionID);
            insertNewSession.Parameters.AddWithValue("@School_Name", schoolIn);
            insertNewSession.Parameters.AddWithValue("@County", countyIn);
            insertNewSession.Parameters.AddWithValue("@Date", dateIn);
            insertNewSession.Parameters.AddWithValue("@Height_and_Weight", heightAndWeight);
            insertNewSession.Parameters.AddWithValue("@Cholesterol", cholesterol);
            insertNewSession.Parameters.AddWithValue("@Vision", vision);
            insertNewSession.Parameters.AddWithValue("@Heart", heart);
            insertNewSession.Parameters.AddWithValue("@Dental", dental);
            insertNewSession.Parameters.AddWithValue("@Blood_Pressure", bloodPressure);
            insertNewSession.Parameters.AddWithValue("@Blood_Sugar", bloodSugar);
            insertNewSession.Parameters.AddWithValue("@Hearing", hearing);
            insertNewSession.Parameters.AddWithValue("@Lungs", lungs);
            insertNewSession.Parameters.AddWithValue("@Ears", ears);
            insertNewSession.Parameters.AddWithValue("@Throat", throat);
            insertNewSession.Parameters.AddWithValue("@Nose", nose);
            insertNewSession.Parameters.AddWithValue("@Scoliosis", scoliosis);
            insertNewSession.Parameters.AddWithValue("@ActiveFlag", 1);
        }




             
/*___________________________________________________________
getPatientData
Date Last Modified: 2/19/2014
Name: Ethan Darby
       
Functionality: This gets a patients data from the database.

Parameters: barcodeIn is the barcode associated with the student
         
Returns: Returns a patient object

Important notes: The assumption here is that there is only one record per barcode. This is obviously means that there could some errors if
 * for some reason there is more than one student assigned to a barcode. Check for it just in case. This situation may happen if for some reason someone is not signed out
 * but their barcode is reused. 
________________________________________________________________
*/
        public Patient getPatientData(int barcodeIn)
        {
            Patient newPatient = new Patient();

            SqlCommand selectStudentData = new SqlCommand("SELECT * FROM TigerCheckProduction.dbo.PatientRecords WHERE [ID_Num] = @barcodeIn", _connection);

            selectStudentData.Parameters.AddWithValue("@barcodeIn", barcodeIn);

            //This needs to be done, read all the values in and set them in the patient object
            SqlDataReader readFromTable = selectStudentData.ExecuteReader();
            while (readFromTable.Read())
            {
                newPatient.Age = Convert.ToInt32(readFromTable["Age"]);

            }


            return newPatient;
        }





    }


}


    

    


