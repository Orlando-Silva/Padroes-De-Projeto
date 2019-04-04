//  Casa.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
using System.Collections.Generic;
using ExemplosPadrõesProjeto.Models.Moveis;

namespace ExemplosPadrõesProjeto.Models
{
    public class Casa
    {
        public Casa()
        {
        }

        public Casa(EstiloEnum estilo)
        {
            this.Estilo = estilo;
        }

        public List<Movel> Moveis { get; set; } = new List<Movel>();

        public int Id { get; set; }


        public MovelAbstractFactory Factory {
            get
            {
                return MovelAbstractFactory.CriarInstancia(this.Estilo);
            }
        }

        public EstiloEnum Estilo { get; set; }
    }
}
