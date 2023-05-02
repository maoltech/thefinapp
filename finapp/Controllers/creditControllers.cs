using Microsoft.AspNetCore.Mvc;
using Credits.Repositories;
using Credits.Entities;
namespace User.Controllers
{

    [ApiController]
    [Route("credit")]
    public class CreditController : ControllerBase
    {
        private readonly IInMemCreditsRepository repository; 

        public CreditController(IInMemCreditsRepository repository){
          this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Credit> GetCredits()
        {
            var Credit = repository.GetCredits();
            return Credit;
        }  

        [HttpGet("{creditId}")]
        public ActionResult<Credit> GetCredit( Guid CreditId){
            var Credit = repository.GetCredit(CreditId);

            if (Credit is null){
                return NotFound();
            }
            return Credit;
        }
    }
}