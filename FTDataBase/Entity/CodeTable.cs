using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public abstract class CodeTable : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
