using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public abstract class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(12)]
        public string Password { get; set; }
        [StringLength(200)]
        public string PhotoUrl { get; set; }
        [ForeignKey("Address")]
        public int? AddressId { get; set; }
        [ForeignKey("Contact")]
        public int? ContactId { get; set; }
        [ForeignKey("UserRole")]
        public int UserRoleId { get; set; }

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
