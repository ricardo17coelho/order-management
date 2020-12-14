using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class DbService
    {
        public static void SaveChanges(Context context)
        {
            context.SaveChanges();
        }
    }
}
