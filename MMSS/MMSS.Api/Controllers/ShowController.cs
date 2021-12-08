using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MMSS.Api.Models;

namespace MMSS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShowController : ControllerBase
    {
        public List<Show> Shows = new List<Show>()
        {
            new Show() {
                Id = 1,
                Title = "The Big Bang Theory",
                Year = 2007,
                ShowTypeId = 2,
                Briefing = "Os melhores amigos e companheiros de apartamento Leonard e Sheldon são físicos que trabalham no Instituto Tecnológico da Califórnia (Caltech) e são capazes de explicar a todo mundo mais do que gostariam de saber sobre física quântica, mas superar as situações sociais mais básicas, especialmente aquelas envolvendo mulheres, os deixa completamente perdidos. Que sorte quando a gostosa garçonete/atriz aspirante Penny se muda para o apartamento ao lado. Wolowitz e Koothrappali, também da Caltech, são vistos frequentemente passando o tempo com Leonard e Sheldon. Será que os mundos vão se colidir? Será que Einstein teorizava na floresta?"
            },
            new Show() {
                Id = 2,
                Title = "Batman: O Cavaleiro das Trevas",
                Year = 2008,
                ShowTypeId = 1,
                Briefing = "Com a ajuda de Jim Gordon e Harvey Dent, Batman tem mantido a ordem na cidade de Gotham. Mas um jovem e anárquico criminoso conhecido como Coringa ganha força e decide instaurar um verdadeiro caos na cidade. O justiceiro será testado psicologicamente e fisicamente como nunca fora antes em um confronto bastante pessoal. Cabe a Batman encontrar uma maneira de deter o sádico vilão antes que mais vidas sejam perdidas."
            },
            new Show() {
                Id = 3,
                Title = "O Código DaVinci",
                Year = 2006,
                ShowTypeId = 1,
                Briefing = "Um assassinato no museu do Louvre em Paris e pistas enigmáticas em alguns dos quadros mais famosos de Leonardo DaVinci levam à descoberta de um mistério religioso. Por mais de dois mil anos, uma sociedade secreta guarda informações que, se descobertas, poderiam comprometer o cristianismo. Robert Langdon, um professor especialista em simbologia e história, se envolve na investigação."
            },
            new Show() {
                Id = 4,
                Title = "O Silêncio dos Inocentes",
                Year = 1991,
                ShowTypeId = 1,
                Briefing = "Uma jovem e talentosa agente do FBI é aconselhada pelo Dr. Hannibal Lecter, um psiquiatra brilhante e também um psicopata violento e canibal, a fim de conseguir capturar outro assassino."
            }

        };

        public ShowController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Shows);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var sh = Shows.FirstOrDefault(s => s.Id == id);
            if (sh == null) return BadRequest("O programa não foi encontrado.");

            return Ok(sh);
        }
    }
}