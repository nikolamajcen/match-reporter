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
    
    public partial class City
    {
        public City()
        {
            this.Referee = new HashSet<Referee>();
            this.Delegate = new HashSet<Delegate>();
            this.Hall = new HashSet<Hall>();
            this.Club = new HashSet<Club>();
        }
    
        public int CityId { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    
        public virtual ICollection<Referee> Referee { get; set; }
        public virtual ICollection<Delegate> Delegate { get; set; }
        public virtual ICollection<Hall> Hall { get; set; }
        public virtual ICollection<Club> Club { get; set; }
    }
}
