using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.HR.Models;

namespace MyERP.Web.Models.Common
{
    public class Review : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ReviewerId { get; set; }

        [Required, MaxLength(100)]
        public string ModelType { get; set; } // Document, EmployeeDocuments, Decision

        [Required]
        public int ModelId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Pending, Approved, Rejected

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        [ForeignKey(nameof(ReviewerId))]
        public Employee Reviewer { get; set; }
    }
}
