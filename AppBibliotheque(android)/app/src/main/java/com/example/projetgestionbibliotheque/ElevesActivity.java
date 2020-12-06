package com.example.projetgestionbibliotheque;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.room.Room;

import android.annotation.SuppressLint;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Build;
import android.os.Bundle;
import android.text.Html;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;

import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

import static com.example.projetgestionbibliotheque.LoginActivity.DbName;

public class ElevesActivity extends AppCompatActivity {
    Database_Bib db ;
    Eleve eleve;
    String txtid,txtNom,txtPrenom,spClasse;
    LinearLayout layoutListe,layoutDetails;
    Button BtnListe,BtnDetails;
    RecyclerView recyclerView;
    static int Pos;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_eleves);
        layoutDetails=findViewById(R.id.LayoutDetails);
        layoutListe=findViewById(R.id.LayoutListe);
        BtnListe=findViewById(R.id.BtnListe);
        BtnDetails=findViewById(R.id.BtnDetails);
        recyclerView = findViewById(R.id.RecyclerListe);



        db= Room.databaseBuilder(ElevesActivity.this,Database_Bib.class,DbName)
                .allowMainThreadQueries().fallbackToDestructiveMigration().build();



        BtnListe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                BtnDetails.setVisibility(View.VISIBLE);
                BtnListe.setVisibility(View.GONE);
                layoutDetails.setVisibility(View.GONE);
                layoutListe.setVisibility(View.VISIBLE);

                List<Eleve> eleves = db.eleveDao().Eleves();
                RecyclerAdapter recyclerAdapter = new RecyclerAdapter(eleves);
                RecyclerView.LayoutManager lm = new LinearLayoutManager(ElevesActivity.this);
                recyclerView.setHasFixedSize(true);
                recyclerView.setLayoutManager(lm);
                recyclerView.setAdapter(recyclerAdapter);
            }
        });



    }

    public Eleve getEleve(){
        txtid = ((EditText)findViewById(R.id.txtId)).getText().toString();
        txtNom = ((EditText)findViewById(R.id.txtNom)).getText().toString();
        txtPrenom = ((EditText)findViewById(R.id.txtPrenom)).getText().toString();
        spClasse = ((Spinner)findViewById(R.id.spinnerClasse)).getSelectedItem().toString();

        Eleve eleve=new Eleve(txtNom,txtPrenom,spClasse);
        eleve.setId(Integer.valueOf(txtid));

        return eleve;
    }

    public void Ajouter(View view) {
        try {

            db.eleveDao().AjouterEleve(getEleve());

            Toast.makeText(ElevesActivity.this, "Bien Ajouter", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(ElevesActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Modifier(View view) {
        try {

        db.eleveDao().ModifierEleve(getEleve());

            Toast.makeText(ElevesActivity.this, "Bien Modifier", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(ElevesActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Supprimer(View view) {
        try {

            AlertDialog.Builder alert = new AlertDialog.Builder(ElevesActivity.this);
            alert.setMessage("Voulez vous supprimer ?");
            alert.setPositiveButton("Oui", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    db.eleveDao().SupprimerEleve(getEleve());

                    Toast.makeText(ElevesActivity.this, "Bien Supprimer", Toast.LENGTH_SHORT).show();
                }
            })
            .setNegativeButton("Non", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    dialog.dismiss();
                    Toast.makeText(ElevesActivity.this, "Suppression Annuler ", Toast.LENGTH_SHORT).show();

                }
            });

            AlertDialog alertDialog =alert.create();
            alertDialog.show();
        }catch (Exception ex){
            Toast.makeText(ElevesActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }


    @SuppressLint("ResourceAsColor")
    public void AfficherDetails(View view) {
        BtnListe.setVisibility(View.VISIBLE);
        BtnDetails.setVisibility(View.GONE);
        layoutListe.setVisibility(View.GONE);
        layoutDetails.setVisibility(View.VISIBLE);

    }

    public void Chercher(View view) {
try {
    txtid = ((EditText)findViewById(R.id.txtId)).getText().toString();
    Eleve eleve =db.eleveDao().ElevesByID(Integer.valueOf(txtid));
    if(eleve!=null){
        EditText etNom = findViewById(R.id.txtNom);
        EditText etPrenom=findViewById(R.id.txtPrenom);
        Spinner spClasse=findViewById(R.id.spinnerClasse);
        etNom.setText(eleve.getNom());
        etPrenom.setText(eleve.getPrenom());
        spClasse.setSelection(getIndex(spClasse,eleve.getClasse()));
    }
    else
        Toast.makeText(ElevesActivity.this, "N''existe Pas", Toast.LENGTH_LONG).show();

    }catch(Exception ex){
        Toast.makeText(ElevesActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
    }

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
