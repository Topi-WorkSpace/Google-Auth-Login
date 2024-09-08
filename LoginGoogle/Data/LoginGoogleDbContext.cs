using LoginGoogle.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginGoogle.Data
{
    public class LoginGoogleDbContext:DbContext
    {
        public LoginGoogleDbContext(DbContextOptions<LoginGoogleDbContext> options):base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
