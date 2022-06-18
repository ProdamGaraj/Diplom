using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class UserRepository : AuditableRepository<User> ,IUserRepository
    {
        private readonly ParkSharingDBContext _dbContext;


        public UserRepository(ParkSharingDBContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
