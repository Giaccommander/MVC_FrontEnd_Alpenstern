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
    
    public partial class Spiel
    {
        public int id { get; set; }
        public int login_id { get; set; }
    
        public virtual Login Login { get; set; }
    }
}
