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
    
    public partial class payement
    {
        public payement()
        {
            this.consultations = new HashSet<consultation>();
        }
    
        public long id_pay { get; set; }
        public Nullable<double> avance { get; set; }
        public Nullable<double> montant { get; set; }
    
        public virtual ICollection<consultation> consultations { get; set; }
    }
}
