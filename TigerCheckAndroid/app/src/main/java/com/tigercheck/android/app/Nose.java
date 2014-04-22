/*
-----------------------------------------------------------------------------
Nose.java
Date Created: 4/20/2014
Date Last Modified: 4/22/2014
Author of Last Change: Nick Bean

Function: This is the station for entering Nose data.

Important Notes:
-----------------------------------------------------------------------------
*/

package com.tigercheck.android.app;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;

public class Nose extends ActionBarActivity {

    // Used for storing the data from the editText field.
    private EditText mEdit;

/*
________________________________________________________________
onCreate
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This is called when the activity is created. Takes bundle from last
activity and creates a variable with the contents.

Parameters: None

Returns: None

Important notes: This is a default code segment created with a little customization.
________________________________________________________________
*/
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nose);
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
        getMenuInflater().inflate(R.menu.nose, menu);
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

/*
________________________________________________________________
noseSubmitted
Date Last Modified: 4/22/2014
Name: Nick Bean

Functionality: This method is called by the XML code when the submit
    button is clicked. It validates the input then submits it to the
    database

Parameters: None

Returns: None

Important notes: This is much cleaner looking than using a listener
    in the onCreate method in my opinion
________________________________________________________________
*/
    public void noseSubmitted(View v)
    {
        mEdit = (EditText)findViewById(R.id.editText);

        // Setting up alert message for if invalid data is submitted
        final AlertDialog alert = new AlertDialog.Builder(this).create();
        alert.setTitle("Invalid");
        alert.setMessage("Invalid Input");
        alert.setButton("Ok", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialogInterface, int i) {

            }
        });

        // Checking for valid input
        if(mEdit.getText().toString().matches(""))
        {
            alert.show();
        }
        else
        {
            // This is where we need to add the call to the database.
            Log.v("EditText", mEdit.getText().toString());
            Intent intent = new Intent(this, StationSelect.class);
            startActivity(intent);
        }
    }
}
