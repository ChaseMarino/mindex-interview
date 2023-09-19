using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeChallenge.Models
{
    public class Compensation
    {
        [Key]
        public int CompensationId { get; set; } 
        public String EmployeeId { get; set; }
        public int Salary { get; set; }
        public String EffectiveDate { get; set; }
    }
}
