using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class MedicalOffice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
