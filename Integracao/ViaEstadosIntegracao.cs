using Api.Cep.Integracao.Interfaces;
using Api.Cep.Integracao.Refit;
using Api.Cep.Integracao.Response;

namespace Api.Cep.Integracao
{
    public class ViaEstadosIntegracao : IViaEstadosIntegracao
    {
        private readonly IViaEstadosIntegracaoRefit _refit;

        public ViaEstadosIntegracao(IViaEstadosIntegracaoRefit refit)
        {
            _refit = refit;
        }

        public async Task<EstadosResponse> ObterEstados(string estados)
        {
            var responseData = await _refit.ObterEstados(estados);
            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
