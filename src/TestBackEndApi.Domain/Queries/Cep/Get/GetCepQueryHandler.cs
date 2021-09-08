using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TestBackEndApi.Infrastructure.Services.Contract;
using TestBackEndApi.Infrastructure.Services.Interfaces;

namespace TestBackEndApi.Domain.Queries.Cep.Get
{
    public sealed class GetCepQueryHandler : IRequestHandler<GetCepQuery, GetCepQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IViaCepServiceClient _iViaCepServiceClient;

        public GetCepQueryHandler(IMapper mapper, IViaCepServiceClient iViaCepServiceClient)
        {
            _mapper = mapper;
            _iViaCepServiceClient = iViaCepServiceClient;
        }

        public async Task<GetCepQueryResponse> Handle(GetCepQuery request, CancellationToken cancellationToken)
        {
            var getCepRequest = _mapper.Map<CepRequest>(request);
            var results = new CepResponse();
            results.Mensagens = new List<MensagemResponse>();

            if (!request.IsValid())
            {
                foreach (var error in request.ValidationResult.Errors)
                {
                    MensagemResponse mensagem = new MensagemResponse();
                    mensagem.Mensagem = error.ErrorMessage;
                    results.Mensagens.Add(mensagem);
                }
            }
            else
            {
                results = await _iViaCepServiceClient.ObterEnderecoPorCepAsync(getCepRequest);
                results.Mensagens = new List<MensagemResponse>();
                results.Mensagens.Add(new MensagemResponse() { Mensagem = "Sucesso" });
            }

            return _mapper.Map<GetCepQueryResponse>(results.Mensagens);
        }
    }
}
