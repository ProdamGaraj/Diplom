using System.Linq;
using Diplom.Entities;
using Diplom.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Repository
{
    public class CarRepository : AuditableRepository<Car> ,ICarRepository
    {
        private readonly ParkSharingDBContext _dbContext;

        public CarRepository(ParkSharingDBContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Car> GetAll()
        {
            return (IList<Car>)_dbContext.Users.ToList();//???? явного приведения быть не должно.
        }
    }
}
