using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; } = string.Empty;

        // Bire çok ilişki: Bir iş birden fazla müşteriye sahip olabilir
        public List<Customer> Customers { get; set; } = new();
    }
}
