using System;
using ExemplosPadrõesProjeto.Models.Moveis;
using Xunit;
using ExemplosPadrõesProjeto.Models;

namespace Exemplos_Padrões_Projeto_Teste
{
    public class UnitTestAbstractFactory
    {
        [Fact]
        public void TestCriarBarroco()
            {
            MovelAbstractFactory factory = MovelAbstractFactory.CriarInstancia(EstiloEnum.Barroco);
            Movel mesa = factory.CriarMovel(MovelEnum.Mesa);
            Assert.IsType(typeof(MesaBarroca), mesa);
            }

        [Fact]
        public void TestCriarFuturista()
        {
            MovelAbstractFactory factory = MovelAbstractFactory.CriarInstancia(EstiloEnum.Futurista);
            Movel cadeira = factory.CriarMovel(MovelEnum.Cadeira);
            Assert.IsType(typeof(Cadeira), cadeira);
            Movel mesa = factory.CriarMovel(MovelEnum.Mesa);
            Assert.IsType(typeof(MesaFuturista), mesa);
        }
    }
}
