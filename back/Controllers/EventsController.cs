using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectFullS.Models;

namespace projectFullS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {    

            public IEnumerable<Event> _event = new Event[]
            {   
                new Event(){
                EventId = 1,
                QtdPessoas= 2,
                Local="BH",
                DataEvent= DateTime.Now.AddDays(2).ToString(),
                Lote= "1º Lote"
                },
                new Event(){
                EventId = 2,
                QtdPessoas= 212,
                Local="SP",
                DataEvent= DateTime.Now.AddDays(2).ToString(),
                Lote= "2º Lote"
                },
            };

        public EventsController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;     
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> Get(int id)
        {
            return _event.Where(x=> x.EventId == id);     
        }

        [HttpPost]
        public string Post()
        {
            return "post";
        }
    }
}
