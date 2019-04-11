//  FactoryFuturista.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
using ExemplosPadroesProjeto.Models.Moveis;
using ExemplosPadroesProjeto.Models.Moveis.Futurista;

namespace ExemplosPadrõesProjeto.Models.Moveis
{
    public class MovelFuturistaFactory : MovelAbstractFactory
    {
        protected override Cadeira CriarCadeira()
        {
            throw new NotImplementedException();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaFuturista();
        }

        protected override Armario CriarArmario()
        {
            return new ArmarioFuturista();
        }

        protected override Sofa CriarSofa()
        {
            return new SofaFuturista();
        }
    }
}
