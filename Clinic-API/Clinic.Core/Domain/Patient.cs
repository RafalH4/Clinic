﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Patient
    {
        public ICollection<Appointment> Appointments { get; set; }
    }
}
