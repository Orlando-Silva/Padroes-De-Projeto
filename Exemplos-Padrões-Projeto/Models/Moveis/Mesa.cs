//  Mesa.cs
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
    /// <summary>
    /// Uma classe abstrata para Mesa.
    /// </summary>
    public abstract class Mesa : Movel
    {

        public Mesa(String Modelo)
        {
            this.Modelo = Modelo;
        }

    }
}
