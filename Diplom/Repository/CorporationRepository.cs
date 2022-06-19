using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class CorporationRepository : ICorporationRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Corporation entity)
        {
            _dbContext.Corporations.Add(entity);
            _dbContext.SaveChanges();
        }

        public Corporation GetByName(string name)
        {
            return _dbContext.Corporations.Find(name);
        }
        public Corporation Get(int id)
        {
            return _dbContext.Corporations.Find(id);
        }

        public void Remove(Corporation entity)
        {
            var corpoUsers =_dbContext.Users.Where(x => x.Corporation == entity);
            foreach (var user in corpoUsers)
            {
                foreach (var car in user.Cars)
                {
                    _dbContext.Cars.Remove(car);
                }
                foreach (var form in user.Forms)
                {
                    _dbContext.Forms.Remove(form);
                }
            }    
            _dbContext.Users.RemoveRange(corpoUsers);
            _dbContext.Corporations.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Corporation entity)
        {
            _dbContext.Corporations.Update(entity);
        }

        public CorporationRepository(ParkSharingDBContext dBContext):base()
        {
            _dbContext = dBContext;
        }
    }
}
