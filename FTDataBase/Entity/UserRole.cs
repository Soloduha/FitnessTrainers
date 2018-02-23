using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class UserRole : CodeTable
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public ICollection<User> Users { get; set; }

    }
}
