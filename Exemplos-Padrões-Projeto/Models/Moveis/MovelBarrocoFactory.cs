//  FactoryBarroco.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
namespace ExemplosPadrõesProjeto.Models.Moveis
{
    public class MovelBarrocoFactory : MovelAbstractFactory
    {
        protected override Cadeira CriarCadeira()
        {
            throw new NotImplementedException();
        }

        protected override Mesa CriarMesa()
        {
            return new MesaBarroca();
        }
    }
}
