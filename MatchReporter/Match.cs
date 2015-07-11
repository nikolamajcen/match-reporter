//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Match
    {
        public Match()
        {
            this.GuestTeam = new HashSet<GuestTeam>();
            this.HomeTeam = new HashSet<HomeTeam>();
            this.Manage = new HashSet<Manage>();
            this.Play = new HashSet<Play>();
        }
    
        public int MatchId { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public int Round { get; set; }
        public int Spectators { get; set; }
        public int RefereePairId { get; set; }
        public int LeagueId { get; set; }
        public int DelegateId { get; set; }
        public int HallId { get; set; }
        public string TimeKeeper { get; set; }
        public string Scorer { get; set; }
    
        public virtual Delegate Delegate { get; set; }
        public virtual ICollection<GuestTeam> GuestTeam { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual ICollection<HomeTeam> HomeTeam { get; set; }
        public virtual League League { get; set; }
        public virtual ICollection<Manage> Manage { get; set; }
        public virtual ICollection<Play> Play { get; set; }
        public virtual RefereePair RefereePair { get; set; }
    }
}
