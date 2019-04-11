using ExemplosPadrõesProjeto.Models.Moveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPadroesProjeto.Models.Moveis.Gotico
{
    public class CadeiraGotica : Cadeira
    {
        public CadeiraGotica() : base("Cadeira Gotica")
        {
            this.URL = "https://i.pinimg.com/474x/e6/8e/be/e68ebe0be0e223a6c28189163587a81a--throne-chair-victorian-gothic.jpg";
        }
    }
}
