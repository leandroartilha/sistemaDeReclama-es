using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoRad.Context;
using NovoRad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class TriagemController : BaseController
    {
        private readonly AppDbContext _context;

        public TriagemController(AppDbContext context)
        {
            _context = context;
        }


        // GET: TriagemController
        public ActionResult Index()
        {
            var viewModelTriagem = new TriagemViewModel();
            viewModelTriagem.Ocorrencia = _context.Ocorrencia
                .Include(o => o.Status)
                .Include(o => o.Ambiente)
                .Include(o => o.Classificacao);
            viewModelTriagem.Usuario = _context.Usuario;

            //var triagem = await _context.Ocorrencia
            //    .Include(o => o.Ambiente)
            //    .Include(o => o.Status)
            //    .Include(o => o.Classificacao)
            //    .ToListAsync();
           
            ViewBag.UsuarioId = new SelectList(_context.Usuario, "UsuarioId", "NomeUsuario");

            return View(viewModelTriagem);
        }

        // GET: TriagemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TriagemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TriagemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TriagemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TriagemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TriagemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TriagemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
