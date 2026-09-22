using MyERP.Web.Areas.Admin.Models;
using MyERP.Web.Areas.HR.Models.Hierarechy;
using MyERP.Web.Models;
using MyERP.Web.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models
{
    public class Employee : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string NationalId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }

        public int? CityCenterId { get; set; }
        public int? VillageId { get; set; }

        [MaxLength(50)]
        public string MaritalStatus { get; set; }

        public int? QualificationTypeId { get; set; }
        public string Specialization { get; set; }

        public int? EmploymentTypeId { get; set; }
        public int? JobTitleId { get; set; }
        public int? JobGradeId { get; set; }
        public int? FunctionalGroupId { get; set; }
        public int? OrgUnitId { get; set; }
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public CityCenter CityCenter { get; set; }
        public Village Village { get; set; }
        public QualificationType QualificationType { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public JobTitle JobTitle { get; set; }
        public JobGrade JobGrade { get; set; }
        public FunctionalGroup FunctionalGroup { get; set; }
        public OrgUnit OrgUnit { get; set; }

        public EmployeeFile EmployeeFile { get; set; }
        public ICollection<EmployeeFamily> EmployeeFamilies { get; set; }

        // Relations from previous modules
        public ICollection<EmployeeDecision> EmployeeDecisions { get; set; }
        public ICollection<ServiceTerminationRequest> ServiceTerminationRequests { get; set; }
        public ICollection<AcademicIncentiveRequest> AcademicIncentiveRequests { get; set; }
        public ICollection<Notification> NotificationsReceived { get; set; }
        public ICollection<Notification> NotificationsSent { get; set; }
    }
}
