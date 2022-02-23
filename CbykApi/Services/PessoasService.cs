using System.Collections.Generic;
using System.Threading.Tasks;
using Cbyk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cbyk.Interfaces;

namespace Cbyk.Services
{
    public class PessoasService : IPessoaService
    {

        private readonly Contexto _contexto;
        private readonly IPessoaService pessoaService;

        public PessoasService (Contexto contexto) {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Pessoa>> PegarTodosAsync () {
            return await _contexto.Pessoas.ToListAsync();
        }

        public async Task<Pessoa> PegarPessoaPeloIdAsync (int pessoaId) {
            Pessoa pessoa = await _contexto.Pessoas.FindAsync (pessoaId);

            return pessoa;
        }

        public async Task<Pessoa> SalvarPessoaAsync (Pessoa pessoa) {
            await _contexto.Pessoas.AddAsync (pessoa);
            await _contexto.SaveChangesAsync ();

            return pessoa;
        }

        public async Task<bool> AtualizarPessoaAsync (Pessoa pessoa) {
            bool result = false;

            try
            {
                _contexto.Pessoas.Update(pessoa);
                await _contexto.SaveChangesAsync();
                result = true;
            }
            catch (System.Exception)
            {
                //throw;
            }

            return result;
        }

        public async Task<bool> ExcluirPessoaAsync (int pessoaId) {

            bool result = false;

            try
            {
                Pessoa pessoa = await _contexto.Pessoas.FindAsync(pessoaId);
                _contexto.Remove(pessoa);
                await _contexto.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                //throw;
            }

            return result;
        }

    }
}