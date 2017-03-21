using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Infrastructure
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        #region Async Repo
        private readonly MongoDatabase _dbContext;

        public GenericRepository(MongoDatabase dbContext)
        {
            _dbContext = dbContext;
        }

        //public int Add(TEntity t)
        //{
        //    // add 
        //}

        //public async Task<int> RemoveAsync(TEntity t)
        //{
        //    // remove
        //}

        //public async Task<int> UpdateAsync(TEntity t)
        //{
        //    //update
        //}

        //public async Task<int> CountAsync()
        //{
        //    //count
        //}

        //public async Task<List<TEntity>> GetAllAsync()
        //{
        //    //get all
        //}

        //public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
        //{
        //    //find 1
        //}
        //public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> match)
        //{
        //    //find first
        //}
        //public async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
        //{
        //    //findall with expression
        //}
        #endregion
    }
}
