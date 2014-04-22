/*
-----------------------------------------------------------------------------
WelcomeScreen.java
Date Created: 4/20/2014
Date Last Modified: 4/22/2014
Author of Last Change: Nick Bean

Function: This is simply the welcome screen that is shown when the app is
    launched.

Important Notes:
-----------------------------------------------------------------------------
*/

package com.tigercheck.android.app;


import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;

public class WelcomeScreen extends Activity {

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
		setContentView(R.layout.activity_welcome_screen);
	}

/*
________________________________________________________________
onCreateOptionsMenu
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: Creates settings menu

Parameters: None

Returns: None

Important notes: Not used. Created by default.
________________________________________________________________
*/
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.welcome_screen, menu);
		return true;
	}

    /*
________________________________________________________________
continueButtonPress
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This method is called by the xml code when the continue
    button is pressed. It takes you to the Main Station.

Parameters: None

Returns: None

Important notes:
________________________________________________________________
*/
	public void continueButtonPress(View view) {
		Intent intent = new Intent(this, MainStation.class);
		startActivity(intent);
		finish();
	}

}
