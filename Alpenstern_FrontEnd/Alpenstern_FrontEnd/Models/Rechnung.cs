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
    
    public partial class Rechnung
    {
        public int id { get; set; }
        public int anfrage_id { get; set; }
        public decimal gesamtpreis { get; set; }
        public byte anzahlPersonen { get; set; }
        public byte anzahlNaechte { get; set; }
        public System.DateTime datumAktualisiert { get; set; }
    
        public virtual Anfrage Anfrage { get; set; }
    }
}
