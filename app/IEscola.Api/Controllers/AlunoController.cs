using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using IEscola.Domain.Entities;
using System;
using System.Linq;

namespace IEscola.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private List<Aluno> alunoList = new List<Aluno>{
            new Aluno (1, "Lucas", new DateTime(1990,28,09), 123456789,'M'),
            new Aluno (2, "Andressa",  new DateTime(1993,27,02), 1234432323, 'F')
        };

        //GET: api/<professorController>
        [HttpGet]
        public ActionResult<IEnumerable<AlunoController>> Get()
        {
            return Ok(alunoList);
        }


        //GET: api/<professorController>/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
                return BadRequest("Id Pesquisado inválido ou não existente");

            var aluno = alunoList.FirstOrDefault(a => a.Id == id);
            if (aluno != null)
                if (aluno.Sexo == 'M')
                {
                    aluno.Tratamento = Constantes.TratamentoMasculino;
                }
                else
                {
                    aluno.Tratamento = Constantes.TratamentoFeminino;
                }

            return Ok((aluno));
        }


        // POST /api/<AlunoController>
        [HttpPost]
        public IActionResult Post([FromBody] Aluno aluno)
        {
            return Ok(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Aluno aluno)
        {
            return Ok();
        }

        // DELETE api/<AlunoController>/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
