using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectFullS.Models;
using projectFullS.Data;

namespace projectFullS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {    

    
        public readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context  = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _context.Events.FirstOrDefault(x=> x.EventId == id);     
        }

        [HttpPost]
        public string Post()
        {
            return "post";
        }

        [HttpPut]
        public string Put()
        {
            return "put";
        }

        [HttpDelete]
        public string Delete())
        {
            return "delete";
        }
    }
}
