
using Credits.Entities;

namespace Credits.Repositories
{
    public class InMemCreditsRepository : IInMemCreditsRepository
    {
        private readonly List<Credit> credits = new()
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
            var info = credits.Where(data => data.CreditId == CreditId).SingleOrDefault();

            if(info == null){
                return info;
            }
             
            return info;
        }

        public void CreateCredit(Credit data)
        {
            credits.Add(data);
        }

        public void UpdateCredit(Credit data)
        {
            var index = credits.FindIndex(info => info.CreditId == data.CreditId);
            credits[index] = data;
        }

    }
}