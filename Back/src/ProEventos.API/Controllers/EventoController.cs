using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){             
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd//MM/yyyy"),
                ImagemURL = "Foto.png"
                },
                new Evento(){             
                EventoId = 2,
                Tema = "swagger e Postman",
                Local = "Minas Gerais",
                Lote = "2º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd//MM/yyyy"),
                ImagemURL = "Foto1.png"
                }
            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {     
            return _evento; 
        }
          [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {     
            return _evento.Where(evento => evento.EventoId == id); 
        }
        [HttpPost]
        public string Post()
        {     
            return "Exemplo de POST";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {     
            return $"Exemplo de PUT com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {     
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
