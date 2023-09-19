using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1.Models
{
    public class LigaInglesa
    {
        public Match[] matches { get; set; }
    }
    public class Match
    {
        public string utcDate { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public Score score { get; set; }
    }

    public class Team
    {
        public string name { get; set; }
    }

    public class Score
    {
        public FullTime fullTime { get; set; }
    }

    public class FullTime
    {
        public int? home { get; set; }
        public int? away { get; set; }
    }
}
