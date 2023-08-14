using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Vehicle
{
    public class Truck : Vehicle
    {
        public Truck(
            int towingCapacity,
            string model,
            string make,
            float weight,
            float price,
            int speed
        )
            : base(model, make, weight, price, speed)
        {
            this.TowingCapacity = towingCapacity;
        }

        public int TowingCapacity { get; set; }
    }
}
