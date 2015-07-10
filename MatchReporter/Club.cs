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
    
    public partial class Club
    {
        public Club()
        {
            this.ClubOfficial = new HashSet<ClubOfficial>();
            this.Player = new HashSet<Player>();
            this.HomeTeam = new HashSet<HomeTeam>();
            this.GuestTeam = new HashSet<GuestTeam>();
        }
    
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string JerseyColorHome { get; set; }
        public string JerseyColorGuest { get; set; }
        public int CityId { get; set; }
    
        public virtual City City { get; set; }
        public virtual ICollection<ClubOfficial> ClubOfficial { get; set; }
        public virtual ICollection<Player> Player { get; set; }
        public virtual ICollection<HomeTeam> HomeTeam { get; set; }
        public virtual ICollection<GuestTeam> GuestTeam { get; set; }
    }
}
