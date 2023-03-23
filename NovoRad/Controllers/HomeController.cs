using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NovoRad.Context;
using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Controllers
{
    public class HomeController : BaseController
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _ctx;

        public HomeController(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _ctx = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {

            _ctx.HttpContext.Session.SetString("UserName",User.Identity.Name);
            _ctx.HttpContext.Session.SetInt32("UserId",40414403);

            var ocorrencias = await _context.Ocorrencia
                .ToListAsync();

            var ocorrenciasTotal = _context.Ocorrencia.Count(o => o.StatusId < 10).ToString();
            var ocorrenciasApuracao = _context.Ocorrencia.Count(o => o.StatusId == 2).ToString();
            var ocorrenciasFila = _context.Ocorrencia.Count(o => o.StatusId == 1).ToString();
            var ocorrenciasConcluido = _context.Ocorrencia.Count(o => o.StatusId == 5).ToString();

            TempData["Total"] = ocorrenciasTotal;
            TempData["OcorrenciasApuracao"] = ocorrenciasApuracao;
            TempData["OcorrenciasFila"] = ocorrenciasFila;
            TempData["OcorrenciasConcluido"] = ocorrenciasConcluido;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
