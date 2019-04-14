using System;
using ExemplosPadrõesProjeto.Models.Moveis;
using Xunit;
using ExemplosPadrõesProjeto.Models;
using ExemplosPadrõesProjeto.Models.Moveis.Barroco;
using ExemplosPadrõesProjeto.Models.Moveis.Steampunk;

namespace Exemplos_Padrões_Projeto_Teste
{
    public class UnitTestAbstractFactory
    {
        [Fact]
        public void TestCriarBarroco()
            {
            MovelAbstractFactory factory = MovelAbstractFactory.CriarInstancia(EstiloEnum.Barroco);
            Movel mesa = factory.CriarMovel(MovelEnum.Mesa);
            Assert.IsType<MesaBarroca>(mesa);
            }

        [Fact]
        public void TestCriarFuturista()
        {
            MovelAbstractFactory factory = MovelAbstractFactory.CriarInstancia(EstiloEnum.Futurista);
            Movel cadeira = factory.CriarMovel(MovelEnum.Cadeira);
            Assert.IsType<CadeiraFuturista>(cadeira);
            Movel mesa = factory.CriarMovel(MovelEnum.Mesa);
            Assert.IsType<MesaFuturista>(mesa);
        }

        [Fact]
        public void TestCriarSteampunk()
        {
            MovelAbstractFactory factory = MovelAbstractFactory.CriarInstancia(EstiloEnum.Steampunk);
            Movel cadeira = factory.CriarMovel(MovelEnum.Cadeira);
            Assert.IsType<CadeiraSteampunk>(cadeira);
            Movel mesa = factory.CriarMovel(MovelEnum.Mesa);
            Assert.IsType<MesaSteampunk>(mesa);
        }
    }
}
