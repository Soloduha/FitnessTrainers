using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class ClientMetrics : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [ForeignKey("Metric")]
        public int MetricId { get; set; }
        public string Value { get; set; }

        public virtual Client Client { get; set; }
        public virtual Metric Metric { get; set; }
    }
}
