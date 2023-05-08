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

        [HttpPost("pay")]
        public ActionResult<CreditDto> CreateCredit(CreateCreditDto data)
        {
            Credit credit = new()
            {
                CreditId = Guid.NewGuid(),
                amount = data.amount,
                Phone = data.Phone,
                accountName = data.accountName,
                accountNumber = data.accountNumber,
                bankName = data.bankName
            };
            
                repository.CreateCredit(credit);

                return CreatedAtAction(nameof(GetCredit), new {creditId = credit.CreditId}, credit.AsDto());

        }


        [HttpPost("update")]

        public ActionResult UpdateCredit(Guid CreditId, UpdateCreditDto creditDto )
        {
                var existingCredit = repository.GetCredit(CreditId);

                if(existingCredit is null){
                    return NotFound();
                };

                Credit updatedCredit = existingCredit with{
                    amount = creditDto.amount,
                    accountName = creditDto.accountName
                };

                repository.UpdateCredit(updatedCredit);

                return NoContent();         
        }
    }
}