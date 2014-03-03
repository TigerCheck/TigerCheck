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
using System.Data.OleDb;

namespace TigerCheck
{



    class Patient
    {
        //All of these variables are named the exact same as the SQL columns in the database PatientRecords
       public int ID_Num, Age;
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

          



             _connection = new SqlConnection(Properties.Settings.Default.TigerCheckProductionConnectionString);
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
            ID_Num = 0;
            Heart_Rate = 0;
            Height = 0;
            Weight = 0;
            BMI = 0;
            Blood_Sugar = 0;
            _connection.Open();
          
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
           
            //When reading in values, you have to account for nulls for the double conversions
            SqlDataReader readFromTable = selectStudentData.ExecuteReader();
            while (readFromTable.Read())
            {
                Age = Convert.ToInt32(readFromTable["Age"]);
                ID_Num = Convert.ToInt32(readFromTable["ID_Num"]);
                Last_Name = Convert.ToString(readFromTable["Last_Name"]);
                First_Name = Convert.ToString(readFromTable["First_Name"]);
                Sex = Convert.ToString(readFromTable["Sex"]);
                Race = Convert.ToString(readFromTable["Race"]);
                Blood_Pressure = Convert.ToString(readFromTable["Blood_Pressure"]);

                if (readFromTable["Heart_Rate"] != DBNull.Value)
                {
                    Heart_Rate = Convert.ToDouble(readFromTable["Heart_Rate"]);   
                }

                if (readFromTable["Height"] != DBNull.Value)
                {
                    Height = Convert.ToDouble(readFromTable["Height"]);
                }

                if (readFromTable["Weight"] != DBNull.Value)
                {
                    Weight = Convert.ToDouble(readFromTable["Weight"]);
                }

                if (readFromTable["BMI"] != DBNull.Value)
                {
                    BMI = Convert.ToDouble(readFromTable["BMI"]);
                }
                
                Lungs = Convert.ToString(readFromTable["Lungs"]);
                Dental = Convert.ToString(readFromTable["Dental"]);
                Vision = Convert.ToString(readFromTable["Vision"]);
                Cholesterol = Convert.ToString(readFromTable["Cholesterol"]);
                if (readFromTable["Blood_Sugar"] != DBNull.Value)
                {
                    Blood_Sugar = Convert.ToDouble(readFromTable["Blood_Sugar"]); 
                }
                
                Ears = Convert.ToString(readFromTable["Ears"]);
                Throat = Convert.ToString(readFromTable["Throat"]);
                Nose = Convert.ToString(readFromTable["Nose"]);
                Heart = Convert.ToString(readFromTable["Heart"]);
                Scoliosis = Convert.ToString(readFromTable["Scoliosis"]);
                Session_ID = Convert.ToString(readFromTable["Session_ID"]);

            }


            _connection.Close();    
        }


 /*___________________________________________________________
updatePatientData
Date Last Modified: 3/2/2014
Name: Ethan Darby
       
Functionality: This updates the patients information in the database

Parameters: barcodeIn is the barcode associated with the student
         
Returns: Returns a patient object

Important notes: The assumption here is that there is only one record per barcode. This is obviously means that there could some errors if
 * for some reason there is more than one student assigned to a barcode. Check for it just in case. This situation may happen if for some reason someone is not signed out
 * but their barcode is reused. 
________________________________________________________________
*/

        public void updatePatientData(string dataToUpdate)
        {
            //The approach here, is that the column names in the database and the patients data are named the same, so to update Patient.Blood_Sugar, you would pass in Blood_Sugar
            //BUG - It isn't updating for some reason. There are no errors and it seems to have all the correct values at the time that it sends the data.

            SqlCommand updatePatient = new SqlCommand();
            updatePatient.Connection = _connection;
            updatePatient.Connection.Open();


            
            switch (dataToUpdate)
            {

                case "Blood_Pressure":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Blood_Pressure] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Blood_Pressure);
                    break;

                case "Heart_Rate":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Heart_Rate] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Heart_Rate);
                    break;

                case "Height":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Height] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Height);
                    break;

                case "Weight":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Weight] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Weight);
                    break;

                case "BMI":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [BMI] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", BMI);
                    break;

                case "Lungs":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Lungs] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Lungs);
                    break;

                case "Dental":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Dental] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Dental);
                    break;

                case "Vision":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Vision] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Vision);
                    break;

                case "Cholesterol":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Cholesterol] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Cholesterol);
                    break;

                case "Blood_Sugar":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Blood_Sugar] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Blood_Sugar);
                    break;

                case "Ears":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Ears] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Ears);
                    break;

                case "Throat":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Throat] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Throat);
                    break;

                case "Nose":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Nose] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Nose);
                    break;

                case "Heart":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Heart] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Heart);
                    break;
                    
                case "Scoliosis":
                    updatePatient.CommandText = "UPDATE TigerCheckProduction.dbo.PatientRecords SET [Scoliosis] = @valueToUpdate WHERE TigerCheckProduction.dbo.PatientRecords.[ID_Num] = @ID_Num";
                    updatePatient.Parameters.AddWithValue("@valueToUpdate", Scoliosis);
                    break;

                default:
                    break;
            }
            updatePatient.Parameters.AddWithValue("@ID_Num", ID_Num);
            updatePatient.ExecuteNonQuery();
           
            foreach (SqlParameter item in updatePatient.Parameters)
            {
                string temp = item.ParameterName;
                string test = item.Value.ToString();
            }
            _connection.Close();
        }




    }


}


    

    


