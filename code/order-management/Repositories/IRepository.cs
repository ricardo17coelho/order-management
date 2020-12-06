using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace order_management
{
    public interface IRepository<Entity>
    {
        public void Add(Entity entity);

        public void Remove(Entity entity);

        public BindingList<Entity> GetBoundedList();

        public void Save();


    }
}
