using Credits.Dtos;
using Credits.Entities;

namespace Credits
{
    public static class Extensions{
        public static CreditDto AsDto( this  Credit data)
        {
                return new CreditDto{
                CreditId = data.CreditId,
                Status = data.Status,
                bankName = data.bankName,
                accountName = data.accountName,
                accountNumber = data.accountNumber,
                amount = data.amount
                };

        }
    }
    
}