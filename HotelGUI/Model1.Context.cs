﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelGUI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class M120Entities : DbContext
    {
        public M120Entities()
            : base("name=M120Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GUIUSER> GUIUSERs { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelBild> HotelBilds { get; set; }
        public virtual DbSet<Kunde> Kundes { get; set; }
        public virtual DbSet<Kunde_Reise> Kunde_Reise { get; set; }
        public virtual DbSet<Land> Lands { get; set; }
        public virtual DbSet<Reise> Reises { get; set; }
        public virtual DbSet<Reise_Hotel> Reise_Hotel { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
