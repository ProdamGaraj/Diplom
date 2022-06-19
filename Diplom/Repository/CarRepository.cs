using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Car entity)
        {
            _dbContext.Cars.Add(entity);
            _dbContext.SaveChanges();
        }

        public Car Get(int id)
        {
            return _dbContext.Cars.Find(id);
        }

        public ICollection<Car> GetAll()
        {
            return _dbContext.Cars.ToList();
        }

        public void Remove(Car entity)
        {
            _dbContext.Cars.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public CarRepository(ParkSharingDBContext dBContext):base()
        {
            _dbContext = dBContext;
        }
    }
}
