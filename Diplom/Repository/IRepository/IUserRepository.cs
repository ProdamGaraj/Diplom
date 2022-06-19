using Diplom.Entities;
using Diplom.Repository.CRUDInterfaces;

namespace Diplom.Repository.IRepository
{
    public interface IUserRepository : IAddable<User>, IRemovable<User>, IReadable<User>, IUpdatable<User>, IGiveAll<User>
    {
    }
}
