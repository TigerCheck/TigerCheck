package com.example.tigercheck;

import java.util.ArrayList;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;

public class MainStation extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_station);
		
		Intent intent = getIntent();
		ArrayList<String> stationList = new ArrayList<String>();
		stationList = intent.getStringArrayListExtra("key");
		
		//Do call barcode scanning activity
		
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
	
	public void changeStations (View view) {
		Intent intent = new Intent(this, StationSelect.class);
		startActivity(intent);
		finish();
	}
	

}
