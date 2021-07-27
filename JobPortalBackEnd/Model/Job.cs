﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortalBackEnd.Model
{
    public class Job
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string JobDetails { get; set; }
        public string JobTitle{ get; set; }
        public string Vacancy { get; set; }
        public string EmploymentStatus { get; set; }
        public string Experience { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string JobLocation { get; set; }
        public string Salary { get; set; }
        public string Deadline { get; set; }
    }
}

/*
 
JobDetails
JobTitle
Vacancy
EmploymentStatus
Experience
Gender
Age
JobLocation
Salary
Deadline
 */
