using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class TrainingStatus : CodeTable
    {
        public TrainingStatus()
        {
            Trainings = new HashSet<Training>();
        }

        public ICollection<Training> Trainings { get; set; }
    }
}
