using System;
using System.Collections.Generic;
using System.Text;

namespace order_management.Services
{
    public interface IYoyComparisonService : IService<YoyComparison>
    {
        List<YoyComparison> GetYoyComparison();

    }
}
