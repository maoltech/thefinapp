using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credits.Entities
{
    public class Credit
    {
        [Key]
        public Guid CreditId { get; init; }

        [Required]
        [StringLength(50)]
        public string? UserId { get; init; }

        [Required]
        [StringLength(50)]
        public string? initializeStatus { get; init; }

        [Required]
        [StringLength(50)]
        public string? Status { get; init; }

        [Required]
        [EmailAddress]
        public string? senderEmail { get; init; }

        [Required]
        [StringLength(100)]
        public int? amount { get; init; }

        public string? receiverEmail  { get; init; }

        [Required]
        [StringLength(10)]
        public string? Phone { get; init; }

        [Required]
        [StringLength(100)]
        public string? accountName { get; init; }

        [Required]
        [StringLength(100)]
        public string? bankName { get; init; }
        
        [Required]
        [StringLength(100)]
        public string? accountNumber { get; init; }

        public string? BVN {get; init;}


        public DateTimeOffset DOB {get; init;}
        public DateTimeOffset CreateDate {get; init;}

    }
} 

