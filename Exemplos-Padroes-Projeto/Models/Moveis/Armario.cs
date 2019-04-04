using ExemplosPadrõesProjeto.Models.Moveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPadroesProjeto.Models.Moveis
{
    public abstract class Armario : Movel
    {

        public Armario(String modelo)
        {
            this.Modelo = modelo;
        }
        
    }
}
