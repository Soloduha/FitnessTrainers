using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Schedule : IEntity
    {
        public Schedule()
        {
            Trainings = new HashSet<Training>();
        }

        [Key]
        public int Id { get; set; }
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public virtual Client Client { get; set; }
        public ICollection<Training> Trainings { get; set; }
    }
}
