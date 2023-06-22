using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Services
{
    public abstract class BaseService<TKey, TEntity> : IBaseService<TKey, TEntity> where TEntity : class
    {
        public TEntity Add(TEntity e)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(TKey id, TEntity e)
        {
            throw new NotImplementedException();
        }
    }
}
