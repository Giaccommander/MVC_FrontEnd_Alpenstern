﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class alpensternEntities : DbContext
    {
        public alpensternEntities()
            : base("name=alpensternEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anfrage> Anfrage { get; set; }
        public virtual DbSet<Ausstattung> Ausstattung { get; set; }
        public virtual DbSet<Bilder> Bilder { get; set; }
        public virtual DbSet<Gast> Gast { get; set; }
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Kategorieanfrage> Kategorieanfrage { get; set; }
        public virtual DbSet<Komplettpaket> Komplettpaket { get; set; }
        public virtual DbSet<Land> Land { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public virtual DbSet<Rechnung> Rechnung { get; set; }
        public virtual DbSet<Rueckruf> Rueckruf { get; set; }
        public virtual DbSet<Saison> Saison { get; set; }
        public virtual DbSet<Stadt> Stadt { get; set; }
        public virtual DbSet<Zimmer> Zimmer { get; set; }
        public virtual DbSet<Zimmerbuchung> Zimmerbuchung { get; set; }
        public virtual DbSet<Gastlogin> Gastlogin { get; set; }
        public virtual DbSet<Kategorieausstattung> Kategorieausstattung { get; set; }
        public virtual DbSet<Komplettbuchung> Komplettbuchung { get; set; }
        public virtual DbSet<get_carousel_imgs> get_carousel_imgs { get; set; }
    }
}
