using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class TrainingType : CodeTable
    {
        public TrainingType()
        {
            Trainings = new HashSet<Training>();
        }

        public ICollection<Training> Trainings { get; set; }
    }
}
