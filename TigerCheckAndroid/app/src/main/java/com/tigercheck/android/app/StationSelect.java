/*
-----------------------------------------------------------------------------
StationSelect.java
Date Created: 4/20/2014
Date Last Modified: 4/22/2014
Author of Last Change: Nick Bean

Function: This is the window where the nurse will select which station to
    record data for.

Important Notes: Not the most efficient way of doing this. A more dynamic
    station selection would help nurses. However for the sake of starting off
    simple and having a finished product, I went with this method.
-----------------------------------------------------------------------------
*/

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

/*
________________________________________________________________
onCreate
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This is called when the activity is created. Takes bundle from last
activity and creates a variable with the contents.

Parameters: None

Returns: None

Important notes: This is a default code segment.
________________________________________________________________
*/
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_station_select);
	}

/*
________________________________________________________________
onStationSelected
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This is called by the xml code when a station button
    is clicked.

Parameters: None

Returns: None

Important notes: Uses a simple switch statement to determine which
    button was pressed. Then sends the user to data station related
    to that button.
________________________________________________________________
*/
	public void onStationSelected (View v)
    {
        Intent intent;
        switch(v.getId())
        {
            case R.id.bloodPressureButton:
                intent = new Intent(this, BloodPressure.class);
                startActivity(intent);
                break;
            case R.id.respirationRateButton:
                intent = new Intent(this, RespirationRate.class);
                startActivity(intent);
                break;
            case R.id.heightWeightButton:
                intent = new Intent(this, HeightWeight.class);
                startActivity(intent);
                break;
            case R.id.bloodSugarButton:
                intent = new Intent(this, BloodSugar.class);
                startActivity(intent);
                break;
            case R.id.temperatureButton:
                intent = new Intent(this, Temperature.class);
                startActivity(intent);
                break;
            case R.id.cholesterolButton:
                intent = new Intent(this, Cholesterol.class);
                startActivity(intent);
                break;
            case R.id.heartRateButton:
                intent = new Intent(this, HeartRate.class);
                startActivity(intent);
                break;
            case R.id.scoliosisButton:
                intent = new Intent(this, Scoliosis.class);
                startActivity(intent);
                break;
            case R.id.lungsButton:
                intent = new Intent(this, Lungs.class);
                startActivity(intent);
                break;
            case R.id.dentalButton:
                intent = new Intent(this, Dental.class);
                startActivity(intent);
                break;
            case R.id.noseButton:
                intent = new Intent(this, Nose.class);
                startActivity(intent);
                break;
            case R.id.visionButton:
                intent = new Intent(this, Vision.class);
                startActivity(intent);
                break;
            case R.id.earsButton:
                intent = new Intent(this, Ears.class);
                startActivity(intent);
                break;
            case R.id.heartButton:
                intent = new Intent(this, Heart.class);
                startActivity(intent);
                break;
            case R.id.throatButton:
                intent = new Intent(this, Throat.class);
                startActivity(intent);
                break;
            case R.id.newPatientButton:
                intent = new Intent(this, MainStation.class);
                startActivity(intent);
                break;
        }
	}

}
