using EternaAgain.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaAgain.DAL
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options): base(options)
        {
            
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
