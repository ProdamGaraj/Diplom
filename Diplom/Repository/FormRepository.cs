using Diplom.Entities;
using Diplom.Repository.IRepository;

namespace Diplom.Repository
{
    public class FormRepository : IFormRepository
    {
        private readonly ParkSharingDBContext _dbContext;
        public void Add(Form entity)
        {
            _dbContext.Forms.Add(entity);
            _dbContext.SaveChanges();
        }

        public ICollection<Form> GetAll()
        {
            return _dbContext.Forms.ToList();
        }

        public Form Get(int id)
        {
            return _dbContext.Forms.Find(id);
        }
        public FormRepository(ParkSharingDBContext dbContext) : base()
        {
            _dbContext = dbContext;
        }
    }
}
