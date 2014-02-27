using System;

/*
 * StationSuper.cs
 * 
 * Date Created: 2/27/2014
 * 
 * Date Last Modified: 2/27/2014
 * 
 * Function: Parent class for all of the ___Station classes.
 * Intends to contain get and release patient functions to lower the number of functions in the subclasses
 * 
 * Important Notes:
 * 
 * */
public class StationSuper
{
	public StationSuper() //Constructor: Establish connection to the database
	{
        SqlConnection myConnection = new SqlConnection("user id=Ross Spears;" + "password=NULL; server=NULL;" + "Trusted_Connection=yes;" + "database=TigerCheck;" + "connection timeout = 30");
        try
        {
            myConnection.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
	}
/*getPatient(String Name)
 * Date Last Modified: 2/27/2014
 * Name: Ross Spears
 * 
 * Functionality: Get a patient object from the database based on an entered name
 * 
 * Parameters: String Name
 * 
 * Returns: n/a
 * 
 * Important Notes: This method is overloaded, the 2 options for the parameters are: String Name and int barcodeNumber
 */
    void getPatient(String name)
	{
		string[] splitName = name.Split(' ');
		SQLCommand getNames = new SqlCommand(SELECT * FROM table WHERE Column = "Last_Name", "First_Name", myConnection);
		foreach(String[] Name in getNames)
		{
			if(Name == splitName)
				patient = SQLObject;
		}
	}
/*getPatient(int barcodeNumber)
 * Date Last Modified: 2/27/2014
 * Name: Ross Spears
 * 
 * Functionality: Get a patient object from the database based on an entered Barcode Number
 * 
 * Parameters: int barcodeNumber
 * 
 * Returns: n/a
 * 
 * Important Notes: This method is overloaded, the 2 options for the parameters are: String Name and int barcodeNumber

 */
	void getPatient(int barcodeNumber)
	{
		SQLCommand getIDs = new SqlCommand(SELECT * FROM table WHERE Column = "ID_Num", myConnection);
		foreach(int ID in getIDs) 
			if(ID == barcodeNumber)
				patient = SQLgetObject(barcodeNumber);
	}
/* releasePatient(String Name)
 * Date Last Modified: 2/27/2014
 * Name: Ross Spears
 * 
 * Functionality: Flush any values changed in the method to the database
 * Empty the patient variable based on the name of the patient
 * 
 * Parameters: String Name
 * 
 * Returns: n/a
 * 
 * Important Notes: This method is overloaded, the 2 options for the parameters are: String Name and int barcodeNumber
 */
	void releasePatient(String name)
	{
		write Value To SQL;
		patient = NULL;
	}
/* releasePatient(String Name)
 * Date Last Modified: 2/27/2014
 * Name: Ross Spears
 * 
 * Functionality: Flush any values changed in the method to the database
 * Empty the patient variable based on the barcode of the patient
 * 
 * Parameters: String Name
 * 
 * Returns: n/a
 * 
 * Important Notes: This method is overloaded, the 2 options for the parameters are: String Name and int barcodeNumber
 */
	void releasePatient(int barcodeNumber)
	{
		write Value To SQL;
		patient = NULL;
	}
    ~StationSuper() //Destructor: close the connection when the program ends
    {
	    try
	    {
	    	myConnection.Close();
	    }
	    catch(Exception e)
	    {
		    Console.WriteLine(e.ToString());
	    }
    }
}
