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

    static final String SERVER_ADDRESS= "192.168.1.10";
    public int patientBarcode;
    Connection dbCon;

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

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main_station, menu);
		return true;
	}

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
            dbCon = DriverManager.getConnection("jdbc:sqlserver://" + SERVER_ADDRESS + ";");
            connectionSucceeded = true;
            Log.w("Connection", "open");
        } catch (Exception e) {
            connectionSucceeded = false;
            Log.w("Error connection", " " + e.getMessage());
            alert.show();
        }
        return connectionSucceeded;
    }

    public void disconnectFromDatabase() {
        try {
            dbCon.close();
            Log.w("Connection", "close");
        } catch (Exception e) {
            Log.w("Error closing connection", " " + e.getMessage());
        }
    }

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
                Log.w("Barcode check", "statement");
                barcodeExists = true;
            } catch (Exception e) {
                Log.w("Barcode check", " " + e.getMessage());
                alert.show();
                barcodeExists = false;
            }
        }
        return barcodeExists;
    }

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

	public void changeStationsBtnLstr (View view) {
		Intent intent = new Intent(this, StationSelect.class);
		startActivity(intent);
		finish();
	}

    protected void onStop() {
        disconnectFromDatabase();
    }

}
