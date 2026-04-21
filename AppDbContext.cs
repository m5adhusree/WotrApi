using Microsoft.EntityFrameworkCore;
using WotrApi.Models;

namespace WotrApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ActivityBeneficiary> ActivityBeneficiaries { get; set; }
    }
}