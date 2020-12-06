package com.example.projetgestionbibliotheque;

import androidx.room.Entity;
import androidx.room.ForeignKey;
import androidx.room.Ignore;
import androidx.room.PrimaryKey;

@Entity (primaryKeys = {"id_Livre","id_Eleve"})
public class Emprunt {

    @ForeignKey(entity = Livre.class,childColumns = "id_Livre",parentColumns = "id")
    int id_Livre;
    @ForeignKey(entity = Eleve.class,childColumns = "id_Eleve",parentColumns = "id")
    int id_Eleve;
    String date_Prise;
    String date_Retour;
    String  eleveName;
    String livreName;

    public Emprunt() {
    }

    public Emprunt(int id_Livre, int id_Eleve, String date_Prise, String date_Retour, String eleveName, String livreName) {
        this.id_Livre = id_Livre;
        this.id_Eleve = id_Eleve;
        this.date_Prise = date_Prise;
        this.date_Retour = date_Retour;
        this.eleveName = eleveName;
        this.livreName = livreName;
    }

    public int getId_Livre() {
        return id_Livre;
    }

    public void setId_Livre(int id_Livre) {
        this.id_Livre = id_Livre;
    }

    public int getId_Eleve() {
        return id_Eleve;
    }

    public void setId_Eleve(int id_Eleve) {
        this.id_Eleve = id_Eleve;
    }

    public String getDate_Prise() {
        return date_Prise;
    }

    public void setDate_Prise(String date_Prise) {
        this.date_Prise = date_Prise;
    }

    public String getDate_Retour() {
        return date_Retour;
    }

    public void setDate_Retour(String date_Retour) {
        this.date_Retour = date_Retour;
    }

    public String getEleveName() {
        return eleveName;
    }

    public void setEleveName(String eleveName) {
        this.eleveName = eleveName;
    }

    public String getLivreName() {
        return livreName;
    }

    public void setLivreName(String livreName) {
        this.livreName = livreName;
    }
}
