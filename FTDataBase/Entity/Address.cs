using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Address : IEntity
    {
        public Address()
        {
            Users = new HashSet<User>();
            Gyms = new HashSet<Gym>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string StreetName { get; set; }
        [Required]
        [StringLength(10)]
        public string HouseNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        
        public ICollection<User> Users { get; set; }
        public ICollection<Gym> Gyms { get; set; }
    }
}
