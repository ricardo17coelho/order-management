using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public interface IRepoBase<T>
    {
        IEnumerable<T> GetAll();
        
        T GetById(object id);
        
        T Add(T obj);
        
        T Update(T obj);
        
        void Delete(object id);
    }
}
