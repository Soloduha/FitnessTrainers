using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Zone : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [ForeignKey("ZoneType")]
        public int ZoneTypeId { get; set; }
        [ForeignKey("Gym")]
        public int GymId { get; set; }

        public virtual ZoneType ZoneType { get; set; }
        public virtual Gym Gym { get; set; }

    }
}
