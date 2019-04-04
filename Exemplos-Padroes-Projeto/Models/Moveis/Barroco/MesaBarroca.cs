//  MesaBarroca.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
namespace ExemplosPadrõesProjeto.Models.Moveis.Barroco
{
    public class MesaBarroca : Mesa
    {
        /// <summary>
        /// Inicializa o objeto Mesa Barroca invocando o construtor da classe 
        /// mesa, passando como parâmetro o modelo.
        /// </summary>
        public MesaBarroca() : base("Mesa Barroca")
        {
            this.URL = "http://www.livingeventos.com.br/wp-content/uploads/2015/03/LiS3-500x500.jpg";
        }
    }
}
