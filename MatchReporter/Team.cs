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
    
    public partial class Team
    {
        public Team()
        {

        }
        public Team(int matchId, int clubId)
        {
            this.MatchId = matchId;
            this.ClubId = clubId;
            this.Goals = 0;
            this.Goals7m = 0;
            this.Attempts7m = 0;
        }

        public short Goals { get; set; }
        public string TTO1 { get; set; }
        public string TTO2 { get; set; }
        public string TTO3 { get; set; }
        public string JerseyColor { get; set; }
        public int ClubId { get; set; }
        public int MatchId { get; set; }
        public Nullable<int> Goals7m { get; set; }
        public Nullable<int> Attempts7m { get; set; }
    
        public virtual Club Club { get; set; }
        public virtual Match Match { get; set; }
    }
}
