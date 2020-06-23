package com.example.projetgestionbibliotheque;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.room.util.StringUtil;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;

public class LoginActivity extends AppCompatActivity {
    public FirebaseAuth fbLogin;
    public  FirebaseUser user;
    String txtMail , txtPw;
    public static String DbName="";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        fbLogin=FirebaseAuth.getInstance();
        user = fbLogin.getCurrentUser();


    }


    public void Connecter(View view) {

        try{
        txtMail=((EditText)findViewById(R.id.txtMail)).getText().toString();
        txtPw=((EditText)findViewById(R.id.txtPw)).getText().toString();


        fbLogin.signInWithEmailAndPassword(txtMail,txtPw)
                .addOnCompleteListener(LoginActivity.this, new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()){

                            Toast.makeText(LoginActivity.this, "Connection OK", Toast.LENGTH_LONG).show();
                            Intent t = new Intent(LoginActivity.this,MainActivity.class);
                            DbName=txtMail.toLowerCase();

                            startActivity(t);
                            finish();

                        }
                        else{

                            Toast.makeText(LoginActivity.this, "Verifier votre informations ", Toast.LENGTH_LONG).show();

                        }
                    }
                }).addOnFailureListener(LoginActivity.this, new OnFailureListener() {
            @Override
            public void onFailure(@NonNull Exception e) {
                Toast.makeText(LoginActivity.this, "Probleme !!! "+e.getMessage(), Toast.LENGTH_LONG).show();
            }
        });}
        catch (Exception e){
            Toast.makeText(LoginActivity.this, "Problème !!! "+e.getMessage(), Toast.LENGTH_LONG).show();
        }

    }
    public void ToRegisterActivity(View view) {

        Intent t = new Intent(LoginActivity.this,RegisterActivity.class);
        startActivity(t);
        finish();
    }
    }

