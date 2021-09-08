using FluentValidation;
using TestBackEndApi.Domain.Queries.Cep.Get;

namespace TestBackEndApi.Domain.Queries.Cep.Validator
{
    public class GetCepQueryValidator : AbstractValidator<GetCepQuery>
    {
        public GetCepQueryValidator()
        {
            RuleFor(_request => _request.Cep).NotEmpty().WithMessage("Informe o Cep!");
        }
    }
}
