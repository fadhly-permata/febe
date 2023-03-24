using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repo.Context
{
    public partial class BpkbContext : DbContext
    {
        public BpkbContext(DbContextOptions<BpkbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            #pragma warning disable CS1030 // #warning directive
            => optionsBuilder.UseSqlite("Data Source=/home/permata/Downloads/GitHub/untitled folder/MSBU/BE/DB/bpkb.sqlite");

        #region Generated Properties
        public virtual DbSet<Repo.Data.Entities.MsStorageLocation> MsStorageLocations { get; set; } = null!;

        public virtual DbSet<Repo.Data.Entities.TrBpkb> TrBpkbs { get; set; } = null!;

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Repo.Data.Mapping.MsStorageLocationMap());
            modelBuilder.ApplyConfiguration(new Repo.Data.Mapping.TrBpkbMap());
            #endregion
        }
    }
}
