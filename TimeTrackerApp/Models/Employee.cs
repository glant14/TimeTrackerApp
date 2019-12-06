﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackerApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }
        
        public string Department { get; set; }

        public List<TimeCard> TimeCards { get; set; }
        //New Property
        public string Role { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Range(100,1000000)]
        public double Salary { get; set; }
    }
}
