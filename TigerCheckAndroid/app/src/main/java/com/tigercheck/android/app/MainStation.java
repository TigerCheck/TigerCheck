/*
-----------------------------------------------------------------------------
MainStation.java
Date Created: 4/7/2014
Date Last Modified: 4/21/2014
Author of Last Change: Zach White

Function: This is the main station where the user enters the patients barcode number

Important Notes: This class will need to be cleaned up some.
-----------------------------------------------------------------------------
*/


package com.tigercheck.android.app;


import android.app.Activity;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.app.AlertDialog;
import android.widget.Toast;

public class MainStation extends Activity {

    // Variables for the SQL server that I kept just to remember them even tho they arent used.
    //static final String SERVER_ADDRESS = "172.17.74.6:80";
    //static final String USERNAME = "sa";
    //static final String PASSWORD = "kidcheck2010";

    // Handler for SQLite database
    DataHandler handler;

/*
________________________________________________________________
onCreate
Date Last Modified: 4/21/2014
Name: Zach White

Functionality: This is called when the activity is created. Takes bundle from last
activity and creates a variable with the contents.

Parameters: None

Returns: None

Important notes: The bundle isn't needed for now since we are changing the way stations
are being called
________________________________________________________________
*/
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_station);
	}

/*
________________________________________________________________
onCreateOptionsMenu
Date Last Modified: 4/7/2014
Name: Zach White

Functionality: Creates settings menu

Parameters: None

Returns: None

Important notes: Not used. Created by default
________________________________________________________________
*/
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main_station, menu);
		return true;
	}

/*
________________________________________________________________
CheckBarcode
Date Last Modified: 4/24/2014
Name: Nick Bean

Functionality: Called when the submit button is pressed to enter the barcode.

Parameters: None

Returns: None

Important notes: This is my attempt at trying to get a SQLite
    database to work. It kind of does but has a long way to go.
    It is at least a foundation to build on in the future.
________________________________________________________________
*/
    public void checkBarcode(View view)
    {
        EditText barcodeEntry = (EditText) findViewById(R.id.barcode);
        String barcode = barcodeEntry.getText().toString();
        handler = new DataHandler(getBaseContext());
        handler.open();
        long id = handler.insertData(barcode);
        Toast.makeText(getBaseContext(), "Data inserted", Toast.LENGTH_LONG).show();
        handler.close();

        Intent intent = new Intent(this, StationSelect.class);
        startActivity(intent);

    }

    /*
    ________________________________________________________________
    onStop
    Date Last Modified: 4/20/2014
    Name: Zach White

    Functionality: calls disconnectFromDatabase() when the activity is destroyed

    Parameters: None

    Returns: None

    Important notes:
    ________________________________________________________________
    */
    @Override
    protected void onStop() {
        //disconnectFromDatabase();

        super.onStop();
    }

// EVERYTHING BEYOND THIS COMMENT IS CODE THAT ZACH WROTE BUT DOESN'T WORK CORRECTLY
// I MOVED IT DOWN HERE INSTEAD OF DELETING IT SO THAT ZACH'S WORK WASN'T IN VAIN
/*
________________________________________________________________
connectToDatabase
Date Last Modified: 4/21/2014
Name: Zach White

Functionality: Tries to make a connection to the database

Parameters: None

Returns: Boolean stating whether or not the app has made connection

Important notes:
________________________________________________________________
*/
    /*
    public boolean connectToDatabase() {
        boolean connectionSucceeded = false;

        AlertDialog alert = new AlertDialog.Builder(this).create();
        alert.setTitle("Error");
        alert.setMessage("Unable to connect to database");
        alert.setButton("Ok", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {

            }
        });
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver").newInstance();
            dbCon = DriverManager.getConnection("jdbc:jtds:sqlserver://" + SERVER_ADDRESS + ";user=" + USERNAME + ";password=" + PASSWORD + ";");
            connectionSucceeded = true;
            Log.w("Connection", "open");
        } catch (Exception e) {
            connectionSucceeded = false;
            Log.w("Error connection", " " + e.getMessage());
            alert.show();
        }
        return connectionSucceeded;
    }
    */
/*
________________________________________________________________
connectToDatabase
Date Last Modified: 4/21/2014
Name: Zach White

Functionality:

Parameters: None

Returns: None

Important notes:
________________________________________________________________
*/
    /*
    public void disconnectFromDatabase() {
        try {
            dbCon.close();
            Log.w("Connection", "close");
        } catch (Exception e) {
            Log.w("Error closing connection", " " + e.getMessage());
        }
    }
    */

/*
________________________________________________________________
checkBarcode
Date Last Modified: 4/21/2014
Name: Zach White

Functionality: Checks with the database to see if the entered barcode exists in the records

Parameters: None

Returns: boolean stating whether or not the barcode exists in the database

Important notes:
________________________________________________________________
*/
    /*
    public void checkBarcode(View view) {
        //check and set
        boolean barcodeExists = false;
        if(connectToDatabase()) {
            EditText barcodeEntry = (EditText) findViewById(R.id.barcode);
            int barcode = Integer.parseInt(barcodeEntry.getText().toString());

            AlertDialog alert = new AlertDialog.Builder(this).create();
            alert.setTitle("Error");
            alert.setMessage("Barcode not found");
            alert.setButton("Ok", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialogInterface, int i) {

                }
            });
            try {
                Statement stmt = dbCon.createStatement();
                Log.w("Barcode check", stmt.toString());
                barcodeExists = true;
            } catch (Exception e) {
                Log.w("Barcode check", " " + e.getMessage());
                alert.show();
                barcodeExists = false;
            }
        }
    }
    */

}
