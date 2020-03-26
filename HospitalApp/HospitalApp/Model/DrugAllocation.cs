using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalApp.Model
{
    class DrugAllocation
    {
        [Key]
        public int DrugAllocationId { get; set; }
        [ForeignKey(nameof(DrugId))]
        public int DrugId { get; set; }
        [ForeignKey(nameof(PatientId))]
        public int PatientId { get; set; }
        [ForeignKey(nameof(DoctorId))]
        public int DoctorId { get; set; }

    }
}
