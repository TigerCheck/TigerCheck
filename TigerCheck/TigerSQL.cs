/*
-----------------------------------------------------------------------------
TigerSQL.cs
Date Created: 2/14/2014
Date Last Modified: 2/14/2014
Author of Last Change: Ethan Darby

Function: This is a class we will use to access the SQL database. It keeps us from having to manage variables and connections
 * throughout the program and in different screens
 
Important Notes:
-----------------------------------------------------------------------------
*/

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TigerCheck
{
    class TigerSQL
    {
      
        SqlConnection _patientRecordsConnection = new SqlConnection(ConfigurationSettings.AppSettings.Get("TigerCheckProductionConectionString"));

        


        public TigerSQL(string formNameIn)
        {
            
        }

        
    }
}
