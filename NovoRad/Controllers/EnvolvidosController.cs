using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoRad.Context;
using NovoRad.Models;
using NovoRad.Models.Notification;
using NovoRad.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class EnvolvidosController : BaseController
    {

        private readonly AppDbContext _context;

        public EnvolvidosController(AppDbContext context)
        {
            _context = context;
        }

        //GET: EnvolvidosController
        public async Task<IActionResult> Index()
        {
            var envolvidos = await _context.Envolvido
                .Include(e => e.AcaoTomada)
                .Include(e => e.MedidaDisciplinar)
                .Include(e => e.TipoEnvolvimento)
                .Include(e => e.Endereco)
                .ThenInclude(e => e.EnderecoId)
                .ToListAsync();


            //EnvolvidoEnderecoViewModel viewModelEnvolvido = new EnvolvidoEnderecoViewModel();
            //viewModelEnvolvido.Envolvidos = await _context.Envolvido
            //    .Include(e => e.AcaoTomada)
            //    .Include(e => e.MedidaDisciplinar)
            //    .Include(e => e.TipoEnvolvimento)
            //    .ToListAsync();
            //viewModelEnvolvido.Enderecos = _context.Endereco
            //    .Include(e => e.EnderecoId);

            return View(envolvidos);
        }

        public ActionResult Details()
        {
                
            return View();
        }

 
        public ActionResult Consulta(string cpfToFind)
        {
            if (cpfToFind == null)
            {
                return NotFound();
            }
            return View( _context.Envolvido
                .Include(e => e.AcaoTomada)
                .Include(e => e.MedidaDisciplinar)
                .Include(e => e.TipoEnvolvimento)
                .Where(e => e.CPF_CNPJ == cpfToFind)
                .ToList());

        }

        // GET: EnvolvidosController/Create
        public IActionResult Create(int ocorrenciaId)
        {


            ViewBag.OcorrenciaId = ocorrenciaId;
            ViewBag.TipoEnvolvimentoId = new SelectList(_context.TipoEnvolvimento, "TipoEnvolvimentoId", "NomeTipoEnvolvimento");
            ViewBag.AcaoTomadaId = new SelectList(_context.AcaoTomada, "AcaoTomadaId", "NomeAcaoTomada");
            ViewBag.MedidaDisciplinarId = new SelectList(_context.MedidaDisciplinar, "MedidaDisciplinarId", "NomeMedidaDisciplinar");

            return View();
        }

        // POST: EnvolvidosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Envolvido envolvido, int ocorrenciaId )
        {
            try
            {
                envolvido.OcorrenciaId = ocorrenciaId;
                _context.Add(envolvido);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Envolvido Adicionado Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencias");
            }
            catch
            {
                Notify(title: "Oops!", message: "Erro Ao Adicionar Envolvido!", notificationType: Notification.success);
                return View();
            }

        }

        // GET: EnvolvidosController/Edit/5
        public async Task<IActionResult> Edit(int? id, int ocorrenciaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.EnvolvidoId = id;
            ViewBag.OcorrenciaId = ocorrenciaId;

            var envolvido = await _context.Envolvido
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(o => o.EnvolvidoId == id);
            //.FindAsync(id);


            //var envolvido = await _context.Envolvido
            //    .Include(e => e.Endereco)
            //    .ThenInclude(x => x.EnderecoId)
            //    .FirstOrDefaultAsync(e => e.EnvolvidoId == id);

            ViewBag.TipoEnvolvimentoId = new SelectList(_context.TipoEnvolvimento, "TipoEnvolvimentoId", "NomeTipoEnvolvimento");
            ViewBag.AcaoTomadaId = new SelectList(_context.AcaoTomada, "AcaoTomadaId", "NomeAcaoTomada");
            ViewBag.MedidaDisciplinarId = new SelectList(_context.MedidaDisciplinar, "MedidaDisciplinarId", "NomeMedidaDisciplinar");

            return View(envolvido);
        }

        // POST: EnvolvidosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Envolvido envolvido, int ocorrenciaId)
        {
            if (id != envolvido.EnvolvidoId)
            {
                return NotFound();
            }
            try
            {
                _context.Update(envolvido);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Envolvido Alterado Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction("Edit", "Ocorrencia", new { id = ocorrenciaId });
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Alterar Envolvido!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: EnvolvidosController/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var envolvido = await _context.Envolvido
                .Include(e => e.AcaoTomada)
                .Include(e => e.TipoEnvolvimento)
                .Include(e => e.MedidaDisciplinar)
                .FirstOrDefaultAsync(e => e.EnvolvidoId == id);


            if (envolvido == null)
            {
                return NotFound();
            }

            return View(envolvido);
        }

        // POST: EnvolvidosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var envolvido = await _context.Envolvido.FindAsync(id);
                _context.Envolvido.Remove(envolvido);

                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Conclusão Deletada!", notificationType: Notification.success);

            }
            catch (Exception ex)
            {
                Notify(title: "OK!", message: "Erro Ao Deletar Envolvido!", notificationType: Notification.warning);
            }
            return RedirectToAction(nameof(Index));
        }
    }

}
