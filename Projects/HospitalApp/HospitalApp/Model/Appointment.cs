
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalApp.Model
{
    class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string PatientName { get; set; }
        public string Problem { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int DoctorId { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }
    }
}
