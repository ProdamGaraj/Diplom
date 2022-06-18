using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class FormRepository : IFormRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Form entity)
        {
            throw new NotImplementedException();
        }

        public Form Get(int id)
        {
            //TODO: realize interface
            throw new NotImplementedException();
        }
        public FormRepository(ParkSharingDBContext dbContext):base()
        {
            _dbContext = dbContext;
        }
    }
}
