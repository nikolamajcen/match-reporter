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
    
    public partial class Play
    {
        public int PlayId { get; set; }
        public string Number { get; set; }
        public string Goals { get; set; }
        public string Goals7m { get; set; }
        public string Warning { get; set; }
        public string SuspensionFirst { get; set; }
        public string SuspensionSecond { get; set; }
        public string SuspensionThird { get; set; }
        public string Disqualification { get; set; }
        public string DisqualificationAdnReport { get; set; }
        public int PlayerId { get; set; }
        public int MatchId { get; set; }
    
        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
