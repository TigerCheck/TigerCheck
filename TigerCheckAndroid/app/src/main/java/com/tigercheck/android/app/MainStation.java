package com.tigercheck.android.app;


import java.sql.Connection;
import java.sql.Statement;
import java.sql.DriverManager;
import java.util.ArrayList; //make this objects and check instance of


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;


public class MainStation extends Activity {

    static final String SERVER_ADDRESS= "192.168.1.2";
    public int patientBarcode;

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

    private void checkBarcode(int barcode) {
        //check and set
        patientBarcode = barcode;
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
