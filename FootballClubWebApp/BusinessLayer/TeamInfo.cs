using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballClubWebApp.BusinessLayer
{
    public class TeamInfo
    {
        // Represent Team ID
        public int Id { get; set; }

        // Represent Team Name
        public string TeamName { get; set; }

        // Represent Country ID
        public int CountryID { get; set;  }

        public CountryInfo CountryInfo { get; set; }
    }
}
