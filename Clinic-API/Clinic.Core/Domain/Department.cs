using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        private ISet<MedicalOffice> _offices = new HashSet<MedicalOffice>();

        private ISet<Contract> _contracts = new HashSet<Contract>();
    }
}
