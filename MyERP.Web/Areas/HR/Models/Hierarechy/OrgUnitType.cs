using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models.Hierarechy
{
    public class OrgUnitType : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int LevelOrder { get; set; }

        public bool CanHaveChild { get; set; }

        public virtual ICollection<OrgUnit> OrgUnits { get; set; }
    }
}
