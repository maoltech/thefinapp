using Microsoft.AspNetCore.Mvc;
using Credits.Repositories;
using Credits.Entities;
using Credits.Dtos;
using Credits;
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
        public IEnumerable<CreditDto> GetCredits()
        {
            var Credit = repository.GetCredits().Select( data => data.AsDto() );
            return Credit;
        }  

        [HttpGet("{creditId}")]
        public ActionResult<CreditDto> GetCredit( Guid CreditId){
            var Credit = repository.GetCredit(CreditId);

            if (Credit is null){
                return NotFound();
            }
            return Credit.AsDto();
        }
    }
}