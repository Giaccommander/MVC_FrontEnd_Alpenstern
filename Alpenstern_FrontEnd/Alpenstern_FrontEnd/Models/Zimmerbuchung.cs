//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alpenstern_FrontEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zimmerbuchung
    {
        public int id { get; set; }
        public int zimmer_id { get; set; }
        public int mitarbeiter_id { get; set; }
        public int kategorieanfrage_id { get; set; }
        public Nullable<bool> checkedStatus { get; set; }
    
        public virtual Kategorieanfrage Kategorieanfrage { get; set; }
        public virtual Mitarbeiter Mitarbeiter { get; set; }
        public virtual Zimmer Zimmer { get; set; }
    }
}
