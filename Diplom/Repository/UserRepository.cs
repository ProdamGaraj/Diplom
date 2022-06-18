using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public UserRepository(ParkSharingDBContext dBContext):base()
        {
            _dbContext = dBContext;
        }
    }
}
