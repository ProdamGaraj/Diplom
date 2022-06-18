using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Repository.CRUDInterfaces
{
    public interface IGiveAll<TEntity> where TEntity : class
    {
        IList<TEntity> GetAll();
    }
}