using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) 
        {
            
        }
    }
}
