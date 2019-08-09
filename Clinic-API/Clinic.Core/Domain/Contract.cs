using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Contract
    {
        public Doctor Doctor { get; set; }
        public Department Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
