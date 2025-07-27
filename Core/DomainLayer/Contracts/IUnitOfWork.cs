﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Contracts
{
    public interface IUnitOfWork
    {
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;


        int SaveChanges();
    }
}
