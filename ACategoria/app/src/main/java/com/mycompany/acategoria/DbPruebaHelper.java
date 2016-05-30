package com.mycompany.acategoria;


import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.provider.BaseColumns;

/**
 * Created by mati on 25/05/16.
 */
public class DbPruebaHelper extends SQLiteOpenHelper {

    private static final String DATABASE_NAME = "dbprueba.db";
    private static final int DATABASE_VERSION = 1;


    private static Context context;
    public static void init(Context context){

        DbPruebaHelper.context=context;

    }

    private static DbPruebaHelper instance;
    public static DbPruebaHelper getinstance(){

        if(instance == null)
            instance = new DbPruebaHelper(context);
        return instance;

    }

    public static abstract class TableCategoria implements BaseColumns{
        public static final String NAME = "categoria";
        public static final String COLUMN_NOMBRE = "nombre";

    }

    private static final String CREATE_TABLE_CATEGORIA = "create table" + TableCategoria.NAME + "("+
            TableCategoria._ID + "integer primary key," + TableCategoria.COLUMN_NOMBRE + "text" + ");";

    private static final String DROP_TABLE_CATEGORIA = "drop table if exists " +TableCategoria.NAME;

    public DbPruebaHelper(Context context){

        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    public void onCreate(SQLiteDatabase db){
        db.execSQL(CREATE_TABLE_CATEGORIA);

    }

    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion){
        db.execSQL(DROP_TABLE_CATEGORIA);
        onCreate(db);

    }

    public long insertCategoria(String nombre){

        SQLiteDatabase sqLiteDatabase = getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(TableCategoria.COLUMN_NOMBRE, nombre);
        return sqLiteDatabase.insert(TableCategoria.NAME,null,contentValues);

    }

}
