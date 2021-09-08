using MediatR;
using TestBackEndApi.Domain.Queries.Cep.Validator;
using TestBackEndApi.Domain.Validator;

namespace TestBackEndApi.Domain.Queries.Cep.Get
{
    public class GetCepQuery : Validate, IRequest<GetCepQueryResponse>
    {
        public string Cep { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new GetCepQueryValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
