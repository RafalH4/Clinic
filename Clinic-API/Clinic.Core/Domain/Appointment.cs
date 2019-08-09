using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public MedicalOffice Office { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
