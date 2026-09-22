using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Areas.HR.Models
{
    public class AcademicIncentiveRequest : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int AcademicIncentiveTypeId { get; set; }

        [Required]
        public int QualificationId { get; set; }

        public DateTime RequestDate { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Draft, Submitted, Approved, Rejected

        public DateTime? RequestAffectDate { get; set; }

        public string Notes { get; set; }

        [MaxLength(300)]
        public string FilePath { get; set; }

        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

        [ForeignKey(nameof(AcademicIncentiveTypeId))]
        public AcademicIncentiveType AcademicIncentiveType { get; set; }

        [ForeignKey(nameof(QualificationId))]
        public EmployeeQualification Qualification { get; set; }
    }
}

