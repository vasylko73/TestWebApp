using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        
        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public  bool Married { get; set; }

        [Required]
        public  string Phone { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Salary must be greather than 0!")]
        public decimal Salary { get; set; }
        
    }
}
