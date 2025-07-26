using DomainLayer.Contracts;
using Peristance.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peristance.Data.Repositories
{
    public class GenericReposirtry<TEntity>(OrderManagementSystemDbContext _dbContext) : IGenericRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)=>_dbContext.Add(entity!);
      

        public void Delete(TEntity entity)=> _dbContext.Remove(entity!);


        public IEnumerable<TEntity> GetAll()
        {
           return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity? GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        public void Update(TEntity entity)=> _dbContext.Update(entity!);
       
    }
}
