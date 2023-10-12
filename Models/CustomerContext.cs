using System.Collections.Generic;

namespace UdemyProje1.Models
{
    public class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
            new Customer {Id=1,FirstName ="mert", LastName="arslan", Age=30 },
            new Customer {Id=2,FirstName ="adnan", LastName="arslan", Age=60 }
        };
    }
}
