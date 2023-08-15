using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.E_Commerce
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
