﻿using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? Department { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
