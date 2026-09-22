using MyERP.Web.Models;
using MyERP.Web.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.Admin.Models;

namespace MyERP.Web.Areas.HR.Models.Hierarechy
{
    public class OrgUnit : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }

        [ForeignKey("ParentId")]
        public virtual OrgUnit Parent { get; set; }

        [Required]
        public int OrgUnitTypeId { get; set; }

        [ForeignKey("OrgUnitTypeId")]
        public virtual OrgUnitType OrgUnitType { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public bool IsActive { get; set; } = true;

        public int? GovernorateId { get; set; }

        [ForeignKey("GovernorateId")]
        public virtual Governorate Governorate { get; set; }

        public virtual ICollection<OrgUnit> Children { get; set; }
        public virtual ICollection<LeadershipPosition> LeadershipPositions { get; set; }
    }
}
