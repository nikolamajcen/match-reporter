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
    
    public partial class ClubOfficial
    {
        public ClubOfficial()
        {
            this.Manage = new HashSet<Manage>();
        }
    
        public int ClubOfficialId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClubId { get; set; }
    
        public virtual Club Club { get; set; }
        public virtual ICollection<Manage> Manage { get; set; }
    }
}
