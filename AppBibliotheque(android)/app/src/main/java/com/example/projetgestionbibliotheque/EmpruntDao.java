package com.example.projetgestionbibliotheque;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import java.util.List;

@Dao
public interface EmpruntDao {

    @Insert
    public void AjouterEmprunt(Emprunt eleve);

    @Update
    public void ModifierEmprunt(Emprunt eleve);

    @Delete
    public void SupprimerEmprunt(Emprunt eleve);

    @Query("Delete from Emprunt ")
    public void SupprimerAllEmprunt();

    @Query("Select * from Emprunt")
    public List<Emprunt> Emprunts();

    @Query("Select * from Emprunt where id_Eleve=:id")
    public Emprunt EmpruntsByIdEleve(int id);


}
