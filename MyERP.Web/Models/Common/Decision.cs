using MyERP.Web.Areas.HR.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Models.Common
{
    public class Decision : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Number { get; set; }

        [Required]
        public int DecisionTypeId { get; set; }

        [Required]
        public int DecisionAuthorityId { get; set; }

        public DateTime DecisionDate { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public bool AffectsEmployee { get; set; }
        public bool AffectsGroup { get; set; }
        public bool IsTemporary { get; set; }

        public string Subject { get; set; }
        public string Notes { get; set; }

        [MaxLength(300)]
        public string FilePath { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Draft, Approved, Rejected, Archived


        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(DecisionTypeId))]
        public DecisionType DecisionType { get; set; }

        [ForeignKey(nameof(DecisionAuthorityId))]
        public DecisionAuthority DecisionAuthority { get; set; }

        public ICollection<EmployeeDecision> EmployeeDecisions { get; set; }
    }
}
