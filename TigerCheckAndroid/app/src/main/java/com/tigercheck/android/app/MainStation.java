package com.tigercheck.android.app;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.util.ArrayList;


public class MainStation extends Activity {

    static final String SERVER_ADDRESS= "192.168.1.2";
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

        try {
            dbCon.close();
            Log.w("Connection", "close");
        } catch (Exception e) {
            Log.w("Error closing connection", " " + e.getMessage());
        }
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

    public void connectToDatabase() {
        try {
            Class.forName("net.sourceforge.jtds.jdbc.Driver").newInstance();
            dbCon = DriverManager.getConnection("jdbc:jtds:sqlserver://192,168.1.2:1433/DATABASE");
            Log.w("Connection", "open");
        } catch (Exception e) {
            Log.w("Error connection", " " + e.getMessage());
        }
    }

    private void checkBarcode(int barcode) {
        //check and set
        patientBarcode = barcode;
        try {
            Statement stmt = dbCon.createStatement();
            Log.w("Barcode check", "statement");
        } catch (Exception e) {
            Log.w("Barcode check", " " + e.getMessage());
        }
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

}
