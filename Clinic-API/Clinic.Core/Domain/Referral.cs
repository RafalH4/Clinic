using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public class Referral
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        //ICD9
    }
}
