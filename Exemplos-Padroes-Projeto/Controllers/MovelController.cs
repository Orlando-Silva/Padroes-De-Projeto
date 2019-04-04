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
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        [Route("Edit/{id?}")]
        public IActionResult Edit(int? id)
        {
            IEnumerable<SelectListItem> values = from EstiloEnum e in Enum.GetValues(typeof(EstiloEnum))
                                                 select new SelectListItem
                                                 {
                                                     Text = e.ToString(),
                                                     Value = Convert.ToInt32(e).ToString(),
                                                 };
            ViewBag.EstiloLista = new SelectList(values, "Value", "Text");
            Casa casa;
            if (id != null)
            {
                casa = context.Casas.Include(m => m.Moveis).Where(m => m.Id == id).First();
            }
            else
            {
                casa = new Casa();
            }
            return View(casa);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int? id, [FromForm] Casa casa)
        {
            if (casa.Id == id)
            {
                context.Attach(casa);
                context.SaveChanges();
            }
            return View("Index");
        }

        [HttpPost]
        [Route("Salvar/{Id}")]
        public IActionResult Salvar(int? Id, [FromForm]Casa casa)
        {
            if(casa.Id == Id)
            {
                context.Attach(casa);
                context.SaveChanges();
            }else if(casa.Id == 0 && Id == null)
            {
                context.Add(casa);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]        
        public IActionResult CriarMovel(int CasaId)
        {
            Casa casa = context.Casas.Find(CasaId);
            string MovelStr = Request.Form["CasaCriarId"].ToString();
            int MovelID = 0;
            if(int.TryParse(MovelStr, out MovelID))
            {
                MovelEnum movelEnum
                    = (MovelEnum)Enum.ToObject(typeof(MovelEnum), MovelID);
                var factory = MovelAbstractFactory.CriarInstancia(casa.Estilo);
                Movel movel = factory.CriarMovel(movelEnum);
                casa.Moveis.Add(movel);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
