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


namespace TigerCheck
{



    class Patient
    {
        //All of these variables are named the exact same as the SQL columns in the database PatientRecords
       public int ID_NUM, Age;
       public  string Last_Name, First_Name, Sex, Race, Blood_Pressure, Lungs, Dental, Vision, Cholesterol, Ears, Throat, Nose, Heart, Scoliosis, Session_ID;
       public float Heart_Rate, Height, Weight, BMI, Blood_Sugar;




        /*
        ________________________________________________________________
        Patient
        Date Last Modified: 2/19/2014
        Name: Ethan Darby
         
        Functionality: This is the constructor for Patient. It sets all the fields to initial values, whether that is 0 or null

        Parameters: None 

        Returns: None

        Important notes: 
        ________________________________________________________________
        */
        public Patient()
        {
            Age = 0;
        }
    }

    

}
