package com.example.projetgestionbibliotheque;

import android.content.Context;

import androidx.room.Database;
import androidx.room.Room;
import androidx.room.RoomDatabase;



@Database(entities = {Livre.class,Eleve.class,Emprunt.class},version = 12)
public abstract class Database_Bib extends RoomDatabase {



    public abstract LivreDao livreDao() ;
    public abstract EmpruntDao empruntDao() ;
    public abstract EleveDao eleveDao() ;



}
