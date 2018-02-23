using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Gym : IEntity
    {
        public Gym()
        {
            Trainings = new HashSet<Training>();
            Zones = new HashSet<Zone>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(100)]
        public string WorkSchedule { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        [ForeignKey("Contact")]
        public int? ContactId { get; set; }
        [ForeignKey("Gallery")]
        public int? GalleryId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Gallery Gallery { get; set; }

        public ICollection<Training> Trainings { get; set; }
        public ICollection<Zone> Zones { get; set; }
    }
}
