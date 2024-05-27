using GestionConference.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionConference.AppContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        DbSet<User> Users { get; set; }
    }
}
