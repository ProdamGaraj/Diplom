using Diplom.Entities;
using Diplom.Repository.CRUDInterfaces;

namespace Diplom.Repository.IRepository
{
    public interface ICorporationRepository : IAddable<Corporation>, IRemovable<Corporation>, IUpdatable<Corporation>, IReadable<Corporation>
    {
        Corporation GetByName(string name);
    }
}
