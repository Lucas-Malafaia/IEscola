using IEscola.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IEscola.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private List<Disciplina> DisciplinaList = new List<Disciplina>
        {
            new Disciplina (1, "Matematica", "Disciplina que visa ensinar métodos aritimeticos" ),
            new Disciplina (2, "Portugues", "Disciplina que visa ensinar o uso da lingua portuguesa")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Disciplina>> Get()
        {
            return Ok(DisciplinaList);
        }
    }
}
