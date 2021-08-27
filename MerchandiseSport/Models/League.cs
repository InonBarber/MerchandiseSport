using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchandiseSport.Models
{
    public class League
    {
        public int IdOfLeague  { get; set; }
        public string NameOfTheLeague { get; set; }
        public int NumberOfClubs { get; set; }
        public String LeagueIcon { get; set; }
    }
}
