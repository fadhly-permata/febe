using System;
using FluentValidation;
using Repo.Domain.Models;

namespace Repo.Domain.Validation
{
    public partial class MsStorageLocationCreateModelValidator
        : AbstractValidator<MsStorageLocationCreateModel>
    {
        public MsStorageLocationCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.LocationId).NotEmpty();
            #endregion
        }

    }
}
