using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataVerse.Models
{
    public class CustomerViewModel
    {
       public List<Customer> Customers { get; set; }
       public Customer ActiveCustomer { get; set; }
    }
}