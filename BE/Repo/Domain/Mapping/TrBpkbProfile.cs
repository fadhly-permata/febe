using System;
using AutoMapper;
using Repo.Data.Entities;
using Repo.Domain.Models;

namespace Repo.Domain.Mapping
{
    public partial class TrBpkbProfile
        : AutoMapper.Profile
    {
        public TrBpkbProfile()
        {
            CreateMap<Repo.Data.Entities.TrBpkb, Repo.Domain.Models.TrBpkbReadModel>();

            CreateMap<Repo.Domain.Models.TrBpkbCreateModel, Repo.Data.Entities.TrBpkb>();

            CreateMap<Repo.Data.Entities.TrBpkb, Repo.Domain.Models.TrBpkbUpdateModel>();

            CreateMap<Repo.Domain.Models.TrBpkbUpdateModel, Repo.Data.Entities.TrBpkb>();

            CreateMap<Repo.Domain.Models.TrBpkbReadModel, Repo.Domain.Models.TrBpkbUpdateModel>();

        }

    }
}
