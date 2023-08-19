using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Restaurant
{
    public class Staff
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public List<Order> Tables { get; set; }
    }
}
