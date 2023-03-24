using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repo.Data.Mapping
{
    public partial class MsStorageLocationMap
        : IEntityTypeConfiguration<Repo.Data.Entities.MsStorageLocation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Repo.Data.Entities.MsStorageLocation> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("ms_storage_location");

            // key
            builder.HasKey(t => t.LocationId);

            // properties
            builder.Property(t => t.LocationId)
                .IsRequired()
                .HasColumnName("location_id")
                .HasColumnType("TEXT");

            builder.Property(t => t.LocationName)
                .HasColumnName("location_name")
                .HasColumnType("TEXT");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "";
            public const string Name = "ms_storage_location";
        }

        public struct Columns
        {
            public const string LocationId = "location_id";
            public const string LocationName = "location_name";
        }
        #endregion
    }
}
