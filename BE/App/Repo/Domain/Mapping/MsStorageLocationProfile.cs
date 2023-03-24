using System;
using AutoMapper;
using Repo.Data.Entities;
using Repo.Domain.Models;

namespace Repo.Domain.Mapping
{
    public partial class MsStorageLocationProfile
        : AutoMapper.Profile
    {
        public MsStorageLocationProfile()
        {
            CreateMap<Repo.Data.Entities.MsStorageLocation, Repo.Domain.Models.MsStorageLocationReadModel>();

            CreateMap<Repo.Domain.Models.MsStorageLocationCreateModel, Repo.Data.Entities.MsStorageLocation>();

            CreateMap<Repo.Data.Entities.MsStorageLocation, Repo.Domain.Models.MsStorageLocationUpdateModel>();

            CreateMap<Repo.Domain.Models.MsStorageLocationUpdateModel, Repo.Data.Entities.MsStorageLocation>();

            CreateMap<Repo.Domain.Models.MsStorageLocationReadModel, Repo.Domain.Models.MsStorageLocationUpdateModel>();

        }

    }
}
