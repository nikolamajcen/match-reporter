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
    
    public partial class RefereePair
    {
        public RefereePair()
        {
            this.Matches = new HashSet<Match>();
        }
    
        public int RefereePairId { get; set; }
        public int FirstRefereeId { get; set; }
        public int SecondRefereeId { get; set; }
    
        public virtual ICollection<Match> Matches { get; set; }
        public virtual Referee Referees { get; set; }
        public virtual Referee Referees1 { get; set; }
    }
}
