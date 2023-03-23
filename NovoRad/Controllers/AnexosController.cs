using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovoRad.Context;
using NovoRad.Models;
using NovoRad.Models.Notification;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class AnexosController : BaseController
    {

        private readonly AppDbContext _context;

        public AnexosController(AppDbContext context)
        {
            _context = context;
        }
        // GET: AnexosController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Anexo.ToListAsync());
        }

        // GET: AnexosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnexosController/Create
        public IActionResult Create(int ocorrenciaId)
        {
            ViewBag.OcorrenciaId = ocorrenciaId;
            ViewBag.TipoAnexoId = new SelectList(_context.TipoAnexo, "TipoAnexoId", "NomeTipoAnexoUpload");
            return View();
        }

        // POST: AnexosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Anexo anexo, IFormFile postedFile, int ocorrenciaId)
        {
            if (postedFile == null)
            {
                return View(anexo);
            }

            if (ModelState.IsValid)
            {
                var userId = User.Identity.Name.Split("\\")[1];
                anexo.OcorrenciaId = ocorrenciaId;
                try
                {
                    byte[] bytes;
                    using (BinaryReader binaryReader = new BinaryReader(postedFile.OpenReadStream()))
                    {
                        bytes = binaryReader.ReadBytes((int)postedFile.Length);
                    }

                    var name = Path.GetFileName(postedFile.FileName);
                    var contentType = postedFile.ContentType;

                    anexo.NomeAnexoUpload = name;
                    anexo.Autor = userId;
                    anexo.ContentType = contentType;
                    anexo.Bytes = bytes;

                    _context.Anexo.Add(anexo);
                    await _context.SaveChangesAsync();
                    Notify(title: "OK!", message: "Anexo Adicionado Com Sucesso!", notificationType: Notification.success);
                    
                    return RedirectToAction("Edit", "Ocorrencias", new { id = ocorrenciaId });

                }
                catch (Exception ex)
                {
                    Notify(title: "Oops!", message: "Erro Ao Adicionar Anexo!", notificationType: Notification.warning);
                    return View();
                }
            }

            return View(anexo);
        }

        [HttpPost]
        public FileResult DownloadFile(int? fileId)
        {
            Anexo anexo = _context.Anexo.ToList().Find(p => p.AnexoId == fileId.Value);
            return File(anexo.Bytes, anexo.ContentType, anexo.NomeAnexoUpload);
        }

        // GET: AnexosController/Edit/5
        public async Task<IActionResult> Edit(int? id, int ocorrenciaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anexo = await _context.Anexo.FindAsync(id);
            if (anexo == null)
            {
                return NotFound();
            }

            ViewBag.OcorrenciaId = ocorrenciaId;
            ViewBag.TipoAnexoId = new SelectList(_context.TipoAnexo, "TipoAnexoId", "NomeTipoAnexoUpload");

            return View(anexo);
        }

        // POST: AnexosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Anexo anexo, IFormFile postedFile, int ocorrenciaId)
        {
            if (id != anexo.AnexoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var userId = User.Identity.Name.Split("\\")[1];

                try
                {
                    if (postedFile != null)
                    {
                        byte[] bytes;
                        using (BinaryReader binaryReader = new BinaryReader(postedFile.OpenReadStream()))
                        {
                            bytes = binaryReader.ReadBytes((int)postedFile.Length);
                        }

                        var name = Path.GetFileName(postedFile.FileName);
                        var contentType = postedFile.ContentType;

                        anexo.NomeAnexoUpload = name;
                        anexo.Autor = userId;
                        anexo.ContentType = contentType;
                        anexo.Bytes = bytes;
                    }

                    _context.Anexo.Update(anexo);
                    await _context.SaveChangesAsync();

                    Notify(title: "OK!", message: "Anexo Alterado Com Sucesso!", notificationType: Notification.success);
                    return RedirectToAction("Edit", "Ocorrencias", new { id = ocorrenciaId });

                }
                catch (Exception)
                {
                    Notify(title: "OK!", message: "Erro Ao Alterar Anexo!", notificationType: Notification.warning);
                    return View();
                }
            }

            return View(anexo);
        }
        // GET: AnexosController/Delete/5
        public async Task<IActionResult> Delete(int? id, int ocorrenciaId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anexo = await _context.Anexo
                .FirstOrDefaultAsync(m => m.AnexoId == id);

            if (anexo == null)
            {
                return NotFound();
            }

            ViewBag.OcorrenciaId = ocorrenciaId;
            
            return View(anexo);
        }

        // POST: AnexosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, int ocorrenciaId)
        {
            var userId = User.Identity.Name.Split("\\")[1];
            try
            {
                var anexo = await _context.Anexo.FindAsync(id);
                _context.Anexo.Remove(anexo);
                Notify(title: "OK!", message: "Anexo Deletado!", notificationType: Notification.success);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                Notify(title: "OK!", message: "Erro Ao Deletar Anexo!", notificationType: Notification.error);
            }
            return RedirectToAction("Edit", "Ocorrencias", new { id = ocorrenciaId });
        }

        private bool AnexoExists(int id)
        {
            return _context.Anexo.Any(e => e.AnexoId == id);
        }
    }
}
