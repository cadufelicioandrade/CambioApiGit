using CambioBank.Data.Context;
using CambioBank.Domain.Interfaces;
using CambioBank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CambioBank.Data.Repository
{
    public class FilaRepository : BaseRepository<Fila>, IFilaRepository
    {
        private readonly CambioBankContext _infoBankContext;

        public FilaRepository(CambioBankContext infoBankContext) : base(infoBankContext)
        {
            _infoBankContext = infoBankContext;
        }

        public void AdicionarVarios(List<Fila> filas)
        {
            try
            {
                _infoBankContext.Filas.AddRange(filas);
                _infoBankContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Fila ObterUltimoItemAtivo()
        {
            try
            {
                var itemFila = _infoBankContext.Filas
                                        .Where(f => f.EstaNaFila)
                                        .OrderByDescending(f => f.Id)
                                        .FirstOrDefault();

                return itemFila;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
