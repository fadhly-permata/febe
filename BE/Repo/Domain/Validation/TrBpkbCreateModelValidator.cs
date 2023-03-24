using System;
using FluentValidation;
using Repo.Domain.Models;

namespace Repo.Domain.Validation
{
    public partial class TrBpkbCreateModelValidator
        : AbstractValidator<TrBpkbCreateModel>
    {
        public TrBpkbCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AgreementNumber).NotEmpty();
            #endregion
        }

    }
}
