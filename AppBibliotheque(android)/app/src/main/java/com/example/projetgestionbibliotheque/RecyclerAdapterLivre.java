package com.example.projetgestionbibliotheque;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class RecyclerAdapterLivre extends RecyclerView.Adapter<RecyclerAdapterLivre.LivreViewHolder> {



   List<Livre> LivreList;


    public RecyclerAdapterLivre(List<Livre> livreList) {
        LivreList = livreList;
    }
    @NonNull
    @Override
    public LivreViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.livre_item,null,false);

        return new LivreViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull LivreViewHolder holder, int position) {
        Livre livre = LivreList.get(position);
        if (livre != null){

            holder.txtIdLivre.setText(livre.getId()+"");
            holder.txttitre.setText(livre.getTitre()+" de "+livre.getAuteur());
            holder.txtedition.setText("Edition : "+livre.getEdition());
            holder.txtquantite.setText("Nombre Exemplaire : "+livre.getQuantite());
        }
    }

    @Override
    public int getItemCount() {
        return LivreList.size();
    }

    public static class LivreViewHolder extends RecyclerView.ViewHolder{

        TextView txttitre;
        TextView txtIdLivre;
        TextView txtedition;
        TextView txtquantite;

        public LivreViewHolder(@NonNull View itemView) {
            super(itemView);

            txtIdLivre=itemView.findViewById(R.id.txtIdLivre);
            txttitre=itemView.findViewById(R.id.txttitre);
            txtedition=itemView.findViewById(R.id.txtedition);
            txtquantite=itemView.findViewById(R.id.txtquantite);
        }
    }
}
