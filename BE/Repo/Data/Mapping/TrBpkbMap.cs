using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repo.Data.Mapping
{
    public partial class TrBpkbMap
        : IEntityTypeConfiguration<Repo.Data.Entities.TrBpkb>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Repo.Data.Entities.TrBpkb> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("tr_bpkb");

            // key
            builder.HasKey(t => t.AgreementNumber);

            // properties
            builder.Property(t => t.AgreementNumber)
                .IsRequired()
                .HasColumnName("agreement_number")
                .HasColumnType("TEXT");

            builder.Property(t => t.BpkbNo)
                .HasColumnName("bpkb_no")
                .HasColumnType("TEXT");

            builder.Property(t => t.BranchId)
                .HasColumnName("branch_id")
                .HasColumnType("TEXT");

            builder.Property(t => t.BpkbDate)
                .HasColumnName("bpkb_date")
                .HasColumnType("TEXT");

            builder.Property(t => t.FakturNo)
                .HasColumnName("faktur_no")
                .HasColumnType("TEXT");

            builder.Property(t => t.FakturDate)
                .HasColumnName("faktur_date")
                .HasColumnType("TEXT");

            builder.Property(t => t.LocationId)
                .HasColumnName("location_id")
                .HasColumnType("TEXT");

            builder.Property(t => t.PoliceNo)
                .HasColumnName("police_no")
                .HasColumnType("TEXT");

            builder.Property(t => t.BpkbDateId)
                .HasColumnName("bpkb_date_id")
                .HasColumnType("TEXT");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            public const string Schema = "";
            public const string Name = "tr_bpkb";
        }

        public struct Columns
        {
            public const string AgreementNumber = "agreement_number";
            public const string BpkbNo = "bpkb_no";
            public const string BranchId = "branch_id";
            public const string BpkbDate = "bpkb_date";
            public const string FakturNo = "faktur_no";
            public const string FakturDate = "faktur_date";
            public const string LocationId = "location_id";
            public const string PoliceNo = "police_no";
            public const string BpkbDateId = "bpkb_date_id";
        }
        #endregion
    }
}
