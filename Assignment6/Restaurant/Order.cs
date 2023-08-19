using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Restaurant
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public List<MenuItem> Items { get; set; }

        public float GetCheck()
        {
            float total = 0;
            foreach (MenuItem item in Items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
