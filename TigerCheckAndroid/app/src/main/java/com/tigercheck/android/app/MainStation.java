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
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;
import android.app.AlertDialog;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.util.ArrayList;


public class MainStation extends Activity {

    static final String SERVER_ADDRESS = "172.17.74.6:80";
    static final String USERNAME = "sa";
    static final String PASSWORD = "kidcheck2010";
    public int patientBarcode;
    Connection dbCon;

/*
________________________________________________________________
onCreate
Date Last Modified: 4/21/2014
Name: Zach White

Functionality: This is called when the activity is created. Takes bundle from last
activity and creates a variable with the contents.

Parameters: None

Returns: None

Important notes: The bundle isn't needed fo now since we are changing the way stations
are being called
________________________________________________________________
*/
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_station);
		
		Intent intent = getIntent();
		ArrayList<String> stationList = new ArrayList<String>();
		stationList = intent.getStringArrayListExtra("key");
		
		//Do call barcode scanning activity


        //Call Main station again to go scan a new student
			//intent = new Intent(this, MainStation.class);
			//startActivity(intent);
			//finish();
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
connectToDatabase
Date Last Modified: 4/21/2014
Name: Zach White

Functionality: Tries to make a connection to the database

Parameters: None

Returns: Boolean stating whether or not the app has made connection

Important notes:
________________________________________________________________
*/

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
            dbCon = DriverManager.getConnection("jdbc:sqlserver://" + SERVER_ADDRESS + ";user=" + USERNAME + ";password=" + PASSWORD + ";");
            connectionSucceeded = true;
            Log.w("Connection", "open");
        } catch (Exception e) {
            connectionSucceeded = false;
            Log.w("Error connection", " " + e.getMessage());
            alert.show();
        }
        return connectionSucceeded;
    }

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
    public void disconnectFromDatabase() {
        try {
            dbCon.close();
            Log.w("Connection", "close");
        } catch (Exception e) {
            Log.w("Error closing connection", " " + e.getMessage());
        }
    }

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
    public boolean checkBarcode(View view) {
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
        return barcodeExists;
    }

/*
________________________________________________________________
goThroughStations
Date Last Modified: 4/7/2014
Name: Zach White

Functionality: Loops through all of the stations passed in by the station select activity

Parameters: array list of the selected stations

Returns: None

Important notes: Currently not used. This will need to be implemented if you change the way
stations are called
________________________________________________________________
*/
    private void goThroughStations(ArrayList stations) {
        //Loop through received arraylist and call station activities
        //int size = stationList.size();
        //for(int i =0; i < size; i++) {
        //String check = stationList.get(i);
        //if(check.equals("R.id.checkbox_blood_Pressure")) {
        //intent = new Intent(this,BloodPressureStation.class);
        //startActivity(intent);
        //}
        //else if(check.equals("R.id.checkbox_heart_rate")) {
        //intent = new Intent(this,HeartRateStation.class);
        //startActivity(intent);
        //}
        //}
    }

    /*
        ________________________________________________________________
        changeStationsBtnLstr
        Date Last Modified: 4/7/2014
        Name: Zach White

        Functionality: Returns to the change stations activity

        Parameters: None

        Returns: None

        Important notes:
        ________________________________________________________________
        */
    public void changeStationsBtnLstr (View view) {
		Intent intent = new Intent(this, StationSelect.class);
		startActivity(intent);
		finish();
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
    protected void onStop() {
        disconnectFromDatabase();
    }

}
