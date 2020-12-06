package com.example.projetgestionbibliotheque;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import java.util.ArrayList;
import java.util.List;

@Dao
public interface EleveDao {

    @Insert
    public void AjouterEleve(Eleve eleve);

    @Update
    public void ModifierEleve(Eleve eleve);

    @Delete
    public void SupprimerEleve(Eleve eleve);

    @Query("Select * from Eleve")
    public List<Eleve> Eleves();

    @Query("Select * from Eleve where id=:id")
    public Eleve ElevesByID(int id);

    @Query("Select  id||'- '||nom ||' '|| prenom from Eleve")
    public List<String> ElevesName();
}
