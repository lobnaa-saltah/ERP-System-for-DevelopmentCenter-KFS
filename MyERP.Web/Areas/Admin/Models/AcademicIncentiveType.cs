using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.HR.Models;
using MyERP.Web.Models.Common;

namespace MyERP.Web.Areas.Admin.Models
{
    public class AcademicIncentiveType : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string ScientificDegree { get; set; } // ماجستير – دكتوراه ...

        public bool IsPercentage { get; set; }
        public bool IsFixedValue { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Value { get; set; }

        public int? DecisionId { get; set; }

        public bool IsActive { get; set; } = true;

        public int? CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(DecisionId))]
        public Decision Decision { get; set; }

        public ICollection<AcademicIncentiveRequest> AcademicIncentiveRequests { get; set; }
    }
}
