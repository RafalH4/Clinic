using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Doctor : User
    {
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Appointment> Appointments { get; set;}
    }

}
