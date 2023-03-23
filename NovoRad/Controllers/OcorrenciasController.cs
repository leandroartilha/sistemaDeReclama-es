using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoRad.Context;
using NovoRad.Models;
using NovoRad.Models.Notification;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace NovoRad.Controllers
{
    public class OcorrenciasController : BaseController
    {
        private readonly AppDbContext _context;

        public OcorrenciasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OcorrenciasController
        public async Task<IActionResult> Index()
        {
            var ocorrencias = await _context.Ocorrencia
                .Include(o => o.Ambiente)
                .Include(o => o.AreaDemandante)
                .Include(o => o.Classificacao)
                .Include(o => o.Prioridade)
                .Include(o => o.Produto)
                .Include(o => o.Responsavel)
                .Include(o => o.Seguimento)
                .Include(o => o.Status)
                .Include(o => o.Conclusao)
                .Include(o => o.Anexo)
                .ToListAsync();
            return View(ocorrencias);
        }

        // GET: OcorrenciasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OcorrenciasController/Create
        public IActionResult Create()
        {
            ViewBag.ResponsavelId = new SelectList(_context.Responsavel, "ResponsavelId", "NomeResponsavel");
            ViewBag.AmbienteId = new SelectList(_context.Ambiente, "AmbienteId", "Nome");
            ViewBag.AreaDemandanteId = new SelectList(_context.AreaDemandante, "AreaDemandanteId", "Nome");
            ViewBag.ClassificacaoId = new SelectList(_context.Classificacao, "ClassificacaoId", "Nome");
            ViewBag.ProdutoId = new SelectList(_context.Produto, "ProdutoId", "NomeProduto");
            ViewBag.SeguimentoId = new SelectList(_context.Seguimento, "SeguimentoId", "NomeSeguimento");
            ViewBag.StatusId = new SelectList(_context.Status, "StatusId", "NomeStatus");
            ViewBag.PrioridadeId = new SelectList(_context.Prioridade, "Id", "NumeroPrioridade");

            return View();
        }

        // POST: OcorrenciasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ocorrencia ocorrencia)
        {
            try
            {
                //status
                //prioridade
                if(ocorrencia.StatusId == 0)
                {
                    ocorrencia.StatusId = 1;
                }

                _context.Add(ocorrencia);
                await _context.SaveChangesAsync();
                Notify(title: "OK!", message: "Ocorrência criada com sucesso!", notificationType: Notification.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Notify(title: "Oops!", message: "Erro Ao Criar Ocorrência!", notificationType: Notification.warning);
                return View();
            }
        }

        // GET: OcorrenciasController/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocorrencia = await _context.Ocorrencia
                .Include(o => o.Ambiente)
                .Include(o => o.Anexo)
                .Include(o => o.AreaDemandante)
                .Include(o => o.Responsavel)
                .Include(o => o.Classificacao)
                .Include(o => o.Prioridade)
                .Include(o => o.Seguimento)
                .Include(o => o.Produto)
                .Include(o => o.Historico)
                .Include(o => o.Conclusao)
                    .ThenInclude(x => x.Resultado)
                .Include(o => o.Envolvido)
                    .ThenInclude(x => x.TipoEnvolvimento)
                .Include(o => o.Tarefa)
                .FirstOrDefaultAsync(o => o.OcorrenciaId == id);

            ViewBag.ResponsavelId = new SelectList(_context.Responsavel, "ResponsavelId", "NomeResponsavel");
            ViewBag.AmbienteId = new SelectList(_context.Ambiente, "AmbienteId", "Nome");
            ViewBag.AreaDemandanteId = new SelectList(_context.AreaDemandante, "AreaDemandanteId", "Nome");
            ViewBag.ClassificacaoId = new SelectList(_context.Classificacao, "ClassificacaoId", "Nome");
            ViewBag.ProdutoId = new SelectList(_context.Produto, "ProdutoId", "NomeProduto");
            ViewBag.SeguimentoId = new SelectList(_context.Seguimento, "SeguimentoId", "NomeSeguimento");
            ViewBag.StatusId = new SelectList(_context.Status, "StatusId", "NomeStatus");
            ViewBag.PrioridadeId = new SelectList(_context.Prioridade, "Id", "NumeroPrioridade");

            ViewBag.UFId = new SelectList(_context.Ocorrencia, "UF", "UF");

            return View(ocorrencia);
        }

        // POST: OcorrenciasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Ocorrencia ocorrencia)
        {
            try
            {
                _context.Update(ocorrencia);
                await _context.SaveChangesAsync();

                Notify(title: "OK!", message: "Ocorrência Alterada Com Sucesso!", notificationType: Notification.success);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                Notify(title: "Oops!", message: "Erro Ao Alterar A Ocorrência!", notificationType: Notification.error);
                return View();
            }

        }

            // GET: OcorrenciasController/Delete/5
            public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OcorrenciasController/Delete/5
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
