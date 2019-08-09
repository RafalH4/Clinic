using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Core.Domain
{
    public abstract class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressPostCode { get; set; }
        public string Pesel { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
