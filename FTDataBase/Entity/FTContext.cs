using FitnessTrainersDB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FitnessTrainersDB
{
    public class FTContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }        
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Schedule> Schedules { get; set; }        
        public DbSet<TrainersSkills> TrainersSkills { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<TrainingStatus> TrainingStatuses { get; set; }
        public DbSet<TrainingType> TrainingTypes { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ZoneType> ZoneTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = ADMIN-PC; Initial Catalog = FitnessTrainersDB; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {            
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
        
    }
}
