//  MesaFuturista.cs
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
    public class MesaFuturista : Mesa
    {
        /// <summary>
        /// Inicializa o objeto Mesa Futurista invocando o construtor da classe 
        /// mesa, passando como parâmetro o modelo.
        /// </summary>
        public MesaFuturista() : base("Mesa Futurista")
        {
            this.URL = "http://zoopcreative.com.br/zoop/images/stories/blog/zoopcreativejob-design%20de%20moveis%20futurista-mesa.jpg";
        }
    }
}
