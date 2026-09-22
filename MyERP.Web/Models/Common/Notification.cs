using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyERP.Web.Areas.HR.Models;

namespace MyERP.Web.Models.Common
{
    public class Notification : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SentTo { get; set; }

        [Required]
        public int SentBy { get; set; }

        [Required]
        public string Text { get; set; }

      // Navigation
        [ForeignKey(nameof(SentTo))]
        public Employee SentToEmployee { get; set; }

        [ForeignKey(nameof(SentBy))]
        public Employee SentByEmployee { get; set; }
    }
}
