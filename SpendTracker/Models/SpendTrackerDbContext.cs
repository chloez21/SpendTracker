using Microsoft.EntityFrameworkCore;

namespace SpendTracker.Models
{
    public class SpendTrackerDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendTrackerDbContext(DbContextOptions<SpendTrackerDbContext> options)
            : base(options)
        {
        
        }
    }
}
