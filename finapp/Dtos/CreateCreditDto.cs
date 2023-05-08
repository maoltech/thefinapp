
namespace Credits.Dtos
{
    
      public record CreateCreditDto
    {
        public Guid CreditId { get; init; }
        public string? UserId { get; init; }

        public string? senderEmail { get; init; }

        public int? amount { get; init; }

        public string? receiverEmail  { get; init; }

        public string? Phone { get; init; }

        public string? accountName { get; init; }

        public string? bankName { get; init; }

        public string? accountNumber { get; init; }
        
    }

}