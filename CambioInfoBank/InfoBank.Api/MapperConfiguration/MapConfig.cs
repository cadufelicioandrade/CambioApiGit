using AutoMapper;
using CambioBank.Domain.Dtos;
using CambioBank.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CambioBank.Domain.MapperConfiguration
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            CreateMap<FilaDto, Fila>()
                .ForMember(dest => dest.DataFim, origem => origem.MapFrom(src => src.Data_Fim))
                .ForMember(dest => dest.DataInicio, origem => origem.MapFrom(src => src.Data_Inicio))
                .ForMember(dest => dest.Moeda, origem => origem.MapFrom(src => src.Moeda));
        }
    }
}
