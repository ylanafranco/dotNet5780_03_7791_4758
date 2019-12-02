using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_7791_4758
{
    public class HostingUnit
    {
        public string UnitName { get; set; }
        public bool isSwimmingPool { get; set; }
        public int Rooms { get; set; }
        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }

        public HostingUnit()
        {
            AllOrders = new List<DateTime>();
            Uris = new List<string>();
        }

    }
}
