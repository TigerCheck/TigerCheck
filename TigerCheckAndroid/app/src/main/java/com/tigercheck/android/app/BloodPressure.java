package com.tigercheck.android.app;

import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.util.Log;

public class BloodPressure extends ActionBarActivity {

    Button mButton;
    EditText mEdit;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_blood_pressure);

        mButton = (Button)findViewById(R.id.button);
        mEdit = (EditText)findViewById(R.id.editText);

        // Here is a listener I use to collect the data instead of using the xml onClick
        // No real reason for chosing this over the other just what I did.
        mButton.setOnClickListener(
            new View.OnClickListener()
            {
            public void onClick(View view)
            {
                // This is where we need to add the call to the database.
                Log.v("EditText", mEdit.getText().toString());
            }
            }
        );
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.blood_pressure, menu);
        return true;
    }

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
