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
    
    public partial class League
    {
        public League()
        {
            this.Match = new HashSet<Match>();
        }
    
        public int LeagueId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
    
        public virtual ICollection<Match> Match { get; set; }
    }
}
