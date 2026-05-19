using Api.Cep.Integracao.Response;
using Refit;

namespace Api.Cep.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json/")]
        Task<ApiResponse<CepResponse>> ObterDadosViaCep(string cep); 
    }
}
