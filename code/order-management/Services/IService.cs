using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void DeleteById(int id);
        void Delete(T entity);
        void Update(T entity);
    }
}
