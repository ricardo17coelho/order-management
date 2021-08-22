using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IBillService : IService<Bill>
    {
        Bill GenerateBill(Order order);
        List<Bill> Search(string searchString);
    }
}
