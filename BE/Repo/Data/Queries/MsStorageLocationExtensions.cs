using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repo.Data.Queries
{
    public static partial class MsStorageLocationExtensions
    {
        #region Generated Extensions
        public static Repo.Data.Entities.MsStorageLocation? GetByKey(this IQueryable<Repo.Data.Entities.MsStorageLocation> queryable, string locationId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<Repo.Data.Entities.MsStorageLocation> dbSet)
                return dbSet.Find(locationId);

            return queryable.FirstOrDefault(q => q.LocationId == locationId);
        }

        public static ValueTask<Repo.Data.Entities.MsStorageLocation?> GetByKeyAsync(this IQueryable<Repo.Data.Entities.MsStorageLocation> queryable, string locationId)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<Repo.Data.Entities.MsStorageLocation> dbSet)
                return dbSet.FindAsync(locationId);

            var task = queryable.FirstOrDefaultAsync(q => q.LocationId == locationId);
            return new ValueTask<Repo.Data.Entities.MsStorageLocation?>(task);
        }

        #endregion

    }
}
