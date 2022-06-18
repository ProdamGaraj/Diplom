using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class FormRepository : AuditableRepository<Form>, IFormRepository
    {
        private readonly ParkSharingDBContext _dbContext;

        public FormRepository(ParkSharingDBContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
