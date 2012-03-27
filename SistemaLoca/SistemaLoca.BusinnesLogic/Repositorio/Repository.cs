using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using SistemaLoca.BusinnesLogic.Model;


namespace SistemaLoca.BusinnesLogic.Repositorio.ControleAcervo
{
    //Padrão de implementação de repositório
    //http://www.asp.net/entity-framework/tutorials/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application

    public class Repository<TEntity> where TEntity : class
    {
        #region Attributes

        internal SistemaLocaDBContext _dbContext;

        internal DbSet<TEntity> _dbSet;

        #endregion

        #region Constructor

        public Repository(SistemaLocaDBContext dbContext_)
        {
            this._dbContext = dbContext_;
            this._dbSet = this._dbContext.Set<TEntity>();
        }

        #endregion

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter_ = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy_ = null,
            string includeProperties_ = "")
        {
            IQueryable<TEntity> query = this._dbSet;

            if (filter_ != null)
            {
                query = query.Where(filter_);
            }

            foreach (var includeProperty in includeProperties_.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy_ != null)
            {
                return orderBy_(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var entityCollection = from e in _dbSet
                                select e;

            return entityCollection;
        }

        //pesquisa pelo campo chave primaria
        public virtual TEntity GetByID(object id_)
        {
            return this._dbSet.Find(id_);
        }

        //grava um objeto 
        public virtual void Insert(TEntity entity_)
        {
            this._dbSet.Add(entity_);
        }

        public virtual void Delete(object id_)
        {
            TEntity entityToDelete = this._dbSet.Find(id_);
            this.Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete_)
        {
            if (this._dbContext.Entry(entityToDelete_).State == EntityState.Detached)
            {
                this._dbSet.Attach(entityToDelete_);
            }

            this._dbSet.Remove(entityToDelete_);
        }

        public virtual void Update(TEntity entityToUpdate_)
        {
            this._dbSet.Attach(entityToUpdate_);
            this._dbContext.Entry(entityToUpdate_).State = EntityState.Modified;
        }

    }
}