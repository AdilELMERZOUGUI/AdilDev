//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rendez_vous
    {
        public rendez_vous()
        {
            this.consultations = new HashSet<consultation>();
        }
    
        public long id_rdv { get; set; }
        public string date_rdv { get; set; }
        public string seance { get; set; }
        public long disponible { get; set; }
        public long traiter { get; set; }
        public long id_patient { get; set; }
        public long id_user { get; set; }
        public Nullable<long> payer { get; set; }
        public Nullable<long> terminer { get; set; }
    
        public virtual ICollection<consultation> consultations { get; set; }
        public virtual patient patient { get; set; }
        public virtual utilisteur utilisteur { get; set; }
    }
}
