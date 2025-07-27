using DomainLayer.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peristance
{
   static class specificationEvalutor
    {
        //create Query
        public static IQueryable<TEntity> CreateQuery<TEntity>(IQueryable<TEntity>InputQuery,ISpecifications<TEntity> specifications )where TEntity : class
        {
            var Query=InputQuery;
            if(specifications.Crietria is not null)
            {
                Query = Query.Where(specifications.Crietria);
            }
            if(specifications.IncludeExpressions is not null && specifications.IncludeExpressions.Count > 0)
            {
                //foreach( var expression in specifications.IncludeExpressions )
                //{
                //    Query = Query.Include(expression);
                //}

                Query=specifications.IncludeExpressions.Aggregate(Query,(CurrentQuery,IncludeExp)=>CurrentQuery.Include(IncludeExp));
            }
            return Query;
        }
    }

}
