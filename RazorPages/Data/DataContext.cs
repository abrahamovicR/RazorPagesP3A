using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;
namespace RazorPages.Data
{
    public class DataContext : IdentityDbContext<RazorPagesUser>
    {

        public DataContext(DbContextOptions<RazorPagesContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<FormIEM> Submissions { get; set; }
    }
}
