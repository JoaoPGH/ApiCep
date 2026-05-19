using Api.Cep.Integracao.Response;
using Refit;

namespace Api.Cep.Integracao.Refit
{
    public interface IViaEstadosIntegracaoRefit
    {
        [Get("/api/v1/localidades/estados/{estados}")]
        Task<ApiResponse<EstadosResponse>> ObterEstados(string estados);
    }
}
