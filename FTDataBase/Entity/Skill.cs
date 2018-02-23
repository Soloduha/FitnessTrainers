using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTrainersDB.Entity
{
    public class Skill : CodeTable
    {
        public Skill()
        {
            TrainersSkills = new HashSet<TrainersSkills>();
        }

        public ICollection<TrainersSkills> TrainersSkills { get; set; }
    }
}
