using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models
{
    public class Candidate : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string NationalId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int QualificationTypeId { get; set; }
        public int CityCenterId { get; set; }
        public int VillageId { get; set; }

        public bool IsActive { get; set; }

        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }

        public int? DeletedBy { get; set; }
    }
}
