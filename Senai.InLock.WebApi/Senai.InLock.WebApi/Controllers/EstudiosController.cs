using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Repositories;

namespace Senai.InLock.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {
        EstudioRepository estudioRepository = new EstudioRepository();

        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(estudioRepository.Listar());
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Estudios estudio = estudioRepository.BuscarPorId(id);
                if (estudio == null)
                    return NotFound();
                return Ok(estudio);
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult Cadastrar(Estudios estudio)
        {
            try
            {
                estudioRepository.Cadastrar(estudio);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                if (estudioRepository.BuscarPorId(id) == null)
                    return NotFound();
                estudioRepository.Deletar(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }


    }
}