package com.mycompany.acategoria;

import android.app.DownloadManager;
import android.database.sqlite.SQLiteDatabase;

import java.util.List;

/**
 * Created by mati on 30/05/16.
 */
public class Categoria {

    public long id;
    public String nombre;

    public Categoria(String nombre, long id) {
        this.nombre = nombre;
        this.id = id;
    }

    public String toString(){

        return String.format("[%d] %s", id, nombre);

    }

    public List<Categoria> getCategorias() {
    }



}
