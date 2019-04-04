//  Cadeira.cs
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
    public abstract class Cadeira : Movel
    {

        public Cadeira(String Modelo)
        {
            this.Modelo = Modelo;
        }

    }
}
