using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Attendance : BaseEntity
    {
        [Required]
        public Doctor Doctor { get; set; }

        [Required]
        public string Diagnosis { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public ICollection<string>? Medications { get; set; }
    }
}
