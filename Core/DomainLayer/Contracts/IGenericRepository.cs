using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface IGenericRepository<TEntity>
    {
        public void Add(TEntity entity);

        public void Update(TEntity entity);

        public void Delete(TEntity entity);

        public IEnumerable<TEntity> GetAll();

        public TEntity? GetById(int id);

    }
}
