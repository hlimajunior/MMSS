using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MMSS.Api.Models;

namespace MMSS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShowTypeController : ControllerBase
    {
        public List<ShowType> ShowTypes = new List<ShowType>()
        {
            new ShowType() {Id = 1, Name = "Filme"},
            new ShowType() {Id = 2, Name = "Série"},
            new ShowType() {Id = 3, Name = "Programa de TV"}
        };

        public ShowTypeController() { }        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ShowTypes);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var st = ShowTypes.FirstOrDefault(e => e.Id == id);
            if (st == null) return BadRequest("O tipo de programa não foi encontrado.");

            return Ok(st);
        }
    }
}