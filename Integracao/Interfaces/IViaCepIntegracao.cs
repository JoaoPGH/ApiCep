using Api.Cep.Integracao.Response;

namespace Api.Cep.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<CepResponse> ObterDadosViaCep(string cep);
    }
}
