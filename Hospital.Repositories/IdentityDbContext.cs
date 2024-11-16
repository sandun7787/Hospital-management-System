using Microsoft.EntityFrameworkCore;

namespace Hospital.Repositories
{
    public class IdentityDbContext
    {
        private DbContextOptions<ApplicationDbContext> options;

        public IdentityDbContext(DbContextOptions<ApplicationDbContext> options)
        {
            this.options = options;
        }
    }
}