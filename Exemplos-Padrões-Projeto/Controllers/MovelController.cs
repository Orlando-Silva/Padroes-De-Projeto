//  EmptyClass.cs
//
//  Author:
//       Alex Pinheiro das Graças <alex.gracas>
//
//  Copyright (c) 2019 
//
//  Este arquivo não pode ser modificado, cedido ou alterado sem a permissão explicita do autor.
using System;
using System.Diagnostics;
using Exemplos_Padrões_Projeto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using ExemplosPadrõesProjeto.Models;
using ExemplosPadrõesProjeto.Models.Moveis;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;


namespace ExemplosPadrõesProjeto.Controllers
{
    public class MovelController : Controller
    {
        public MovelController(ResidenciaContext dbContext)
        {
            this.context = dbContext;
        }

        ResidenciaContext context = null;

        public IActionResult Index()
        {
            IEnumerable<Casa> lista = null;
            if (context.Casas.Count() > 0)
            {
                lista = context.Casas.ToList();
            }
            return View(lista);
        
        }

        public IActionResult Edit(int? index)
        {
            IEnumerable<SelectListItem> values = from EstiloEnum e in Enum.GetValues(typeof(EstiloEnum))
                                                 select new SelectListItem
                                                 {
                                                     Text = e.ToString(),
                                                     Value = Convert.ToInt32(e).ToString(),
                                                 };
            ViewBag.EstiloLista = new SelectList(values, "Value", "Text");
            Casa casa;
            if (index != null)
            {
                casa = context.Casas.Find(index);
            }
            else
            {
                casa = new Casa();
            }
            return View(casa);
        }

        [HttpPost]
        public IActionResult Edit(int? index, [FromForm] Casa casa)
        {
            if (casa.Id == index)
            {
                context.Attach(casa);
                context.SaveChanges();
            }
            return View("Index");
        }

        public IActionResult Salvar(int? index, Casa casa)
        {
            if(casa.Id == index)
            {
                context.Attach(casa);
                context.SaveChanges();
            }
            return View("Index");
        }

        public IActionResult CriarCasa(string Estilo)
        {
            Casa casa = new Casa((EstiloEnum)Enum.Parse(typeof(EstiloEnum), Estilo));
            return View();
        }


        public IActionResult CriarMovel(int CasaId, string Movel)
        {
            Casa casa = context.Casas.Find(CasaId);
            var factory = Models.Moveis.MovelAbstractFactory.CriarInstancia(casa.Estilo);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
