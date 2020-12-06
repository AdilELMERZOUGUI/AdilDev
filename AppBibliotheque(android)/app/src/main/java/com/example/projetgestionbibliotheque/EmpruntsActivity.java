package com.example.projetgestionbibliotheque;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.room.Room;

import android.annotation.SuppressLint;
import android.app.DatePickerDialog;
import android.content.DialogInterface;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.SimpleAdapter;
import android.widget.Spinner;
import android.widget.SpinnerAdapter;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

import static com.example.projetgestionbibliotheque.LoginActivity.DbName;

public class EmpruntsActivity extends AppCompatActivity {
    public static Database_Bib db ;
    Emprunt emprunt;
    String txtDatePrise,txtDateRetour,spEleve,spLivre;
    LinearLayout layoutListe,layoutDetails;
    Button BtnListe,BtnDetails;
    RecyclerView recyclerView;
    DatePickerDialog.OnDateSetListener dateSetListenerP ,dateSetListenerR ;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_emprunts);
        layoutDetails=findViewById(R.id.LayoutDetails);
        layoutListe=findViewById(R.id.LayoutListe);
        BtnListe=findViewById(R.id.BtnListe);
        BtnDetails=findViewById(R.id.BtnDetails);
        recyclerView = findViewById(R.id.RecyclerListe);
        final EditText etDateP= findViewById(R.id.txtDatePrise);
        final EditText etDateR= findViewById(R.id.txtDateRetour);


        db= Room.databaseBuilder(EmpruntsActivity.this,Database_Bib.class,DbName)
                .allowMainThreadQueries().fallbackToDestructiveMigration().build();

      getEleve();

        etDateP.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                GregorianCalendar calendar = new GregorianCalendar();
                calendar.setTime(new Date());

                int annee =calendar.get(GregorianCalendar.YEAR) ;
                int mois =calendar.get(GregorianCalendar.MONTH) +1 ;
                        int jour =calendar.get(GregorianCalendar.DAY_OF_MONTH)  ;



                DatePickerDialog dialog =new DatePickerDialog(EmpruntsActivity.this,
                        android.R.style.Widget_Holo
                        ,dateSetListenerP,annee,mois,jour);

                dialog.show();
            }
        });
        dateSetListenerP = new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int year, int month, int day) {


                String date = day + "/" + month + "/" + year;
                etDateP.setText(date);
            }
        };

       etDateR.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                GregorianCalendar calendar = new GregorianCalendar();
                calendar.setTime(new Date());

                int annee =calendar.get(GregorianCalendar.YEAR) ;
                int mois =calendar.get(GregorianCalendar.MONTH) +1 ;
                        int jour =calendar.get(GregorianCalendar.DAY_OF_MONTH)  ;



                DatePickerDialog dialog =new DatePickerDialog(EmpruntsActivity.this,
                        android.R.style.Widget_Holo
                        ,dateSetListenerR,annee,mois,jour);

                dialog.show();
            }
        });
        dateSetListenerR = new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int year, int month, int day) {


                String date = day + "/" + month + "/" + year;
                etDateR.setText(date);
            }
        };


        BtnListe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                try{
                BtnDetails.setVisibility(View.VISIBLE);
                BtnListe.setVisibility(View.GONE);
                layoutDetails.setVisibility(View.GONE);
                layoutListe.setVisibility(View.VISIBLE);


                List<Emprunt> emprunts = db.empruntDao().Emprunts();
                RecyclerAdapterEmprunt recyclerAdapter = new RecyclerAdapterEmprunt(emprunts);
                RecyclerView.LayoutManager lm = new LinearLayoutManager(EmpruntsActivity.this);
                recyclerView.setHasFixedSize(true);
                recyclerView.setLayoutManager(lm);
                recyclerView.setAdapter(recyclerAdapter);
                }
                catch (Exception e){
                    Toast.makeText(EmpruntsActivity.this, "Problème !!! "+e.getMessage(), Toast.LENGTH_LONG).show();
                }

            }
        });
    }

    public void getEleve(){

        Spinner spinnerEleve= findViewById(R.id.spinnerEleve);
        Spinner spinnerLivre= findViewById(R.id.spinnerLivre);

        List<String> eleves = db.eleveDao().ElevesName();
        List<String> livres = db.livreDao().LivresName();

        ArrayAdapter<String> elevesAdapter = new ArrayAdapter(EmpruntsActivity.this,android.R.layout.simple_spinner_dropdown_item,eleves);
        ArrayAdapter<String> livresAdapter = new ArrayAdapter(EmpruntsActivity.this,android.R.layout.simple_spinner_dropdown_item,livres);

        spinnerEleve.setAdapter(elevesAdapter);
        spinnerLivre.setAdapter(livresAdapter);
    }

    public Emprunt getEmprunt(){
        db= Room.databaseBuilder(EmpruntsActivity.this,Database_Bib.class,DbName)
                .allowMainThreadQueries().fallbackToDestructiveMigration().build();

        txtDateRetour = ((EditText)findViewById(R.id.txtDateRetour)).getText().toString();
        txtDatePrise = ((EditText)findViewById(R.id.txtDatePrise)).getText().toString();
        spEleve = ((Spinner)findViewById(R.id.spinnerEleve)).getSelectedItem().toString();
        spLivre = ((Spinner)findViewById(R.id.spinnerLivre)).getSelectedItem().toString();

        int idEleve=Integer.valueOf(spEleve.split("-")[0]);
        int idLivre=Integer.valueOf(spLivre.split("-")[0]);
        String nameEleve=spEleve.split("-")[1];
        String nameLivre=spLivre.split("-")[1];

        Emprunt emprunt=new Emprunt(idEleve,idLivre,txtDatePrise,txtDateRetour,nameEleve,nameLivre);

        return emprunt;
    }

    public void Ajouter(View view) {
        try {
            db.livreDao().QuantiteMoins(getEmprunt().getId_Livre());
            db.empruntDao().AjouterEmprunt(getEmprunt());

            Toast.makeText(EmpruntsActivity.this, "Bien Ajouter", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(EmpruntsActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Modifier(View view) {
        try {

            db.empruntDao().ModifierEmprunt(getEmprunt());

            Toast.makeText(EmpruntsActivity.this, "Bien Modifier", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(EmpruntsActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Supprimer(View view) {
        try {

            AlertDialog.Builder alert = new AlertDialog.Builder(EmpruntsActivity.this);
            alert.setMessage("Voulez vous supprimer ?");
            alert.setPositiveButton("Oui", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    db.livreDao().QuantitePlus(getEmprunt().getId_Livre());
                    db.empruntDao().SupprimerEmprunt(getEmprunt());


                    Toast.makeText(EmpruntsActivity.this, "Bien Supprimer", Toast.LENGTH_SHORT).show();
                }
            })
                    .setNegativeButton("Non", new DialogInterface.OnClickListener() {
                        @Override
                        public void onClick(DialogInterface dialog, int which) {
                            dialog.dismiss();
                            Toast.makeText(EmpruntsActivity.this, "Suppression Annuler ", Toast.LENGTH_SHORT).show();

                        }
                    });

            AlertDialog alertDialog =alert.create();
            alertDialog.show();
        }catch (Exception ex){
            Toast.makeText(EmpruntsActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }


    @SuppressLint("ResourceAsColor")
    public void AfficherDetails(View view) {
        BtnListe.setVisibility(View.VISIBLE);
        BtnDetails.setVisibility(View.GONE);
        layoutListe.setVisibility(View.GONE);
        layoutDetails.setVisibility(View.VISIBLE);

    }


    private int getIndex(Spinner spinner, String NomClasse){
        for (int i=0;i<spinner.getCount();i++){
            if (spinner.getItemAtPosition(i).toString().equalsIgnoreCase(NomClasse)){
                return i;
            }
        }

        return 0;
    }
}

