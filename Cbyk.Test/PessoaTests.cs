using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cbyk.Models;
using Cbyk.Interfaces;
using Cbyk.Controllers;
using Xunit;

namespace Cbyk.Test
{
    public class PessoaTests
    {
        private PessoasController pessoasController;

        public PessoaTests()
        {
            pessoasController = new PessoasController(new Mock<IPessoaService>().Object);
        }

        [Fact]
        public async void Get_PegarTodosAsync()
        {
            var exception = Assert.ThrowsAsync<Exception>(() => pessoasController.PegarTodosAsync());
            Assert.Equal("Nenhuma pessoa foi encontrada!", exception.Exception.Message);
        }

    }
}
