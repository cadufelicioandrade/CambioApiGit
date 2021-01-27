using System;
using System.Collections.Generic;
using System.Text;

namespace CambioBank.Domain.Dtos
{
    public class FilaDto
    {
        public FilaDto()
        {

        }

        public string Moeda { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Fim { get; set; }

    }
}
