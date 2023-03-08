using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Patient : Person
    {
        [Required]
        public ICollection<Appointment> Appointments { get; set; }

        [Required]
        public ICollection<Attendance> Attendances { get; set; }

        [Required]
        public Doctor? PersonalDoctor { get; set; }
    }
}
