using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cbyk.Models;

namespace Cbyk.Interfaces
{
    public interface IPessoaService 
    {
        public Task<IEnumerable<Pessoa>> PegarTodosAsync();
        public Task<Pessoa> PegarPessoaPeloIdAsync(int pessoaId);
        public Task<Pessoa> SalvarPessoaAsync(Pessoa pessoa);
        public Task<bool> AtualizarPessoaAsync(Pessoa pessoa);
        public Task<bool> ExcluirPessoaAsync(int pessoaId);
    }
}
