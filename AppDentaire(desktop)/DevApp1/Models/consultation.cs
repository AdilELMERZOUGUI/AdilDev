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
    
    public partial class consultation
    {
        public long id_conslt { get; set; }
        public string details { get; set; }
        public long id_user { get; set; }
        public Nullable<long> id_rdv { get; set; }
        public long id_acte { get; set; }
        public long id_pay { get; set; }
    
        public virtual acte acte { get; set; }
        public virtual payement payement { get; set; }
        public virtual rendez_vous rendez_vous { get; set; }
        public virtual utilisteur utilisteur { get; set; }
    }
}
