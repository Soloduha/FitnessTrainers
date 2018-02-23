using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Photo : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string PhotoUrl { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [ForeignKey("Gallery")]
        public int GaleryId { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}
