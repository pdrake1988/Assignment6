using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Vehicle
{
    public class Car : Vehicle
    {
        public Car(
            int doors,
            int horsePower,
            string make,
            string model,
            float weight,
            float price,
            int speed
        )
            : base(make, model, weight, price, speed)
        {
            this.Doors = doors;
            this.HorsePower = horsePower;
            this.Make = make;
            this.Model = model;
            this.Weight = weight;
            this.Price = price;
            this.Speed = speed;
        }

        public int Doors { get; set; }
        public int HorsePower { get; set; }
    }
}
