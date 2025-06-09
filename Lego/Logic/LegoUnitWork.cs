using Lego.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego.Logic
{
    internal class LegoUnitWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private readonly Dictionary<Type, object> _repositories = [];
        private IDbContextTransaction? _transaction;

        public LegoUnitWork(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!_repositories.TryGetValue(type, out var repository))
            {
                repository = new LegoRepository<T>(_context);
                _repositories[type] = repository;
            }

            return (IRepository<T>)repository;
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return GetRepository<T>().GetAll();
        }




        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
