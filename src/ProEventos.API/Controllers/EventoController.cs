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
                Local = "Campo Grande MS",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Trabalhando com Angular 11 + .net Core 5",
                QtdPessoas = 250,
                Lote = "Primeiro Lote",
                ImagemUrl = "Foto.png"
           },
           new Evento(){
                EventoId = 2,
                Local = "Campo Grande MS",
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                Tema = "Trabalhando com Angular 12 + .net Core 6",
                QtdPessoas = 350,
                Lote = "Segundo Lote",
                ImagemUrl = "Foto1.png"
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
        public Evento GetById(int id)
        {
           return _evento.Where(e => e.EventoId == id).FirstOrDefault();
        }
    }
}
