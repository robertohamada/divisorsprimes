using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ServiceDivisorPrime.BLL;
using ServiceDivisorPrime.DTO;

namespace ServiceDivisorPrime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisorsController : ControllerBase
    {

        [HttpGet("{pNumber}")]
        public ActionResult<ResultsDto> Calc(long pNumber)
        {
            if (pNumber <= 0)
                BadRequest($"Número inválido: {pNumber}");
            var divisorBll = new DivisorsBLL();
            return divisorBll.Calc(pNumber);
        }

        [HttpGet]
        public async Task<ResultsDto> Get(long pNumber)
        {
            if (pNumber <= 0)
                BadRequest($"Número inválido: {pNumber}");
            var divisorBll = new DivisorsBLL();
            return await divisorBll.GetDivisorsList(pNumber).ConfigureAwait(false);
        }

    }
}
