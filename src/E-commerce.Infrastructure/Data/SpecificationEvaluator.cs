using E_commerce.Domain.Entities;
using E_commerce.Infrastructure.Common.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery
            , ISpecification<TEntity> spec)
        {
            var query = inputQuery;

            if (spec.Where != null)
            {
                query = query.Where(spec.Where);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}
