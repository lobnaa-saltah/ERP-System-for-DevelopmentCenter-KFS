using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Models.Common
{
    public class Setting: BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Logo { get; set; }

        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
