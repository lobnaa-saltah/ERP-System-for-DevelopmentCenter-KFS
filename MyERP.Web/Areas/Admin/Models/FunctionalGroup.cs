using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.Admin.Models
{
    public class FunctionalGroup : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int QualitativeGroupId { get; set; }

        [ForeignKey("QualitativeGroupId")]
        public virtual QualitativeGroup QualitativeGroup { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<JobTitle> JobTitles { get; set; }
    }
}
