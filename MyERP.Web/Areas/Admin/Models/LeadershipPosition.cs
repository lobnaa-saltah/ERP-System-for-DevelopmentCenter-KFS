using MyERP.Web.Areas.HR.Models.Hierarechy;
using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.HR.Models;

namespace MyERP.Web.Areas.Admin.Models
{
    public class LeadershipPosition : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrgUnitId { get; set; }

        [ForeignKey("OrgUnitId")]
        public virtual OrgUnit OrgUnit { get; set; }

        [Required]
        public int JobTitleId { get; set; }

        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<LeadershipPositionHistory> LeadershipPositionHistories { get; set; }
    }
}
