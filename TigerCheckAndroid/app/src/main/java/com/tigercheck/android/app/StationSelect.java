package com.tigercheck.android.app;

import java.util.ArrayList;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.CheckBox;

import com.tigercheck.android.app.R;

public class StationSelect extends Activity {

	public ArrayList<String> stationList = new ArrayList<String>();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_station_select);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.station_select, menu);
		return true;
	}
	
	public void onCheckboxClick (View view) {
		
		boolean checked = ((CheckBox)view).isChecked();
		
		if(checked) {
			stationList.add(Integer.toString(view.getId()));
		}
		else {
			stationList.remove(Integer.toString(view.getId()));
		}
	}
	
	public void submitButtonPress (View view) {

		Intent intent = new Intent(this, MainStation.class);
		intent.putStringArrayListExtra("key", stationList);
		startActivity(intent);
		finish();
	}

}
