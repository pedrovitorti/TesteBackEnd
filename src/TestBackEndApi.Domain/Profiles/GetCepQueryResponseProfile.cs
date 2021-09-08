using AutoMapper;
using TestBackEndApi.Domain.Queries.Cep.Get;
using TestBackEndApi.Infrastructure.Services.Contract;

namespace TestBackEndApi.Domain.Profiles
{
    public class GetCepQueryResponseProfile : Profile
    {
        public GetCepQueryResponseProfile()
        {
            CreateMap<CepResponse, GetCepQueryResponse>();
            CreateMap<MensagemResponse, MensagemQueryResponse>();
        }
    }
}
