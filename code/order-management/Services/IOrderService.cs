using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IOrderService : IService<Order>
    {
        Boolean IsUnique(Order entity);
        Boolean IsValid(Order entity);
        List<Order> Search(string searchString);
    }
}
