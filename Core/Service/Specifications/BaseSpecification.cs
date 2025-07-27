using DomainLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Specifications
{
    abstract class  BaseSpecification<TEntity> : ISpecifications<TEntity> where TEntity : class
    {
        protected BaseSpecification(Expression<Func<TEntity,bool>>?CriteiaExpression)
        {
            Crietria = CriteiaExpression;
        }
        public Expression<Func<TEntity, bool>>? Crietria {  get;private set; }

        public List<Expression<Func<TEntity, object>>> IncludeExpressions { get; } = [];

        protected void AddInclude(Expression<Func<TEntity,object>> includeExpression)
        {
            IncludeExpressions.Add(includeExpression);
        }
    }
}
