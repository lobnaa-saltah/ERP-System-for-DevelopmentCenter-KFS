using System.ComponentModel.DataAnnotations;

namespace MyERP.Web.Models.Common
{
    public class Document : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string ModelType { get; set; } // Employee, Decision, Request ...

        [Required]
        public int ModelId { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Status { get; set; } // Draft, Approved, Rejected

        [MaxLength(300)]
        public string FilePath { get; set; }

        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? DeletedBy { get; set; }
    }
}
