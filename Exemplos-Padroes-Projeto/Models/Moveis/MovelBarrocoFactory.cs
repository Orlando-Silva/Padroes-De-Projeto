//  FactoryBarroco.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using ExemplosPadroesProjeto.Models.Moveis;
using ExemplosPadrõesProjeto.Models.Moveis.Barroco;
using ExemplosPadroesProjeto.Models.Moveis.Barroco;
using System;
namespace ExemplosPadrõesProjeto.Models.Moveis
{
    public class MovelBarrocoFactory : MovelAbstractFactory
    {
        protected override Cadeira CriarCadeira()
        {
            return new CadeiraBarroca();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaBarroca();
        }

        protected override Armario CriarArmario()
        {
            return new ArmarioBarroco();
        }

        protected override Sofa CriarSofa()
        {
            throw new NotImplementedException();
        }
    }
}
