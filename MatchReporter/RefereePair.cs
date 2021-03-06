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
            this.Match = new HashSet<Match>();
        }
    
        public int RefereePairId { get; set; }
        public int FirstRefereeId { get; set; }
        public int SecondRefereeId { get; set; }
        public string RefereePairName
        {
            get
            {
                string firstRefereeName;
                string secondRefereeName;

                firstRefereeName = this.Referee.FirstName.ToString() + " " + this.Referee.LastName.ToString();
                secondRefereeName = this.Referee1.FirstName.ToString() + " " + this.Referee1.LastName.ToString();

                return firstRefereeName + " - " + secondRefereeName;
            }
            set { }
        }

        public virtual ICollection<Match> Match { get; set; }
        public virtual Referee Referee { get; set; }
        public virtual Referee Referee1 { get; set; }
    }
}
