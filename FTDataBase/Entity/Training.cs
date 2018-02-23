using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Training : IEntity
    {
        [Key]
        public int Id { get; set; }        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ForeignKey("TrainingType")]
        public int TypeId { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        [ForeignKey("TrainingStatus")]
        public int StatusId { get; set; }
        [ForeignKey("Gym")]
        public int GymId { get; set; }

        public virtual Trainer Trainer { get; set; }
        public virtual TrainingType TrainingType { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual TrainingStatus TrainingStatus { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
