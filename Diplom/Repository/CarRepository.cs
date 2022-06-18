using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Car entity)
        {
            throw new NotImplementedException();
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
