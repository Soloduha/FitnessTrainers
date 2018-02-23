using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class ZoneType : CodeTable
    {
        public ZoneType()
        {
            Zones = new HashSet<Zone>();
        }

        public ICollection<Zone> Zones { get; set; }
    }
}
