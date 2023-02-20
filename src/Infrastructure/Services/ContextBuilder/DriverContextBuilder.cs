using System.Linq;
using ApplicationCore.Entities.AppEntities;
using ApplicationCore.Interfaces.ContextInterfaces;
using Infrastructure.AppData.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.ContextBuilder
{
    public class DriverContextBuilder : IDriverContextBuilder
    {
        private IQueryable<Driver> _drivers;
        private readonly AppDbContext _db;
        public DriverContextBuilder(AppDbContext db)
        {
            _db = db;
            _drivers = _db.Drivers;
        }
   
        public IDriverContextBuilder CarBuilder()
        {
            _drivers = _drivers.Include(d => d.Car);
            return this;
        }

        public IQueryable<Driver> Build()
        {
            var drivers = _drivers;
            _drivers = _db.Drivers;
            return drivers;
        }
    }
}