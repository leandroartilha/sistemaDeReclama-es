using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class EnderecoController : BaseController
    {

        private readonly AppDbContext _context;

        public EnderecoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: EnderecoController
        public async Task<IActionResult> Index()
        {
            var enderecos = await _context.Endereco.ToListAsync();
            return View(enderecos);
        }

        // GET: EnderecoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EnderecoController/Create
        public IActionResult Create(int envolvidoId)
        {
            ViewBag.EnvolvidoId = envolvidoId;
            return View();
        }

        // POST: EnderecoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Endereco endereco, int envolvidoId)
        {
            try
            {
                endereco.EnvolvidoId = envolvidoId;
                _context.Add(endereco);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Endereço Adicionado Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencias");
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Adicionar Endereço!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: EnderecoController/Edit/5
        public async Task<IActionResult> Edit(int? id, int envolvidoId)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.EnderecoId = id;
            ViewBag.EnvolvidoId = envolvidoId;

            var endereco = await _context.Endereco.FindAsync(id);

            return View(endereco);
        }

        // POST: EnderecoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Endereco endereco, int envolvidoId)
        {
            if (id != endereco.EnderecoId)
            {
                return NotFound();
            }
            try
            {
                _context.Update(endereco);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Endereço Alterado Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencia", new { id = envolvidoId });
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Alterar Endereço!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: EnderecoController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var endereco = await _context.Endereco
                .FirstOrDefaultAsync(e => e.EnderecoId == id);

            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);

        }

        // POST: EnderecoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var endereco = await _context.Endereco.FindAsync(id);
                _context.Endereco.Remove(endereco);
                Notify(title: "OK!", message: "Endereço Deletado Com Sucesso!", notificationType: Notification.success);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Deletar Endereço!", notificationType: Notification.success);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
