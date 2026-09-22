using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Areas.HR.Models
{
    public class EmployeeQualification : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        public int QualificationTypeId { get; set; }

        [ForeignKey("QualificationTypeId")]
        public virtual QualificationType QualificationType { get; set; }

        [Required]
        [StringLength(200)]
        public string QualificationFullName { get; set; }

        [StringLength(150)]
        public string Specialization { get; set; }

        [StringLength(150)]
        public string University { get; set; }

        public int? GraduationYear { get; set; }

        [StringLength(50)]
        public string Grade { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        public bool IsVerified { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<AcademicIncentiveRequest> AcademicIncentiveRequests { get; set; }
    }
}
