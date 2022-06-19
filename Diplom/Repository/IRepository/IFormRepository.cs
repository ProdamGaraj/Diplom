using Diplom.Entities;
using Diplom.Repository.CRUDInterfaces;

namespace Diplom.Repository.IRepository
{
    public interface IFormRepository : IAddable<Form>, IReadable<Form>, IGiveAll<Form>
    {

    }
}
