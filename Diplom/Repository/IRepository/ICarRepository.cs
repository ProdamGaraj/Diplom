using Diplom.Entities;
using Diplom.Repository.CRUDInterfaces;

namespace Diplom.Repository.IRepository
{
    public interface ICarRepository : IAddable<Car>, IGiveAll<Car>, IReadable<Car>, IRemovable<Car>, IUpdatable<Car>
    {

    }
}
