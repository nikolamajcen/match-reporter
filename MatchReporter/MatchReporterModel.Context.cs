﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatchReporter
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MatchReporterEntities : DbContext
    {
        public MatchReporterEntities()
            : base("name=MatchReporterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClubOfficial> ClubOfficials { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Delegate> Delegates { get; set; }
        public virtual DbSet<GuestTeam> GuestTeams { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<HomeTeam> HomeTeams { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Manage> Manages { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Play> Plays { get; set; }
        public virtual DbSet<RefereePair> RefereePairs { get; set; }
        public virtual DbSet<Referee> Referees { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
