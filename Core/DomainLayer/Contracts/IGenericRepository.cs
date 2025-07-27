using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);

        public void Update(TEntity entity);

        public void Delete(TEntity entity);

        public IEnumerable<TEntity> GetAll();

        public TEntity? GetById(int id);

        #region specifiactions

        public IEnumerable<TEntity> GetAll(ISpecifications<TEntity> specifications);

        public TEntity? GetById( ISpecifications<TEntity> specifications); 
        #endregion

    }
}
