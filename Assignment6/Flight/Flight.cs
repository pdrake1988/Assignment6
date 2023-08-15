using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Flight
{
    public class Flight
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public bool Delayed { get; set; }
        public List<Passenger> Passengers { get; set; }
    }
}
