using CaixaEletronico.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaixaEletronico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaixaEletronico : ControllerBase
    {
        private readonly ISaqueRepository _saqueRepository;

        public CaixaEletronico(ISaqueRepository saqueRepository)
        {
            _saqueRepository = saqueRepository;
        }


        [HttpPost]
        public ActionResult Saque(int valorSaque)
        {
            try
            {
                if (valorSaque <= 0 || valorSaque > 1000)
                {
                    return BadRequest("Não é possível fazer um saque nulo ou maior que R$1000.");
                }

                string cedulas = _saqueRepository.CalcularCedulas(valorSaque);

                if(string.IsNullOrEmpty(cedulas))
                {
                    return BadRequest("Não é possível fazer saque desse valor.");
                }

                return Ok(cedulas);

            }catch (Exception ex)
            {
                return BadRequest($"Não foi possível realizar o saque. Detalhes: {ex.Message}");
            }
        }
    }
}
