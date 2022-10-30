using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGuide.DAL.DbContexts;

namespace MyGuide.DAL
{
    public class DALModule
    {
        public static void Load(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(option =>
           option.UseSqlServer(configuration.GetConnectionString("DBConnection"))
           );
        }
    }
}
