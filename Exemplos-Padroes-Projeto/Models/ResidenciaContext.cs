//  ResidenciaContext.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
using Microsoft.EntityFrameworkCore;
namespace ExemplosPadrõesProjeto.Models
{
    public class ResidenciaContext : DbContext
    {
        public ResidenciaContext()
        {
        }
        public ResidenciaContext(DbContextOptions<ResidenciaContext> options)
            : base(options)
        { }

        public DbSet<Moveis.Movel> Moveis { get; set; }
        public DbSet<Moveis.MesaBarroca> MesasBarrocas { get; set; }
        public DbSet<Moveis.MesaFuturista> MesasFuturistas { get; set; }
        public DbSet<Moveis.Barroco.CadeiraBarroca> CadeirasBarrocas { get; set; }
        public DbSet<Moveis.CadeiraFuturista> CadeirasFuturistas { get; set; }


        public DbSet<Casa> Casas { get; set; }
    }
}
