using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuitarSystem.Controllers
{
    public class GuitarrasController : Controller
    {
        private readonly Contexto _contexto;

        public GuitarrasController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View(_contexto.Guitarras.ToList());
        }

        [HttpGet]
        public IActionResult NovaGuitarra()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovaGuitarra(Guitarra guitarra)
        {
            if(ModelState.IsValid)
            {
                _contexto.Add(guitarra);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(guitarra);
        }

        [HttpGet]
        public IActionResult AtualizarGuitarra (int? id)
        {
            if (id == null)
                return NotFound();

            var guitarra = _contexto.Guitarras.Find(id);

            return View(guitarra);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AtualizarGuitarra (int id, Guitarra guitarra)
        {
            if (id == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                _contexto.Update(guitarra);
                _contexto.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(guitarra);
        }

        public IActionResult Detalhes (int? id)
        {
            if (id == null)
                return NotFound();

            var guitarra = _contexto.Guitarras.FirstOrDefault(x => x.GuitarraID == id);

            return View(guitarra);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null)
                return NotFound();

            var guitarra = _contexto.Guitarras.FirstOrDefault(x => x.GuitarraID == id);

            return View(guitarra);
        }

        [HttpPost, ActionName("Excluir")]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmarExclusao(int id)
        {
            if (id == null)
                return NotFound();

            var guitarra = _contexto.Guitarras.FirstOrDefault(x => x.GuitarraID == id);
            _contexto.Remove(guitarra);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}