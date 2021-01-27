using CambioBank.Data.Context;
using CambioBank.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CambioBank.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private CambioBankContext _infoBankContext;

        public BaseRepository(CambioBankContext infoBankContext)
        {
            _infoBankContext = infoBankContext;
        }

        public void Adicionar(TEntity entity)
        {
            try
            {
                _infoBankContext.Set<TEntity>().Add(entity);
                _infoBankContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Alterar(TEntity entity)
        {
            try
            {
                _infoBankContext.Set<TEntity>().Update(entity);
                _infoBankContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TEntity ObterPorId(int id)
        {
            try
            {
                return _infoBankContext.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<TEntity> ObterTodos()
        {
            try
            {
                return _infoBankContext.Set<TEntity>()
                                        .AsNoTracking()
                                        .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remover(TEntity entity)
        {
            try
            {
                _infoBankContext.Set<TEntity>().Remove(entity);
                _infoBankContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
