﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardBrowser.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DeckGeneralsEntities : DbContext
    {
        public DeckGeneralsEntities()
            : base("name=DeckGeneralsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CardAbilityTypes> CardAbilityTypes { get; set; }
        public virtual DbSet<CardRarities> CardRarities { get; set; }
        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<CardsAbilitiesValues> CardsAbilitiesValues { get; set; }
        public virtual DbSet<CardTypes> CardTypes { get; set; }
    }
}