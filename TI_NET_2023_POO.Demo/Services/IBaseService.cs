using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_POO.Demo.Models;

namespace TI_NET_2023_POO.Demo.Services
{
    public interface IBaseService<TKey,TEntity> where TEntity : class
    {
        TEntity Add(TEntity e);

        List<TEntity> GetAll();

        TEntity Get(Func<TEntity, bool> predicate);

        bool Update(TKey id, TEntity e);

        bool Delete(TKey id);
    }
}
