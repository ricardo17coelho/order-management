using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace order_management
{
    public abstract class Repository<Entity>
    {
        protected Context dbContext;

        public Repository()
        {
            this.dbContext = new Context();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public abstract void Add(Entity entity);

        public abstract void Remove(Entity entity);
        
        public abstract Entity FindById(int id);

        public abstract BindingList<Entity> GetBoundedList();

    }
}
