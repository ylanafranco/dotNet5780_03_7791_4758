using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_7791_4758
{
    public class Host
    {
        public string HostName { get; set; }
        public List<HostingUnit> Units { get; set; }

        public Host()
        {
            Units = new List<HostingUnit>();
        }
    }
}
