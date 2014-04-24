/*
-----------------------------------------------------------------------------
DataHandler.java
Date Created: 4/20/2014
Date Last Modified: 4/22/2014
Author of Last Change: Nick Bean

Function: This is the data handler that is supposed to communicate to the
    SQLite database on the Android tablet.

Important Notes: I followed these tutorials:
    https://www.youtube.com/watch?v=fceqoJ61ANY
    https://www.youtube.com/watch?v=ilpUe0Lkt8o
    All the names and stuff need to be changed appropriately to this project
    and a lot more work needs to be done. But this is as far as I could get.
    The goal is to store everything in a SQLite table on the android tablet
    and then transfer all that to the SQL server on the laptop somehow, either
    via a PHP/REST/JSON communication or something.

    Sorry this isn't commeneted correctly but I was to pressed for my time.
-----------------------------------------------------------------------------
*/

package com.tigercheck.android.app;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteException;
import android.database.sqlite.SQLiteOpenHelper;

public class DataHandler {
    public static final String NAME = "name";
    public static final String TABLE_NAME = "myTable";
    public static final String DATA_BASE_NAME = "myDatabase";
    public static final int DATABASE_VERSION = 1;
    public static final String TABLE_CREATE = "create table myTable (name text not null);";

    DatabaseHelper dbHelper;
    Context ctx;
    SQLiteDatabase db;

    public DataHandler(Context ctx)
    {
        this.ctx = ctx;
        dbHelper = new DatabaseHelper(ctx);
    }

    private static class DatabaseHelper extends SQLiteOpenHelper
    {
        public DatabaseHelper(Context ctx)
        {
            super(ctx, DATA_BASE_NAME, null, DATABASE_VERSION);
        }

        @Override
        public void onCreate(SQLiteDatabase db) {

            try{
                db.execSQL(TABLE_CREATE);
            }
            catch(SQLiteException e)
            {
                e.printStackTrace();
            }

        }

        @Override
        public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

            db.execSQL("DROP TABLE IF EXISTS ");
            onCreate(db);

        }
    }

    public DataHandler open()
    {
        db = dbHelper.getWritableDatabase();
        return this;
    }

    public void close()
    {
        dbHelper.close();
    }

    public long insertData(String name)
    {
        ContentValues content = new ContentValues();
        content.put(NAME, name);

        return db.insertOrThrow(TABLE_NAME, null, content);
    }

    public Cursor returnData()
    {
        return db.query(TABLE_NAME, new String[] {NAME}, null, null, null, null, null);
    }


}
