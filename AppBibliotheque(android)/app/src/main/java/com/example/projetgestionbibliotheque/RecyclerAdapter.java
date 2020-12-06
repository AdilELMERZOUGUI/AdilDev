package com.example.projetgestionbibliotheque;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

public class RecyclerAdapter extends RecyclerView.Adapter<RecyclerAdapter.EleveViewHolder> {



   List<Eleve> EleveList;


    public RecyclerAdapter(List<Eleve> eleveList) {
        EleveList = eleveList;
    }
    @NonNull
    @Override
    public EleveViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.eleve_item,null,false);

        return new EleveViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull EleveViewHolder holder, int position) {
        Eleve eleve = EleveList.get(position);
        if (eleve != null){

            holder.txtId.setText(eleve.getId()+"");
            holder.txtNomEleve.setText(eleve.getNom().toUpperCase()+" "+eleve.getPrenom().substring(0, 1).toUpperCase()+eleve.getPrenom().substring(1));
            holder.txtClasse.setText(eleve.getClasse());
        }
    }

    @Override
    public int getItemCount() {
        return EleveList.size();
    }

    public static class EleveViewHolder extends RecyclerView.ViewHolder{

        TextView txtNomEleve;
        TextView txtClasse;
        TextView txtId;

        public EleveViewHolder(@NonNull View itemView) {
            super(itemView);

            txtId=itemView.findViewById(R.id.txtId);
            txtNomEleve=itemView.findViewById(R.id.txtNomEleve);
            txtClasse=itemView.findViewById(R.id.txtClasse);
        }
    }
}
