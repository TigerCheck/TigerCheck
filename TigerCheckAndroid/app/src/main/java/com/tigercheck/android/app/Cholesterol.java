/*
-----------------------------------------------------------------------------
Cholesterol.java
Date Created: 4/20/2014
Date Last Modified: 4/22/2014
Author of Last Change: Nick Bean

Function: This is the station for entering Cholesterol data.

Important Notes:
-----------------------------------------------------------------------------
*/

package com.tigercheck.android.app;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class Cholesterol extends ActionBarActivity {


/*
________________________________________________________________
onCreate
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This is called when the activity is created. Takes bundle from last
activity and creates a variable with the contents. It also listens for the submit
button to be clicked, which would then submit the data to the database.

Parameters: None

Returns: None

Important notes: This is a default code segment created with a little customization.
________________________________________________________________
*/
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cholesterol);
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
        getMenuInflater().inflate(R.menu.cholesterol, menu);
        return true;
    }

/*
________________________________________________________________
onOptionsItemSelected
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: I don't know, its created by default.

Parameters: None

Returns: None

Important notes: May not be used, but is created by default.
________________________________________________________________
*/
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_settings) {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

}
