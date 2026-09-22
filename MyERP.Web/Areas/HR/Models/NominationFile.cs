using MyERP.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Areas.HR.Models
{
    public class NominationFile : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public int CandidateId { get; set; }
        public string FilePath { get; set; }

        public DateTime ReceiveDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }

        public string Status { get; set; }
        public string ReferenceNumber { get; set; }

        public Candidate Candidate { get; set; }
    }
}
