using Api.Cep.Integracao.Response;

namespace Api.Cep.Integracao.Interfaces
{
    public interface IViaEstadosIntegracao
    {
        Task<EstadosResponse> ObterEstados(string estados);
    }
}
