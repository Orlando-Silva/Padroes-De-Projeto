//  EmptyEnumeration.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
using System.ComponentModel;

namespace ExemplosPadrõesProjeto.Models.Moveis
{
    public enum EstiloEnum
    {
        [DisplayName("Futurista")]
            Futurista,
        [DisplayName("Barroco")]
            Barroco,
        [DisplayName("Gotico")]
            Gotico,
        [DisplayName("Steampunk")]
            Steampunk
    }
}
