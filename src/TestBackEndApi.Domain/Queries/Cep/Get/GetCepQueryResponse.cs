using System.Collections.Generic;

namespace TestBackEndApi.Domain.Queries.Cep.Get
{
    public class GetCepQueryResponse
    {
        public string Cep { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Localidade { get; set; }

        public string Uf { get; set; }

        public string Ibge { get; set; }

        public string Gia { get; set; }

        public string Ddd { get; set; }

        public string Siafi { get; set; }

        public List<MensagemQueryResponse> Mensagens { get; set; }
    }

    public class MensagemQueryResponse
    {
        public string Mensagem { get; set; }
    }
}
