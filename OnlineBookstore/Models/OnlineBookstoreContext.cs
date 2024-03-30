using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace OnlineBookstore.Models
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
