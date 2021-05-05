using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebSiteBackend.DataAccess.Abstracts.Interfaces.Generic;
using WebSiteBackend.DataAccess.Concrete.EFCore.Context;
using WebSiteBackend.Entities.Abstracts.Interfaces;

namespace WebSiteBackend.DataAccess.Concrete.EFCore.Repositories.Generic
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
       where TEntity : class, ITable, new()
    {
        private readonly WebSiteContext context;
        
        

        public GenericRepository(WebSiteContext context)
        {
            this.context = context;
        }

        public void Create(TEntity entity)
        {
            this.context.Add(entity);

        }

        public async Task CreateAsync(TEntity entity)
        {
            await this.context.AddAsync(entity);
        }

        public void Delete(int id)
        {
            var operationData = this.context.Set<TEntity>().Find(id);
            this.context.Remove(operationData);
        }

        public async Task DeleteAsync(int id)
        {
            var operationData = await this.context.Set<TEntity>().FindAsync(id);
            await Task.Run(() => this.context.Remove(id));
        }


        public List<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await this.context.Set<TEntity>().ToListAsync();
        }

        public List<TEntity> GetAllWithFilter(Expression<Func<TEntity, bool>> filter)
        {
            return this.context.Set<TEntity>().Where(filter).ToList();
        }

        public async Task<List<TEntity>> GetAllWithFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await this.context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return this.context.Set<TEntity>().FirstOrDefault(filter);
        }

        public TEntity GetByFilterAsNoTracking(Expression<Func<TEntity, bool>> filter)
        {
            return this.context.Set<TEntity>().AsNoTracking().FirstOrDefault(filter);
        }

        public async Task<TEntity> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await this.context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public void Update(TEntity entity)
        {
            this.context.Update(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(()=> this.context.Update(entity));
        }

 
    }
}
