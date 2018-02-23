using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Metric : CodeTable
    {
        public Metric()
        {
            ClientMetrics = new HashSet<ClientMetrics>();
        }

        public ICollection<ClientMetrics> ClientMetrics { get; set; }
    }
}
