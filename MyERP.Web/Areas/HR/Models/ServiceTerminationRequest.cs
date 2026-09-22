using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Areas.HR.Models
{
    public class ServiceTerminationRequest : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ServiceTerminationTypeId { get; set; }

        [Required, MaxLength(50)]
        public string RequestNumber { get; set; }

        [MaxLength(200)]
        public string IssuedTo { get; set; }

        public DateTime RequestDate { get; set; }
        public DateTime? RequestStartDate { get; set; }

        public string Reason { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Draft, Submitted, Approved, Rejected

        [MaxLength(300)]
        public string FilePath { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }

        [ForeignKey(nameof(ServiceTerminationTypeId))]
        public ServiceTerminationType ServiceTerminationType { get; set; }
    }
}
