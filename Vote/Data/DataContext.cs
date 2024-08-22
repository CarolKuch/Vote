using Microsoft.EntityFrameworkCore;
using Vote.Entities;

namespace Vote.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Voter> Voters { get; set; }
    }
}
