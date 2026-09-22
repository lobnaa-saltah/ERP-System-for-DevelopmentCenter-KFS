using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Areas.HR.Models
{
    public class LeadershipPositionHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LeadershipPositionId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [MaxLength(100)]
        public string DecisionNumber { get; set; }

        public DateTime? DecisionDate { get; set; }

        public string Notes { get; set; }

        public int? CreatedBy { get; set; }


        public int? UpdatedBy { get; set; }

        // Navigation
        [ForeignKey(nameof(LeadershipPositionId))]
        public LeadershipPosition LeadershipPosition { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
