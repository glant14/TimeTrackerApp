namespace TimeTrackerApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using TimeTrackerApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeTrackerApp.Models.TimeTrackerDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeTrackerApp.Models.TimeTrackerDBContext context)
        {
            //Only do this on test data
            //NEVER DROP ACTUAL PRODUCTION DATA
            context.Employees.RemoveRange(context.Employees);
            context.TimeCards.RemoveRange(context.TimeCards);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            List<Employee> employees = new List <Employee>();

            employees.Add(new Employee()
            {
                FirstName = "Michael",
                LastName = "Lishaa",
                Department = "IT",
                Role = "Manager",
                HireDate = DateTime.Now.AddYears(-2),
                DateOfBirth = DateTime.Now.AddYears(-20),
                Salary=15000,
                TimeCards = new List<TimeCard>()
                {
                    new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 8, TuesdayHours = 7, WednesdayHours = 6,
                        ThursdayHours = 8, FridayHours = 5, SaturdayHours = 0, SundayHours = 0 
                    },
                     new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 0, TuesdayHours = 7, WednesdayHours = 7,
                        ThursdayHours = 8, FridayHours = 7, SaturdayHours = 0, SundayHours = 0
                    }
                }
            });

            employees.Add(new Employee()
            {
                FirstName = "Berri",
                LastName = "Allen",
                Department = "CSI LAb",
                Role = "Manager",
                HireDate = DateTime.Now.AddYears(-2),
                DateOfBirth = DateTime.Now.AddYears(-28),
                Salary=20000,
                TimeCards = new List<TimeCard>()

                {
                    new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 10, TuesdayHours = 10, WednesdayHours = 10,
                        ThursdayHours = 8, FridayHours = 8, SaturdayHours = 0, SundayHours = 0
                    },
                     new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 0, TuesdayHours = 7, WednesdayHours = 7,
                        ThursdayHours = 8, FridayHours = 7, SaturdayHours = 0, SundayHours = 0
                    }
                }
            });

            employees.Add(new Employee()
            {
                FirstName = "Oliver",
                LastName = "Queen",
                Department = "IT",
                Role = "Manager",
                HireDate = DateTime.Now.AddYears(-2),
                DateOfBirth = DateTime.Now.AddYears(-35),
                Salary = 244000,
                TimeCards = new List<TimeCard>()
                {
                    new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 4, TuesdayHours = 7, WednesdayHours = 6,
                        ThursdayHours = 8, FridayHours = 5, SaturdayHours = 0, SundayHours = 0
                    },
                     new TimeCard()
                    {
                        SubmissionDate = DateTime.Now.AddDays(-30),
                        MondayHours = 0, TuesdayHours = 7, WednesdayHours = 7,
                        ThursdayHours = 8, FridayHours = 7, SaturdayHours = 0, SundayHours = 0
                    }
                }
            });
            context.Employees.AddRange(employees);
            base.Seed(context);
        }
    }
}
