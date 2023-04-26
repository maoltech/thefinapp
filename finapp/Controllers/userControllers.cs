using Microsoft.AspNetCore.Mvc;
using Credits.Repositories;
using Credits.Entities;
namespace User.Controllers
{

    [ApiController]
    [Route("credit")]
    public class CreditController : ControllerBase
    {
        private readonly InMemCreditsRepository repository; 

        public CreditController(){
          repository = new InMemCreditsRepository();
        }

        [HttpGet]
        public IEnumerable<Credit> GetCredits()
        {
            var Credit = repository.GetCredits();
            return Credit;
        }  

        [HttpGet("{creditid}")]
        public Credit GetCredit( Guid CreditId){
            var Credit = repository.GetCredit(CreditId);
            return Credit;
        }
    }
}