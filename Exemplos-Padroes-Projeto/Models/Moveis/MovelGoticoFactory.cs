using ExemplosPadrõesProjeto.Models.Moveis;
using ExemplosPadroesProjeto.Models.Moveis.Gotico;

namespace ExemplosPadroesProjeto.Models.Moveis
{
    public class MovelGoticoFactory : MovelAbstractFactory
    {
        protected override Cadeira CriarCadeira()
        {
            return new CadeiraGotica();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaGotica();
        }

        protected override Armario CriarArmario()
        {
            return new ArmarioGotico();
        }

        protected override Sofa CriarSofa()
        {
            return new SofaGotico();
        }
    }
}
