using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchReporter
{
    class PlayerGame
    {
        public int PlayerGameId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ClubId { get; set; }

        public int MatchId { get; set; }

        public int Goals { get; set; }
        public int Goals7m { get; set; }

        public int Warning { get; set; }
        public int Suspension1st { get; set; }
        public int Suspension2nd { get; set; }
        public int Suspension3rd { get; set; }
        public int Disqualification { get; set; }
        public int DisqualificationReport { get; set; }
    }
}
