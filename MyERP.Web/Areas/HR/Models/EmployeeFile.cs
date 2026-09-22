using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models
{
    public class EmployeeFile : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public string MilitaryFile { get; set; }
        public string QualificationFile { get; set; }
        public string BirthCertificateFile { get; set; }
        public string PoliceClearanceCertificate { get; set; }
        public string NationalIdCardFront { get; set; }
        public string NationalIdCardBack { get; set; }
        public string MarriageDocument { get; set; }
        public string PersonalPhoto { get; set; }

        // Navigation
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
    }
}
