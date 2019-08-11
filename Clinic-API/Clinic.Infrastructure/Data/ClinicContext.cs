using Clinic.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Infrastructure.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalOffice> MedicalOffices { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Referral> Referrals { get; set; }

    }
}