using F.app.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace F.app.Infrastructure
{
    public class GenericRepository<TEntity> : IRepo<TEntity, ObjectId> where TEntity : IEntity
    {
        private DataContext _context;
        MongoCollection<TEntity> _collection;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _collection = _context.GetCollection<TEntity>();
        }
        private IQueryable<TEntity> CreateSet()
        {
            return _collection.AsQueryable();
        }
        public virtual void Delete(TEntity entity)
        {
            try
            {
                _collection.Remove(Query<TEntity>.EQ(o => o.Id, entity.Id));
            }
            catch (Exception ex)
            {
                //NEED to handle ex
                throw ex;
            }
            
        }

        public TEntity GetById(ObjectId id)
        {
            var set = CreateSet();
            set = set.Where(x => x.Id == id);
            return set.SingleOrDefault();
        }

        public void Insert(TEntity entity)
        {
            entity.Id = ObjectId.GenerateNewId();
            try
            {
                _collection.Insert<TEntity>(entity);
            }
            catch (Exception ex)
            {
                //NEED to handle ex
                throw ex;
            }
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> predicate=null, Func<TEntity, string> order = null)
        {
            var set = CreateSet();
            if (predicate != null)
            {
                set = set.Where(predicate);
            }
            if (order != null)
            {
                return set.OrderBy(order).ToList();
            }
            return set.ToList();
        }

        public void Update(TEntity entity)
        {
            var query = Query<TEntity>.EQ(o => o.Id, entity.Id);
            var update = Update<TEntity>.Replace(entity);
            _collection.Update(query, update);
        }
    }
}

