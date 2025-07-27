using DomainLayer.Contracts;
using Peristance.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peristance.Data.Repositories
{
    public class UnitOfWork(OrderManagementSystemDbContext _dbContext) : IUnitOfWork
    {
        private readonly Dictionary<string, Object> _repositories = [];
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            var typeName = typeof(TEntity).Name;
            if (_repositories.ContainsKey(typeName))
            {
                return (IGenericRepository<TEntity>)_repositories[typeName];
            }
            else
            {
                var Repo = new GenericReposirtry<TEntity>(_dbContext);
                _repositories.Add(typeName, Repo);
                return Repo;
            }

        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
