﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchReporter.Classes
{
    public class TeamPlayer
    {
        public TeamPlayer(int playerId, string firstName, string lastName, int? number)
        {
            this.TeamPlayerId = playerId;
            this.Name = firstName.First<char>() + ". " + lastName;
            this.Number = number;
            this.Goals = 0;
            this.Goals7m = 0;
            this.Warning = null;
            this.Suspension1st = null;
            this.Suspension2nd = null;
            this.Suspension3rd = null;
            this.Disqualification = null;
            this.DisqualificationReport = null;
        }

        public int TeamPlayerId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public int Goals { get; set; }
        public int Goals7m { get; set; }
        public int? Warning { get; set; }
        public int? Suspension1st { get; set; }
        public int? Suspension2nd { get; set; }
        public int? Suspension3rd { get; set; }
        public int? Disqualification { get; set; }
        public int? DisqualificationReport { get; set; }
    }
}
