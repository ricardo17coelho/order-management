using System;
using System.Collections.Generic;

namespace order_management.Services
{
    public interface IOrderDetailService : IService<OrderDetail>
    {
        List<OrderDetail> GetByOrder(Order order);
        Boolean IsValid(OrderDetail entity);
    }
}
