package com.example.projetgestionbibliotheque;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;
import androidx.room.Room;

import java.util.List;


import static com.example.projetgestionbibliotheque.LoginActivity.DbName;

public  class RecyclerAdapterEmprunt extends RecyclerView.Adapter<RecyclerAdapterEmprunt.EmpruntViewHolder> {



   List<Emprunt> EmpruntList;
Database_Bib db;

    public RecyclerAdapterEmprunt(List<Emprunt> empruntList) {
        EmpruntList = empruntList;
    }
    @NonNull
    @Override
    public EmpruntViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.emprunt_item,null,false);
        db= Room.databaseBuilder(parent.getContext(),Database_Bib.class,DbName)
                .allowMainThreadQueries().build();
        return new EmpruntViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull EmpruntViewHolder holder, int position) {

try {

        Emprunt emprunt = EmpruntList.get(position);

        if (emprunt != null  ) {
            holder.txtEleve.setText(emprunt.getEleveName());
            holder.txtLivre.setText(emprunt.getLivreName());
            holder.txtDate.setText(emprunt.date_Prise + " - " + emprunt.date_Retour);
        }
}
        catch(Exception ex){
            holder.txtEleve.setText(ex.getMessage());
    }
        }



    @Override
    public int getItemCount() {
        return EmpruntList.size();
    }

    public static class EmpruntViewHolder extends RecyclerView.ViewHolder{

        TextView txtEleve,txtDate,txtLivre;



        public EmpruntViewHolder(@NonNull View itemView) {
            super(itemView);
            txtEleve=itemView.findViewById(R.id.txtEleveName);
            txtLivre=itemView.findViewById(R.id.txtLivreName);
            txtDate=itemView.findViewById(R.id.txtDate);
        }
    }
}
