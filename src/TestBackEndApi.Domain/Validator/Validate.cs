using AutoMapper;
using FluentValidation.Results;
using System;
using System.Text.Json.Serialization;

namespace TestBackEndApi.Domain.Validator
{
    public abstract class Validate
    {
        [JsonIgnore]
        [IgnoreMap]
        internal ValidationResult ValidationResult { get; set; }

        public Validate()
        {
            ValidationResult = new ValidationResult();
        }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
