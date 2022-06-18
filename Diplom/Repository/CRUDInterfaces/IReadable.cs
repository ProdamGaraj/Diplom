using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Repository.CRUDInterfaces
{
    public interface IReadable<TEntity> where TEntity : class
    {
        TEntity Get(int id);
    }
}