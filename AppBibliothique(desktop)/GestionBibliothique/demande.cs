//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionBibliothique
{
    using System;
    using System.Collections.Generic;
    
    public partial class demande
    {
        public int id_eleve { get; set; }
        public int id_livre { get; set; }
        public Nullable<System.DateTime> date_prise { get; set; }
        public Nullable<System.DateTime> date_retour { get; set; }
        public Nullable<bool> valide_Retour { get; set; }
    
        public virtual eleve eleve { get; set; }
        public virtual livre livre { get; set; }
    }
}
