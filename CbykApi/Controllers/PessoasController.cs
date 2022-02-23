using System.Collections.Generic;
using System.Threading.Tasks;
using Cbyk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cbyk.Interfaces;
using Cbyk.Services;

namespace Cbyk.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class PessoasController : ControllerBase {
        
        private IPessoaService _pessoaService;

        public PessoasController(IPessoaService pessoaService) {
            _pessoaService = pessoaService;
        }

        [HttpGet]
        public async Task<IEnumerable<Pessoa>> PegarTodosAsync () {
            var result = await _pessoaService.PegarTodosAsync();

            if (result == null)
                throw new System.Exception("Nenhuma pessoa foi encontrada!");
            
            return result;
        }

        [HttpGet ("{pessoaId}")]
        public async Task<ActionResult<Pessoa>> PegarPessoaPeloIdAsync (int pessoaId) {

            Pessoa pessoa = await _pessoaService.PegarPessoaPeloIdAsync(pessoaId);

            if (pessoa == null)
            {
                //throw new System.Exception("Nenhuma pessoa foi encontrada!");
                return NotFound ();
            }

            return pessoa;
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> SalvarPessoaAsync (Pessoa pessoa) {
            await _pessoaService.SalvarPessoaAsync(pessoa);

            return Ok ();
        }

        [HttpPut]
        public async Task<ActionResult> AtualizarPessoaAsync (Pessoa pessoa) {
            if (await _pessoaService.AtualizarPessoaAsync(pessoa))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
    }

        [HttpDelete ("{pessoaId}")]
        public async Task<ActionResult> ExcluirPessoaAsync (int pessoaId) {
            if (await _pessoaService.ExcluirPessoaAsync(pessoaId))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}