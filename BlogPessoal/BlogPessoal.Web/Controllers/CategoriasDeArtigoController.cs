using BlogPessoal.Web.Data.Contexto;
using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogPessoal.Web.Controllers
{
    public class CategoriasDeArtigoController : Controller
    {
        private BlogPessoalContexto _ctx = new BlogPessoalContexto();

        // GET: CategoriasDeArtigo
        public ActionResult Index()
        {
            var categoria = _ctx.CategoriaDeArtigos
                 .OrderBy(t => t.Nome)
                 .ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                _ctx.CategoriaDeArtigos.Add(categoria);
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var categoria = _ctx.CategoriaDeArtigos.Find(id);
            if (categoria == null)
                return HttpNotFound();
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Edit(CategoriaDeArtigo categoria)
        {
            if (ModelState.IsValid)
            {
                _ctx.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                _ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }
    }
}