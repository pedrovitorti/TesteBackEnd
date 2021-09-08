using System.Threading.Tasks;
using TestBackEndApi.Infrastructure.Services.Contract;

namespace TestBackEndApi.Infrastructure.Services.Interfaces
{
    public interface IViaCepServiceClient
    {
        Task<CepResponse> ObterEnderecoPorCepAsync(CepRequest cepRequest);
    }
}
