using FitnessTrainersDB;
using FitnessTrainersDB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FTDataBase.Helpers
{
    public class CodeTablesDefaults
    {
        public static void FillAll()
        {
            FillGoals();
            FillMetrics();
            FillSkills();
            FillTrainingStatus();
            FillTrainingType();
            FillUserRoles();
            FillZoneTypes();
        }
        
        static void FillGoals()
        {
            using (FTContext context = new FTContext())
            {
                List<Goal> listOfGoals = new List<Goal>
                {
                    new Goal{Code = "Зменшення ваги", Description = "Програма для зменшення ваги тіла"},
                    new Goal{Code = "Збільшення ваги", Description = "Програма для збільшення ваги тіла"},
                    new Goal{Code = "Тонус", Description = "Підвищення загального тонусу м'язів"},
                    new Goal{Code = "Гнучкість", Description = "Покрщення гнучкості тіла"},
                    new Goal{Code = "Збільшення сили м'язів", Description = "Програма для збільшення сили м'язів"},
                    new Goal{Code = "Аеробіка", Description = "Комплексна програма аеробних вправ"},
                    new Goal{Code = "Покращення витривалості", Description = "Програма для покращення витривалості тіла"},
                    new Goal{Code = "Бодібілдинг", Description = "Комплексна програма для бодібілдингу"}                    
                };
                
                context.Goals.AddRange(listOfGoals);
                context.SaveChanges();
            }            
        }

        static void FillMetrics()
        {
            using (FTContext context = new FTContext())
            {
                List<Metric> listOfMetrics = new List<Metric>
                {
                    new Metric{Code = "Стать", Description = ""},
                    new Metric{Code = "Зріст", Description = "Зріст у сантиметрах"},
                    new Metric{Code = "Вага", Description = "Вага у кілограмах"}
                };

                context.Metrics.AddRange(listOfMetrics);
                context.SaveChanges();
            }
        }

        static void FillSkills()
        {
            using (FTContext context = new FTContext())
            {
                List<Skill> listOfSkills = new List<Skill>
                {
                    new Skill{Code = "Кардіотренування", Description = ""},
                    new Skill{Code = "Бодібілдинг", Description = ""},
                    new Skill{Code = "Збільшення витривалості", Description = ""},
                    new Skill{Code = "М'язова сила", Description = ""},
                    new Skill{Code = "Зменшення ваги", Description = ""},
                    new Skill{Code = "TRX", Description = ""},
                    new Skill{Code = "Спортивний табір", Description = ""},
                    new Skill{Code = "Йога", Description = ""},
                    new Skill{Code = "Бокс", Description = ""},
                    new Skill{Code = "Боротьба", Description = ""},
                    new Skill{Code = "Плавання", Description = ""},
                };

                context.Skills.AddRange(listOfSkills);
                context.SaveChanges();
            }
        }

        static void FillTrainingStatus()
        {
            using (FTContext context = new FTContext())
            {
                List<TrainingStatus> listOfStatuses = new List<TrainingStatus>
                {
                    new TrainingStatus{Code = "Заплановно", Description = ""},
                    new TrainingStatus{Code = "Виконано", Description = ""},
                    new TrainingStatus{Code = "Відмінено", Description = ""},
                    new TrainingStatus{Code = "Перенесено", Description = ""},
                };

                context.TrainingStatuses.AddRange(listOfStatuses);
                context.SaveChanges();
            }
        }

        static void FillTrainingType()
        {
            using (FTContext context = new FTContext())
            {
                List<TrainingType> listOfTrTypes = new List<TrainingType>
                {
                    new TrainingType{Code = "Аеробні вправи", Description = ""},
                    new TrainingType{Code = "Силові вправи", Description = ""},
                    new TrainingType{Code = "Группове заняття", Description = ""},
                    new TrainingType{Code = "Спортивний майданчик", Description = ""},
                    new TrainingType{Code = "Спаринг", Description = ""},
                    new TrainingType{Code = "Плавання", Description = ""},
                    new TrainingType{Code = "Спортивний табір", Description = ""},
                };

                context.TrainingTypes.AddRange(listOfTrTypes);
                context.SaveChanges();
            }
        }

        static void FillUserRoles()
        {
            using (FTContext context = new FTContext())
            {
                List<UserRole> listOfRoles = new List<UserRole>
                {
                    new UserRole{Code = "Тренер", Description = ""},
                    new UserRole{Code = "Клієнт", Description = ""},
                };
                context.UserRoles.AddRange(listOfRoles);
                context.SaveChanges();
            }
        }

        static void FillZoneTypes()
        {
            using (FTContext context = new FTContext())
            {
                List<ZoneType> listOfZoneTypes = new List<ZoneType>
                {
                    new ZoneType{Code = "Тренажерний зал", Description = ""},
                    new ZoneType{Code = "Аеробний зал", Description = ""},
                    new ZoneType{Code = "Зал для групових занять", Description = ""},
                    new ZoneType{Code = "Ринг", Description = ""},
                    new ZoneType{Code = "Басейн", Description = ""},
                    new ZoneType{Code = "Спортивний майданчик", Description = ""},
                    new ZoneType{Code = "Стадіон", Description = ""},
                };
                context.ZoneTypes.AddRange(listOfZoneTypes);
                context.SaveChanges();
            }
        }
    }
}
