using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyGuide.DAL;

namespace MyGuide.BLL
{
    public class BLLModule
    {
        public static void Load(IServiceCollection services, IConfiguration configaration)
        {
            DALModule.Load(services, configaration);
        }
    }
}
