using eTickets.Data;

namespace eTickets
{
    public class Startup
    {
        public void configureServices(IServiceCollection services) {
            
            // DbContext Config
            services.AddDbContext<AppDbContext>();
        }
    }
}
