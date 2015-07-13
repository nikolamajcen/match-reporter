using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchReporter.Classes
{
    public class TeamOfficial
    {
        public TeamOfficial(int officialId, string firstName, string lastName)
        {
            this.TeamOfficialId = officialId;
            this.Name = firstName.First<char>() + ". " + lastName;
            this.Warning = 0;
            this.Suspension = 0;
            this.Disqualification = 0;
        }

        public int TeamOfficialId { get; set; }
        public string Name { get; set; }
        public int Warning { get; set; }
        public int Suspension { get; set; }
        public int Disqualification { get; set; }
    }
}
