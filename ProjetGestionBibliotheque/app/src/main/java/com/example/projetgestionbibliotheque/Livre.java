package com.example.projetgestionbibliotheque;


import androidx.room.Entity;
import androidx.room.Ignore;
import androidx.room.PrimaryKey;

@Entity
public class Livre {

    @PrimaryKey(autoGenerate = true)
    private int id;
    private String titre ;
    private String auteur;
    private String edition;
    private int quantite;


    public Livre() {
    }

    public Livre(int id, String titre, String auteur, String edition, int quantite) {
        this.id = id;
        this.titre = titre;
        this.auteur = auteur;
        this.edition = edition;
        this.quantite = quantite;
    }

    public Livre(String titre, String auteur, String edition, int quantite) {
        this.titre = titre;
        this.auteur = auteur;
        this.edition = edition;
        this.quantite = quantite;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTitre() {
        return titre;
    }

    public void setTitre(String titre) {
        this.titre = titre;
    }

    public String getAuteur() {
        return auteur;
    }

    public void setAuteur(String auteur) {
        this.auteur = auteur;
    }

    public String getEdition() {
        return edition;
    }

    public void setEdition(String edition) {
        this.edition = edition;
    }

    public int getQuantite() {
        return quantite;
    }

    public void setQuantite(int quantite) {
        this.quantite = quantite;
    }
}
