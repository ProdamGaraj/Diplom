using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Repository.CRUDInterfaces
{
    public interface IAddable<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
    }
}