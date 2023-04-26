
using System.Collections.Generic;
using Credits.Entities;

namespace Credits.Repositories
{
    public class InMemCreditsRepository
    {
        private readonly List<Credit>  credits = new()
        {
            new  Credit { CreditId = Guid.NewGuid(), initializeStatus = true, Status = "success"},
            new  Credit { CreditId = Guid.NewGuid(), initializeStatus = true, Status = "failed"}
        };

        public IEnumerable<Credit> GetCredits()
        {
            return credits;
        }

        public Credit GetCredit(Guid CreditId)
        {
            return  credits.Where( data => data.CreditId == CreditId).SingleOrDefault();
        }
 
    }
}