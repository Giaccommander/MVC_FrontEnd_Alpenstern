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
    
    public partial class Kategorieausstattung
    {
        public int id { get; set; }
        public int ausstattung_id { get; set; }
        public int kategorie_id { get; set; }
        public byte anzahl { get; set; }
    
        public virtual Ausstattung Ausstattung { get; set; }
        public virtual Kategorie Kategorie { get; set; }
    }
}
