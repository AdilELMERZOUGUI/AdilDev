package com.example.projetgestionbibliotheque;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import static com.example.projetgestionbibliotheque.LoginActivity.DbName;

public class MainActivity extends AppCompatActivity {
    Intent t;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if(DbName==""){
            t = new Intent(MainActivity.this, LoginActivity.class);
            startActivity(t);
            finish();
        }

        Button btnProfil=findViewById(R.id.btnProfil);
        btnProfil.setText(DbName.toLowerCase());


    }

    public void ToGestionEleves(View view) {
         t = new Intent(MainActivity.this,ElevesActivity.class);
        startActivity(t);
    }

    public void ToGestionLivres(View view) {
         t = new Intent(MainActivity.this,LivresActivity.class);
        startActivity(t);
    }

    public void ToGestionEmprunts(View view) {
        t= new Intent(MainActivity.this,EmpruntsActivity.class);
        startActivity(t);
    }
    public void GoToLogin(View view) {



        AlertDialog.Builder alert = new AlertDialog.Builder(MainActivity.this);
        alert.setMessage("Voulez vous déconnecter ?");
        alert.setPositiveButton("Oui", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                t = new Intent(MainActivity.this, LoginActivity.class);
                startActivity(t);
                finish();
            }
        })
                .setNegativeButton("Non", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        dialog.dismiss();


                    }
                });

        AlertDialog alertDialog = alert.create();
        alertDialog.show();

    }

}
