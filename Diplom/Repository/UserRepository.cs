using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(User entity)
        {
            _dbContext.Users.Add(entity);
            _dbContext.SaveChanges();
        }

        public ICollection<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User Get(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public void Remove(User entity)
        {
            foreach (var car in entity.Cars)
            {
                _dbContext.Cars.Remove(car);
            }
            foreach (var form in entity.Forms)
            {
                _dbContext.Forms.Remove(form);
            }
            _dbContext.Users.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public UserRepository(ParkSharingDBContext dBContext) : base()
        {
            _dbContext = dBContext;
        }
    }
}
