package com.example.projetgestionbibliotheque;

import androidx.room.Entity;
import androidx.room.PrimaryKey;
@Entity
public class Eleve {
    @PrimaryKey(autoGenerate = true)
    int id ;
    String nom;
    String prenom;
    String classe;


    public Eleve() {

    }

    public Eleve(int id, String nom, String prenom, String classe) {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.classe = classe;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Eleve(String nom, String prenom, String classe) {
        this.nom = nom;
        this.prenom = prenom;
        this.classe = classe;
    }

    public int getId() {
        return id;
    }

    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getPrenom() {
        return prenom;
    }

    public void setPrenom(String prenom) {
        this.prenom = prenom;
    }

    public String getClasse() {
        return classe;
    }

    public void setClasse(String classe) {
        this.classe = classe;
    }
}