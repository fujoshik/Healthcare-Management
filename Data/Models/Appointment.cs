using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Appointment : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Patient Patient { get; set; }

        [Required]
        public Doctor Doctor { get; set; }

        [Required]
        public bool IsApproved { get; set; }
    }
}
