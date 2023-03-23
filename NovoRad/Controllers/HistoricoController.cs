using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoRad.Context;
using NovoRad.Models;
using NovoRad.Models.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class HistoricoController : BaseController
    {

        private readonly AppDbContext _context;

        public HistoricoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: HistoricoController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Historico.ToListAsync());
        }

        // GET: HistoricoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoricoController/Create
        public IActionResult Create(int ocorrenciaId)
        {
            ViewBag.OcorrenciaId = ocorrenciaId;
            return View();
        }

        // POST: HistoricoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(Historico historico, int ocorrenciaId)
        {
            var userId = User.Identity.Name.Split("\\")[1];
            try
            {
                historico.Autor = userId;
                historico.OcorrenciaId = ocorrenciaId;
                _context.Add(historico);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Histórico Adicionado Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencia");
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Adicionar Histórico!", notificationType: Notification.success);
                return View();
            }
        }

        // GET: HistoricoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoricoController/Edit/5
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

        // GET: HistoricoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoricoController/Delete/5
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
