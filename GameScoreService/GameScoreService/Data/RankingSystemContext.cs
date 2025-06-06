using Microsoft.EntityFrameworkCore;

namespace GameScoreService.Data
{
    public class RankingSystemContext : DbContext
    {
        public RankingSystemContext(DbContextOptions<RankingSystemContext> options) 
            : base(options)
        {

        }

        public DbSet<SimpleScoreReport> SimpleScoreReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
