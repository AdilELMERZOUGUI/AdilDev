package com.example.projetgestionbibliotheque;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

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

public class RegisterActivity extends AppCompatActivity {
    private FirebaseAuth fbLogin;
    String txtMail , txtPw;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);


        fbLogin=FirebaseAuth.getInstance();
        FirebaseUser user = fbLogin.getCurrentUser();


    }

    public void CreateCompte(View view) {
        try{
        txtMail=((EditText)findViewById(R.id.txtmail)).getText().toString();
        txtPw=((EditText)findViewById(R.id.txtpw)).getText().toString();
        if(txtMail=="" || txtPw==""){
            Toast.makeText(RegisterActivity.this, "Tapez votre informations ", Toast.LENGTH_LONG).show();
            return;
        }
        fbLogin.createUserWithEmailAndPassword(txtMail,txtPw)
                .addOnCompleteListener(RegisterActivity.this, new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if(task.isSuccessful()){
                            Toast.makeText(RegisterActivity.this, "Votre compte est créer avec succés", Toast.LENGTH_LONG).show();
                            Intent t = new Intent(RegisterActivity.this,LoginActivity.class);
                            startActivity(t);
                            finish();
                        }

                    }
                }).addOnFailureListener(RegisterActivity.this, new OnFailureListener() {
            @Override
            public void onFailure(@NonNull Exception e) {
                Toast.makeText(RegisterActivity.this, "Probleme !!! "+e.getMessage(), Toast.LENGTH_LONG).show();
            }
        });}
        catch (Exception e){
        Toast.makeText(RegisterActivity.this, "Problème !!! "+e.getMessage(), Toast.LENGTH_LONG).show();
    }

    }

    public void GoToLogin(View view) {
        Intent t = new Intent(RegisterActivity.this,LoginActivity.class);
        startActivity(t);
        finish();

    }


}

