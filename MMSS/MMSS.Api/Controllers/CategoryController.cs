using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MMSS.Api.Models;

namespace MMSS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        public List<Category> Categories = new List<Category>()
        {
            new Category() {Id = 1,Name = "Drama"},
            new Category() {Id = 2,Name = "Musical"},
            new Category() {Id = 3,Name = "Comédia"},
            new Category() {Id = 4,Name = "Terror"},
            new Category() {Id = 5,Name = "Policial"},
            new Category() {Id = 6,Name = "Ação"},
            new Category() {Id = 7,Name = "SciFi"}
        };

        public CategoryController() { }        

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Categories);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cat = Categories.FirstOrDefault(e => e.Id == id);
            if (cat == null) return BadRequest("A categoria não foi encontrada.");

            return Ok(cat);
        }
    }
}