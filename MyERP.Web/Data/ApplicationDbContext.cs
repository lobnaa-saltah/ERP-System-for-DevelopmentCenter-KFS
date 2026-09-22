using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyERP.Web.Areas.Admin.Models;
using MyERP.Web.Areas.HR.Models;
using MyERP.Web.Areas.HR.Models.Hierarechy;
using MyERP.Web.Models.Common;
using MyERP.Web.Models.SeedDataModels;

namespace MyERP.Web.Data
{
    // بنورث من IdentityDbContext عشان ينزل جداول المستخدمين (Users, Roles, Logins)
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // هنا بنعرف الجداول الخاصة بينا مستقبلاً
        // public DbSet<Employee> Employees { get; set; }
        // common in main project
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<CityCenter> CityCenters { get; set; }
        public DbSet<LocalUnit> LocalUnits { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Decision> Decisions { get; set; }

        //hierarechy
        public DbSet<OrgUnitType> OrgUnitTypes { get; set; }
        public DbSet<OrgUnit> OrgUnits { get; set; }

        
        // Admin DbSets
        public DbSet<QualitativeGroup> QualitativeGroups { get; set; }
        public DbSet<FunctionalGroup> FunctionalGroups { get; set; }
        public DbSet<JobGrade> JobGrades { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<QualificationType> QualificationTypes { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<DecisionType> DecisionTypes { get; set; }
        public DbSet<DecisionAuthority> DecisionAuthorities { get; set; }

        public DbSet<LeadershipPosition> LeadershipPositions { get; set; }
        public DbSet<ServiceTerminationType> ServiceTerminationTypes { get; set; }

        // HR Dbsets
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeFamily> EmployeeFamilyMembers { get; set; }
        public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }
        public DbSet<EmployeeFile> EmployeeFiles { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<NominationFile> NominationFiles { get; set; }
        public DbSet<EmployeeDecision> EmployeeDecisions { get; set; }
        public DbSet<AcademicIncentiveType> AcademicIncentiveTypes { get; set; }
        public DbSet<AcademicIncentiveRequest> AcademicIncentiveRequests { get; set; }
        public DbSet<LeadershipPositionHistory> LeadershipPositionHistories { get; set; }
        public DbSet<ServiceTerminationRequest> ServiceTerminationRequests { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Notification>()
        .HasOne(n => n.SentToEmployee)
        .WithMany(e => e.NotificationsReceived)
        .HasForeignKey(n => n.SentTo)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Notification>()
                .HasOne(n => n.SentByEmployee)
                .WithMany(e => e.NotificationsSent)
                .HasForeignKey(n => n.SentBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AcademicIncentiveRequest>()
    .HasOne(a => a.Employee)
    .WithMany(e => e.AcademicIncentiveRequests)
    .HasForeignKey(a => a.EmployeeId)
    .OnDelete(DeleteBehavior.Restrict); // أو DeleteBehavior.NoAction






            // seeeeds
            GovernorateSeed.Seed(modelBuilder);
        }
    }
}