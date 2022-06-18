using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Repository.CRUDInterfaces
{
    public interface IUpdatable<TEntity> where TEntity : class
    {
        void Update(TEntity entity);
    }
}