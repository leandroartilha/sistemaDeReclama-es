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
    public class TarefasController : BaseController
    {

        private readonly AppDbContext _context;

        public TarefasController(AppDbContext context)
        {
            _context = context;
        }
        // GET: TarefasController
        public async Task<IActionResult> Index()
        {
            var tarefas = await _context.Tarefa
                .Include(t => t.DiasPrazo)
                .Include(t => t.Usuario)
                .ToListAsync();
            return View(tarefas);
        }

        // GET: TarefasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TarefasController/Create
        public IActionResult Create(int ocorrenciaId)
        {

            ViewBag.OcorrenciaId = ocorrenciaId;
            ViewBag.DiasPrazoId = new SelectList(_context.DiasPrazo, "DiasPrazoId", "NomeDiasPrazo");
            ViewBag.UsuarioId = new SelectList(_context.Usuario, "UsuarioId", "NomeUsuario");

            return View();
        }

        // POST: TarefasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tarefa tarefa, int ocorrenciaId)
        {
            try
            {
                tarefa.OcorrenciaId = ocorrenciaId;
                _context.Add(tarefa);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Tarefa Adicionada Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencias");
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Adicionar Tarefa!", notificationType: Notification.success);
                return View();
            }

        }

        // GET: TarefasController/Edit/5
        public async Task<IActionResult> Edit(int? id, int ocorrenciaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.TarefaId = id;
            ViewBag.OcorrenciaId = ocorrenciaId;

            var tarefa = await _context.Tarefa
                .Include(e => e.DiasPrazo)
                .FirstOrDefaultAsync(o => o.TarefaId == id);

            ViewBag.DiasPrazoId = new SelectList(_context.DiasPrazo, "DiasPrazoId", "NomeDiasPrazo");
            return View(tarefa);
        }

        // POST: TarefasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tarefa tarefa, int ocorrenciaId)
        {
            if (id != tarefa.TarefaId)
            {
                return NotFound();
            }
            try
            {
                _context.Update(tarefa);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Tarefa Alterada Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencia", new { id = ocorrenciaId });
            }
            catch (Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Alterar Tarefa!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: TarefasController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarefa = await _context.Tarefa
                .Include(t => t.DiasPrazo)
                .FirstOrDefaultAsync(e => e.TarefaId == id);


            if (tarefa == null)
            {
                return NotFound();
            }

            return View(tarefa);
        }
        // POST: TarefasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var tarefa = await _context.Tarefa.FindAsync(id);
                _context.Tarefa.Remove(tarefa);

                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Tarefa Deletada Com Sucesso!", notificationType: Notification.success);
            }
            catch (Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Deletar Tarefa!", notificationType: Notification.warning);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
