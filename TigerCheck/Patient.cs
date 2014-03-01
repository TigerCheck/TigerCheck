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
       public double Heart_Rate, Height, Weight, BMI, Blood_Sugar;
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

          



            SqlConnection _connection = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
            Age = 0;
            Heart = null;
            Last_Name = null;
            First_Name = null;
            Sex = null;
            Race = null;
            Blood_Pressure = null;
            Lungs = null;
            Dental = null;
            Vision = null;
            Cholesterol = null;
            Ears = null;
            Throat = null;
            Nose = null;
            Heart = null;
            Scoliosis = null;
            Session_ID = null;
            ID_NUM = 0;
            Heart_Rate = 0;
            Height = 0;
            Weight = 0;
            BMI = 0;
            Blood_Sugar = 0;

          
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
        public void getPatientData(int barcodeIn)
        {
            //Patient newPatient = new Patient();

            SqlCommand selectStudentData = new SqlCommand("SELECT * FROM TigerCheckProduction.dbo.PatientRecords WHERE [ID_Num] = @barcodeIn", _connection);

            selectStudentData.Parameters.AddWithValue("@barcodeIn", barcodeIn);

            //This needs to be done, read all the values in and set them in the patient object
            SqlDataReader readFromTable = selectStudentData.ExecuteReader();
            while (readFromTable.Read())
            {
                Age = Convert.ToInt32(readFromTable["Age"]);
                ID_NUM = Convert.ToInt32(readFromTable["ID_Num"]);
                Last_Name = Convert.ToString(readFromTable["Last_Name"]);
                First_Name = Convert.ToString(readFromTable["First_Name"]);
                Sex = Convert.ToString(readFromTable["Sex"]);
                Race = Convert.ToString(readFromTable["Race"]);
                Blood_Pressure = Convert.ToString(readFromTable["Blood_Pressure"]);
                Heart_Rate = Convert.ToDouble(readFromTable["Heart_Rate"]);
                Height = Convert.ToDouble(readFromTable["Height"]);
                Weight = Convert.ToDouble(readFromTable["Weight"]);
                BMI = Convert.ToDouble(readFromTable["BMI"]);
                Lungs = Convert.ToString(readFromTable["Lungs"]);
                Dental = Convert.ToString(readFromTable["Dental"]);
                Vision = Convert.ToString(readFromTable["Vision"]);
                Cholesterol = Convert.ToString(readFromTable["Cholesterol"]);
                Blood_Sugar = Convert.ToDouble(readFromTable["Blood_Sugar"]);
                Ears = Convert.ToString(readFromTable["Ears"]);
                Throat = Convert.ToString(readFromTable["Throat"]);
                Nose = Convert.ToString(readFromTable["Nose"]);
                Heart = Convert.ToString(readFromTable["Heart"]);
                Scoliosis = Convert.ToString(readFromTable["Scoliosis"]);
                Session_ID = Convert.ToString(readFromTable["Session_ID"]);

            }


            
        }





    }


}


    

    


