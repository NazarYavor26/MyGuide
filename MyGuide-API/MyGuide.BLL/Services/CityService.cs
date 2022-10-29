using MyGuide.BLL.Models;
using MyGuide.DAL.DbContexts;
using MyGuide.DAL.Entities;

namespace MyGuide.BLL.Services
{
    public class CityService : ICityService
    {
        public readonly AppDbContext _db;

        public CityService(AppDbContext db)
        {
            _db = db;
        }
        public CityModel GetCityData()
        {
            var city =  _db.Cities.FirstOrDefault();

            return new CityModel() { Name = city.Name, Description = city.Description };
        }
    }
}
