using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Goal : CodeTable
    {
        public Goal()
        {
            Clients = new HashSet<Client>();
        }

        public ICollection<Client> Clients { get; set; }
    }
}
