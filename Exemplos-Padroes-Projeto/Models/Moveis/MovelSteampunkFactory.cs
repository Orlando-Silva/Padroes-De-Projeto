using ExemplosPadrõesProjeto.Models.Moveis;
using ExemplosPadrõesProjeto.Models.Moveis.Steampunk;
using ExemplosPadroesProjeto.Models.Moveis.Steampunk;

namespace ExemplosPadroesProjeto.Models.Moveis
{
    public class MovelSteampunkFactory : MovelAbstractFactory
    {
        protected override Cadeira CriarCadeira()
        {
            return new CadeiraSteampunk();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaSteampunk();
        }

        protected override Armario CriarArmario()
        {
            return new ArmarioSteampunk();
        }

        protected override Sofa CriarSofa()
        {
            return new SofaSteampunk();
        }

        protected override Prateleira CriarPrateleira()
        {
            return new PrateleiraSteampunk();
        }
    }
}
