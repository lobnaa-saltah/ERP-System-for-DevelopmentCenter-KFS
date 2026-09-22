using MyERP.Web.Models;
using MyERP.Web.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyERP.Web.Areas.HR.Models
{
    public class EmployeeDecision : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DecisionId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public string Description { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Active, Ended, Cancelled

        public string Notes { get; set; }

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(DecisionId))]
        public Decision Decision { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
