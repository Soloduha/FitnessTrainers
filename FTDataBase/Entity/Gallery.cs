using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Gallery : IEntity
    {
        public Gallery()
        {
            Trainers = new HashSet<Trainer>();
            Gyms = new HashSet<Gym>();
            Photos = new HashSet<Photo>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Gym> Gyms { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
