using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class TrainersSkills : IEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }

        public virtual Trainer Trainer { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
