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
    public class ConclusaoController : BaseController
    {
        private readonly AppDbContext _context;

        public ConclusaoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ConclusaoController
        public async Task<IActionResult> Index()
        {
            var conclusao = await _context.Conclusao
                .Include(c => c.Resultado)
                   .ToListAsync();
            return View(conclusao);
        }

        // GET: ConclusaoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConclusaoController/Create
        public IActionResult Create(int ocorrenciaId)
        {
            ViewBag.OcorrenciaId = ocorrenciaId;
            ViewBag.ResultadoId = new SelectList(_context.Resultado, "ResultadoId", "NomeResultado");

            return View();
        }

        // POST: ConclusaoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Conclusao conclusao, int ocorrenciaId)
        {
            var userId = User.Identity.Name.Split("\\")[1];
            try
            {
                conclusao.OcorrenciaId = ocorrenciaId;
                _context.Add(conclusao);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Conclusão Adicionada Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencias");
            }
            catch (Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Adicionar Conclusão!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: ConclusaoController/Edit/5
        public async Task<IActionResult> Edit(int? id, int ocorrenciaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.ConclusaoId = id;
            ViewBag.OcorrenciaId = ocorrenciaId;

            var conclusao = await _context.Conclusao.FindAsync(id);

            ViewBag.ResultadoId = new SelectList(_context.Resultado, "ResultadoId", "NomeResultado");

            return View(conclusao);
        }

        // POST: ConclusaoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Conclusao conclusao, int ocorrenciaId)
        {
            if (id != conclusao.ConclusaoId)
            {
                return NotFound();
            }

            try
            {
                _context.Update(conclusao);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Conclusão Alterada Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencias");
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Alterar Conclusão!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: ConclusaoController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conclusao = await _context.Conclusao
                .Include(c => c.Resultado)
                .FirstOrDefaultAsync(m => m.ConclusaoId == id);


            if (conclusao == null)
            {
                return NotFound();
            }

            return View(conclusao);
        }

        // POST: ConclusaoController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var conclusao = await _context.Conclusao.FindAsync(id);
                _context.Conclusao.Remove(conclusao);

                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Conclusão Deletada!", notificationType: Notification.success);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                Notify(title: "OK!", message: "Erro Ao Deletar Conclusão!", notificationType: Notification.warning);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
