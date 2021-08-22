using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace order_management
{
    public class RepoBase<T> : IRepoBase<T> where T : class
    {
        protected readonly OrderManagementDbContext _orderManagementDbContext;

        public RepoBase(OrderManagementDbContext orderManagementDbContext)
        {
            _orderManagementDbContext = orderManagementDbContext;
        }

        public IEnumerable<T> GetAll()
        {
            _orderManagementDbContext.Database.EnsureCreated();
            var table = _orderManagementDbContext.Set<T>();
            return table.ToList();
        }

        public T GetById(object id)
        {
            var table = _orderManagementDbContext.Set<T>();
            return table.Find(id);
        }
        
        public T Add(T obj)
        {

            var table = _orderManagementDbContext.Set<T>();
            var attach = table.Attach(obj);
            _orderManagementDbContext.SaveChanges();
            return attach.Entity;
        }
        
        public T Update(T obj)
        {
            var table = _orderManagementDbContext.Set<T>();
            var attach = table.Attach(obj);
            _orderManagementDbContext.Entry(obj).State = EntityState.Modified;
            _orderManagementDbContext.SaveChanges();
            return attach.Entity;
        }
        
        public void Delete(object id)
        {
            Delete(GetById(id));
        }

        public void Delete(T entity)
        {
            _orderManagementDbContext.Remove(entity);
            _orderManagementDbContext.SaveChanges();
        }
    }
}
