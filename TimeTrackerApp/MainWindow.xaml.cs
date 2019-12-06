﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeTrackerApp.Models;

namespace TimeTrackerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeTrackerDBContext context = new TimeTrackerDBContext();

            EmployeeAddTest(context);

            dgEmployees.ItemsSource = (from e in context.Employees
                                       select e).ToList();
        }

    
        private void EmployeeAddTest(TimeTrackerDBContext context)
        {

            Employee emp = new Employee()
            {


                FirstName = "Bruce",
                LastName = "Wayne",
                Department = "Sales",
                DateOfBirth = DateTime.Now.AddYears(-25),
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

            };

            context.Employees.Add(emp);
            context.SaveChanges();
        
        }
    }

}
