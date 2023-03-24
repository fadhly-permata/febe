using System;
using FluentValidation;
using Repo.Domain.Models;

namespace Repo.Domain.Validation
{
    public partial class MsStorageLocationUpdateModelValidator
        : AbstractValidator<MsStorageLocationUpdateModel>
    {
        public MsStorageLocationUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocationId).NotEmpty();
            #endregion
        }

    }
}
