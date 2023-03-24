using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repo.Data.Queries
{
    public static partial class TrBpkbExtensions
    {
        #region Generated Extensions
        public static Repo.Data.Entities.TrBpkb? GetByKey(this IQueryable<Repo.Data.Entities.TrBpkb> queryable, string agreementNumber)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<Repo.Data.Entities.TrBpkb> dbSet)
                return dbSet.Find(agreementNumber);

            return queryable.FirstOrDefault(q => q.AgreementNumber == agreementNumber);
        }

        public static ValueTask<Repo.Data.Entities.TrBpkb?> GetByKeyAsync(this IQueryable<Repo.Data.Entities.TrBpkb> queryable, string agreementNumber)
        {
            if (queryable is null)
                throw new ArgumentNullException(nameof(queryable));

            if (queryable is DbSet<Repo.Data.Entities.TrBpkb> dbSet)
                return dbSet.FindAsync(agreementNumber);

            var task = queryable.FirstOrDefaultAsync(q => q.AgreementNumber == agreementNumber);
            return new ValueTask<Repo.Data.Entities.TrBpkb?>(task);
        }

        #endregion

    }
}
