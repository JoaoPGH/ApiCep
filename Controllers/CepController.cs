using Api.Cep.Integracao;
using Api.Cep.Integracao.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Cep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _integracao;

        public CepController(IViaCepIntegracao integracao)
        {
            _integracao = integracao;
        }

        [HttpGet]
        public async Task<ActionResult<ViaCepIntegracao>> ListarEndereco(string cep)
        {
            var responsaData = await _integracao.ObterDadosViaCep(cep);

            if(responsaData == null)
            {
                return BadRequest("Cep não encontrado");
            }

            return Ok(responsaData);
        }
    }
}
