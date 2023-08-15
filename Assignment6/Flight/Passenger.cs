using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Flight
{
    public class Passenger
    {
        public string Name { get; set; }
        public Flight Flight { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int SeatNumber { get; set; }
    }
}
