using FTDataBase.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Contact : IEntity
    {
        public Contact()
        {
            Users = new HashSet<User>();
            Gyms = new HashSet<Gym>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(13)]
        public string PhoneNumber { get; set; }
        [StringLength(100)]
        public string FacebookUrl { get; set; }
        [StringLength(100)]
        public string InstagramUrl { get; set; }
        
        public ICollection<User> Users { get; set; }
        public ICollection<Gym> Gyms { get; set; }
    }
}
