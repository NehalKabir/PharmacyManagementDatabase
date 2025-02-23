using Microsoft.EntityFrameworkCore;
using PharmacyManagementAPI.Entities;
using System;

namespace PharmacyManagementAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<DoctorInfo> DoctorInfo { get; set; }
        public DbSet<IllnessInfo> IllnessInfo { get; set; }
        public DbSet<PatientInfo> PatientInfo { get; set; }
        public DbSet<MedicineInfo> MedicineInfo { get; set; }

        public DbSet<PatientMedicineMap> PatientMedicineMap { get; set; }
        public DbSet<PatientIllnessMap> PatientIllnessMap { get; set; }
    }
}
