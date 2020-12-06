package com.example.projetgestionbibliotheque;

import android.annotation.SuppressLint;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.room.Room;

import java.util.List;

import static com.example.projetgestionbibliotheque.LoginActivity.DbName;

public class LivresActivity extends AppCompatActivity {
    Database_Bib db ;
    Livre livre;
    String txtCode,txtTitre,txtAuteur,txtEdition,txtQuantite;
    LinearLayout layoutListe,layoutDetails;
    Button BtnListe,BtnDetails;
    RecyclerView recyclerView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_livres);
        layoutDetails=findViewById(R.id.LayoutDetails);
        layoutListe=findViewById(R.id.LayoutListe);
        BtnListe=findViewById(R.id.BtnListe);
        BtnDetails=findViewById(R.id.BtnDetails);
        recyclerView = findViewById(R.id.RecyclerListe);



        db= Room.databaseBuilder(LivresActivity.this,Database_Bib.class,DbName)
                .allowMainThreadQueries().fallbackToDestructiveMigration().build();



        BtnListe.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                BtnDetails.setVisibility(View.VISIBLE);
                BtnListe.setVisibility(View.GONE);
                layoutDetails.setVisibility(View.GONE);
                layoutListe.setVisibility(View.VISIBLE);

                List<Livre> livres = db.livreDao().Livres();
                RecyclerAdapterLivre recyclerAdapter = new RecyclerAdapterLivre(livres);
                RecyclerView.LayoutManager lm = new LinearLayoutManager(LivresActivity.this);
                recyclerView.setHasFixedSize(true);
                recyclerView.setLayoutManager(lm);
                recyclerView.setAdapter(recyclerAdapter);
            }
        });



    }


    public Livre getLivre(){
        txtCode = ((EditText)findViewById(R.id.txtCode)).getText().toString();
        txtTitre = ((EditText)findViewById(R.id.txtTitre)).getText().toString();
        txtAuteur = ((EditText)findViewById(R.id.txtAuteur)).getText().toString();
        txtEdition = ((EditText)findViewById(R.id.txtEdition)).getText().toString();
        txtQuantite = ((EditText)findViewById(R.id.txtQuantite)).getText().toString();


        Livre livre=new Livre(txtTitre,txtAuteur,txtEdition,Integer.valueOf(txtQuantite));
        livre.setId(Integer.valueOf(txtCode));

        return livre;
    }
    public void Ajouter(View view) {
        try {

            db.livreDao().AjouterLivre(getLivre());

            Toast.makeText(LivresActivity.this, "Bien Ajouter", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(LivresActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Modifier(View view) {
        try {

        db.livreDao().ModifierLivre(getLivre());

            Toast.makeText(LivresActivity.this, "Bien Modifier", Toast.LENGTH_SHORT).show();
        }catch (Exception ex){
            Toast.makeText(LivresActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
        }
    }
    public void Supprimer(View view) {
        try {

            AlertDialog.Builder alert = new AlertDialog.Builder(LivresActivity.this);
            alert.setMessage("Voulez vous supprimer ?");
            alert.setPositiveButton("Oui", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    db.livreDao().SupprimerLivre(getLivre());

                    Toast.makeText(LivresActivity.this, "Bien Supprimer", Toast.LENGTH_SHORT).show();
                }
            })
            .setNegativeButton("Non", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    dialog.dismiss();
                    Toast.makeText(LivresActivity.this, "Suppression Annuler ", Toast.LENGTH_SHORT).show();

                }
            });

            AlertDialog alertDialog =alert.create();
           alertDialog.show();
        }catch (Exception ex){
            Toast.makeText(LivresActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
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
    txtCode = ((EditText)findViewById(R.id.txtCode)).getText().toString();
    Livre livre =db.livreDao().LivresByID(Integer.valueOf(txtCode));
    if(livre!=null){
        EditText etTitre= findViewById(R.id.txtTitre);
        EditText etAuteur=findViewById(R.id.txtAuteur);
        EditText etEdition=findViewById(R.id.txtEdition);
        EditText etQuantite=findViewById(R.id.txtQuantite);
        etTitre.setText(livre.getTitre());
        etAuteur.setText(livre.getAuteur());
        etEdition.setText(livre.getEdition());
        etQuantite.setText(livre.getQuantite()+"");
    }
    else
        Toast.makeText(LivresActivity.this, "N''existe Pas", Toast.LENGTH_LONG).show();

    }catch(Exception ex){
        Toast.makeText(LivresActivity.this, ex.getMessage(), Toast.LENGTH_SHORT).show();
    }

}
}
