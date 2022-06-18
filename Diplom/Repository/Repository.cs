using Diplom.Entities;

namespace Diplom.Repository
{
    public abstract class Repository<TEntity> where TEntity : class
    {
        protected readonly ParkSharingDBContext DbContext;

        public Repository(ParkSharingDBContext dBContext)
        {
            DbContext = dBContext;
        }
        public virtual TEntity Get(int id)
        {
            return DbContext.Find<TEntity>(id);
        }

        public virtual void Add(TEntity entity)
        {
            DbContext.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            DbContext.Update(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            DbContext.Remove(entity);
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }
    }
}
