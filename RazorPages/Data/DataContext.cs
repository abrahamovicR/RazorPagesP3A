using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;
using System.Reflection.Emit;
namespace RazorPages.Data
{
    public class DataContext : IdentityDbContext<RazorPagesUser>
    {

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            // 1. Vytvoření ID pro roli a uživatele (aby se na ně dalo odkazovat)
            string adminRoleId = Guid.NewGuid().ToString();
            string adminUserId = Guid.NewGuid().ToString();

            // 2. Seeding Role (přepis horní části tabule)
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            // 3. Hashování hesla (přepis spodní části tabule)
            var hasher = new PasswordHasher<RazorPagesUser>();
            string hashedHeslo = hasher.HashPassword(null, "TajneHeslo123");

            // 4. Seeding uživatele (pokud ho chceš rovnou vytvořit)
            modelBuilder.Entity<RazorPagesUser>().HasData(new RazorPagesUser
            {
                Id = adminUserId,
                UserName = "admin@admin.cz",
                NormalizedUserName = "ADMIN@ADMIN.CZ",
                Email = "admin@admin.cz",
                NormalizedEmail = "ADMIN@ADMIN.CZ",
                PasswordHash = hashedHeslo,
                EmailConfirmed = false
            });

            // 5. Propojení uživatele s rolí (vložení do tabulky AspNetUserRoles)
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            });
        }


        public DbSet<FormIEM> Submissions { get; set; }
    }
}
