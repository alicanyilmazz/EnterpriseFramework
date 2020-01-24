using EnterpriseFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Core.DataAccess.EntityFramework
{
    public class EntityFrameworkQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<T> _entities;

        public EntityFrameworkQueryableRepository(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Table => this.Entities;

        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }

                return _entities;
            }
        }


    }
}
