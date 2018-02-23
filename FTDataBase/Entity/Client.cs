using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    [Table("Clients")]
    public class Client : User
    {
        public Client()
        {
            Schedules = new HashSet<Schedule>();
            ClientMetrics = new HashSet<ClientMetrics>();
        }

        [ForeignKey("Goal")]
        public int GoalId { get; set; }
        
        public virtual Goal Goal { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<ClientMetrics> ClientMetrics { get; set; }
    }
}
