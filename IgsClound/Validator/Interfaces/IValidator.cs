using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IgsClound.Validator.Interfaces
{
    public interface IValidator<T>
    {
        protected static ValidationResult Validate(T input)
        {
            return new ValidationResult();
        }
    }
}
