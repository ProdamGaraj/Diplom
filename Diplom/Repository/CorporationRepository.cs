using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class CorporationRepository : AuditableRepository<Corporation>, ICorporationRepository
    {
        private readonly ParkSharingDBContext _dbContext;


        public CorporationRepository(ParkSharingDBContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}