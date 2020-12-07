using System;
using System.Collections.Generic;
using System.Text;

namespace order_management
{
    public class RepositoryManager
    {

        public CustomerRepository CustomerRepository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public ProductCategoryRepository ProductCategoryRepository { get; set; }

        public RepositoryManager()
        {
            CustomerRepository = new CustomerRepository();
            ProductRepository = new ProductRepository();
            ProductCategoryRepository = new ProductCategoryRepository();
        }
    }
}
