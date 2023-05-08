using Credits.Entities;

namespace Credits.Repositories{

    public interface IInMemCreditsRepository
    {
        Credit GetCredit(Guid CreditId);
        IEnumerable<Credit> GetCredits();

        void CreateCredit(Credit data); 

        void UpdateCredit(Credit data);
    }
}