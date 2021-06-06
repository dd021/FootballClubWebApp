using FootballClubWebApp.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballClubWebApp.Data
{
    public class FootballClubDBContext:DbContext
    {
        public FootballClubDBContext(DbContextOptions<FootballClubDBContext> options)
            : base(options)
        {
        }
        public DbSet<CountryInfo> CountryInfos { get; set; }
        public DbSet<TeamInfo> TeamInfos { get; set; }
        public DbSet<YearInfo> YearInfos { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
    }
}
