namespace EGovernment.Data
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    using EGovernment.Data.Common.Models;
    using EGovernment.Data.Models;
    using EGovernment.Data.Models.Models.Geographical;
    using EGovernment.Data.Models.Models.Health;
    using EGovernment.Data.Models.Models.Health.Entities;
    using EGovernment.Data.Models.Models.MappingTables;
    using EGovernment.Data.Models.Models.People;
    using EGovernment.Data.Models.Models.Vehicles;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private static readonly MethodInfo SetIsDeletedQueryFilterMethod =
            typeof(ApplicationDbContext).GetMethod(
                nameof(SetIsDeletedQueryFilter),
                BindingFlags.NonPublic | BindingFlags.Static);

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Setting> Settings { get; set; }

        // TODO add DBset for each Model
        public DbSet<District> Districts { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Ministry> Ministries { get; set; }

        public DbSet<MedicalRecord> MedicalRecords { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<Visit> Visits { get; set; }

        public DbSet<Diagnose> Diagnoses { get; set; }

        public DbSet<DoctorEntity> DoctorsEntities { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Specialty> Specialties { get; set; }

        public DbSet<SpecialtyDoctor> SpecialtiesDoctors { get; set; }

        public DbSet<DepartmentEntity> DepartmentsEntities { get; set; }

        public override int SaveChanges() => this.SaveChanges(true);

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
            this.SaveChangesAsync(true, cancellationToken);

        public override Task<int> SaveChangesAsync(
            bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfoRules();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Needed for Identity models configuration
            base.OnModelCreating(builder);

            ConfigureUserIdentityRelations(builder);

            EntityIndexesConfiguration.Configure(builder);

            var entityTypes = builder.Model.GetEntityTypes().ToList();

            // Set global query filter for not deleted entities only
            var deletableEntityTypes = entityTypes
                .Where(et => et.ClrType != null && typeof(IDeletableEntity).IsAssignableFrom(et.ClrType));
            foreach (var deletableEntityType in deletableEntityTypes)
            {
                var method = SetIsDeletedQueryFilterMethod.MakeGenericMethod(deletableEntityType.ClrType);
                method.Invoke(null, new object[] { builder });
            }

            // Disable cascade delete
            var foreignKeys = entityTypes
                .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
            foreach (var foreignKey in foreignKeys)
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Add Mapping tables refernce
            builder.Entity<DoctorEntity>()
              .HasKey(k => new
              {
                  k.DoctorId,
                  k.EntityId,
              });

            builder.Entity<DepartmentEntity>()
             .HasKey(k => new
             {
                 k.DepartmentId,
                 k.EntityId,
             });

            builder.Entity<SpecialtyDoctor>()
             .HasKey(k => new
             {
                 k.DoctorId,
                 k.SpecialtyId,
             });

            builder.Entity<EntityVisit>()
             .HasKey(k => new
             {
                 k.VisitId,
                 k.EntityId,
             });

            builder.Entity<MedicineVisit>()
            .HasKey(k => new
            {
                k.MedicineId,
                k.VisitId,
            });

            builder.Entity<RecordDiagnose>()
             .HasKey(k => new
             {
                 k.MedicalRecordId,
                 k.DiagnoseId,
             });
        }

        private static void ConfigureUserIdentityRelations(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<ApplicationUser>()
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }

        private static void SetIsDeletedQueryFilter<T>(ModelBuilder builder)
            where T : class, IDeletableEntity
        {
            builder.Entity<T>().HasQueryFilter(e => !e.IsDeleted);
        }

        private void ApplyAuditInfoRules()
        {
            var changedEntries = this.ChangeTracker
                .Entries()
                .Where(e =>
                    e.Entity is IAuditInfo &&
                    (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in changedEntries)
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default)
                {
                    entity.CreatedOn = DateTime.UtcNow;
                }
                else
                {
                    entity.ModifiedOn = DateTime.UtcNow;
                }
            }
        }
    }
}
