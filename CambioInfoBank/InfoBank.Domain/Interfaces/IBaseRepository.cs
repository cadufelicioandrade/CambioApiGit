using System;
using System.Collections.Generic;
using System.Text;

namespace CambioBank.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Adicionar(TEntity entity);
        void Alterar(TEntity entity);
        void Remover(TEntity entity);
        TEntity ObterPorId(int id);
        List<TEntity> ObterTodos();

    }
}
