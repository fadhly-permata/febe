using System;
using FluentValidation;
using Repo.Domain.Models;

namespace Repo.Domain.Validation
{
    public partial class TrBpkbUpdateModelValidator
        : AbstractValidator<TrBpkbUpdateModel>
    {
        public TrBpkbUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AgreementNumber).NotEmpty();
            #endregion
        }

    }
}
