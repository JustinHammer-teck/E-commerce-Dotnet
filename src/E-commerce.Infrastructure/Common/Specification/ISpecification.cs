using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Infrastructure.Common.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Where { get; }
        List<Expression<Func<T , object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnable { get; }


    }
}
