using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballClubWebApp.BusinessLayer
{
    public class Ranking
    {
        // Represent Rank ID
        public int Id { get; set; }

        // Represent Value of Team in Millions 
        public int ValueInMillions { get; set; }

        // Represent Operating Income by team in particular year
        public int OperatingIncome { get; set; }

        // Represent Team ID
        public int TeamID { get; set; }

        public TeamInfo TeamInfo { get; set; }

        // Represent Year ID
        public int YearID { get; set; }

        public YearInfo YearInfo { get; set; }
    }
}
