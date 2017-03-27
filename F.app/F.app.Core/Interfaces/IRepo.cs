using F.app.Core.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Interfaces
{
    public interface IRepo<TEntity, in Tkey> where TEntity: IEntity<Tkey>
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(Tkey id);
        //TEntity Single(Expression<Func<TEntity, bool>> predicate, params Expression<Func<T, object>>[] includes);
        IList<TEntity> List(Expression<Func<TEntity, bool>> predicate=null, Func<TEntity, string> order = null);
    }
}
