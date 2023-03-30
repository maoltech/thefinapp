using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Entities
{
    public class User
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; init; }

        [Required]
        [StringLength(50)]
        public string LastName { get; init; }

        [Required]
        [EmailAddress]
        public string Email { get; init; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; init; }

        [NotMapped]
        [Compare("Password")] 
        public string ConfirmPassword { get; init; }

        [Required]
        [StringLength(10)]
        public string Phone { get; init; }

        [Required]
        [StringLength(100)]
        public string Address { get; init; }

        public decimal Balance { get; init; }

        public string BVN {get; init;}
        public DateTimeOffset DOB {get; init;}
        public DateTimeOffset CreateDate {get; init;}

    }
} 

