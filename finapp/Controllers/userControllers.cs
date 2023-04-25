using Microsoft.AspNetCore.Mvc;
using Credits.Repositories;
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
        public IEnumerable<Credits> GetCredits(){
 
        }
    }
}