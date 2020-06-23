package com.example.projetgestionbibliotheque;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.Query;
import androidx.room.Update;

import java.util.List;

@Dao
public interface LivreDao {

    @Insert
    public void AjouterLivre(Livre livre);

    @Update
    public void ModifierLivre(Livre livre);

    @Delete
    public void SupprimerLivre(Livre livre);

    @Query("Select * from Livre")
    public List<Livre> Livres ();

    @Query("Select * from Livre where id=:code")
    public Livre LivresByID (int code);

    @Query("Select id||'- '||titre ||' by '|| auteur from Livre where quantite > 0")
    public List<String> LivresName ();

    @Query("Update Livre set quantite=quantite+1 where id=:code")
    public void QuantitePlus (int code);

    @Query("Update Livre set quantite=quantite-1 where id=:code")
    public void QuantiteMoins (int code);
}
