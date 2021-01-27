using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CambioBank.Domain.Dtos;
using CambioBank.Domain.Interfaces;
using CambioBank.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CambioBank.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FilaController : ControllerBase
    {
        private readonly IFilaRepository _filaRepository;
        private readonly IMapper _mapper;

        public FilaController(IFilaRepository filaRepository,
                              IMapper mapper)
        {
            _filaRepository = filaRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult AddIntemFila([FromBody] List<FilaDto> filasDto)
        {
            try
            {

                if (filasDto.Count > 0)
                {
                    var filas = _mapper.Map<List<Fila>>(filasDto);
                    _filaRepository.AdicionarVarios(filas);

                    return Ok("Itens inseridos com sucesso!");
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<Fila> GetItemFila()
        {
            try
            {
                var fila = _filaRepository.ObterUltimoItemAtivo();

                if (fila != null)
                {
                    fila.EstaNaFila = false;
                    _filaRepository.Alterar(fila);
                    return Ok(fila);
                }

                return NotFound(null);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}