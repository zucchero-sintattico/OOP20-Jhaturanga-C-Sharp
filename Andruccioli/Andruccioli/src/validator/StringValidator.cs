using System;
using System.Collections.Generic;
using System.Linq;
using static OOP20.validator.StringValidator;
using static OOP20.validator.StringValidator.ValidationResult;

namespace OOP20.validator
{
    public sealed class StringValidator : IFuncConcatenator<string, ValidationResult>
    {
        private readonly IList<Func<string, ValidationResult>> rules = new List<Func<string, ValidationResult>>();

        public IFuncConcatenator<string, ValidationResult> Add(Func<string, ValidationResult> function)
        {
            this.rules.Add(function);
            return this;
        }

        public Func<string, ValidationResult> Create()
        {
            return s => this.rules.Select(x => x(s)).Where(x => x != CORRECT).DefaultIfEmpty(CORRECT).FirstOrDefault();
        }

        public static StringValidator operator +(StringValidator validator, Func<string, ValidationResult> function)
        {
            validator.Add(function);
            return validator;
        }

        public enum ValidationResult
        {
            CORRECT,
            EMPTY,
            TOO_SHORT,
            TOO_LONG
        }
    }
}
