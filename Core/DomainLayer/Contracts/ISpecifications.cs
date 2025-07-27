using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface ISpecifications<TEntity> where TEntity : class
    {
        public Expression<Func<TEntity, bool>>? Crietria { get; }
        public List<Expression<Func<TEntity,object>>> IncludeExpressions {  get; }
    }
}
