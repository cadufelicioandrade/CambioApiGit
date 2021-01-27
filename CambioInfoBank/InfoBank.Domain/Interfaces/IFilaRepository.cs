using CambioBank.Domain.Dtos;
using CambioBank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CambioBank.Domain.Interfaces
{
    public interface IFilaRepository : IBaseRepository<Fila> 
    {
        void AdicionarVarios(List<Fila> filas);
        Fila ObterUltimoItemAtivo();
    }
}
