using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerCity { get; set; } = string.Empty;
    }
}
