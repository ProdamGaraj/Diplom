using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class CorporationRepository : ICorporationRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Corporation entity)
        {
            throw new NotImplementedException();
        }

        public Corporation Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Corporation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Corporation entity)
        {
            throw new NotImplementedException();
        }

        public CorporationRepository(ParkSharingDBContext dBContext):base()
        {
            _dbContext = dBContext;
        }
    }
}
