using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    [Table("Trainers")]
    public class Trainer : User
    {
        public Trainer()
        {
            Trainings = new HashSet<Training>();
            TrainersSkills = new HashSet<TrainersSkills>();
        }

        [StringLength(500)]
        public string Overview { get; set; }
        [ForeignKey("Gallery")]
        public int? GalleryId { get; set; }

        public virtual Gallery Gallery { get; set; }

        public ICollection<Training> Trainings { get; set; }
        public ICollection<TrainersSkills> TrainersSkills { get; set; }
    }
}
