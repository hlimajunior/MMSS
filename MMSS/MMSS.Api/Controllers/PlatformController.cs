using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MMSS.Api.Models;

namespace MMSS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlatformController : ControllerBase
    {
        public List<Platform> Platforms = new List<Platform>()
        {
            new Platform() {Id = 1,Name = "Amazon"},
            new Platform() {Id = 2,Name = "YouTube"},
            new Platform() {Id = 3,Name = "Netflix"},
            new Platform() {Id = 4,Name = "TV"},
            new Platform() {Id = 5,Name = "Disney+"},
        };

        public PlatformController() { }        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Platforms);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var plat = Platforms.FirstOrDefault(e => e.Id == id);
            if (plat == null) return BadRequest("A plataforma não foi encontrada.");

            return Ok(plat);
        }
    }
}