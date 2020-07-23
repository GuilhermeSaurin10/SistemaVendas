using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaVendas.DAL;
using SistemaVendas.Entidades;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class HomeController : Controller
    {
        protected ApplicationDbContext Repositorio;

        public HomeController(ApplicationDbContext repositorio)
        {
            Repositorio = repositorio;
        }

        public IActionResult Index()
        {
            Categoria objCategoria = Repositorio.Categoria.Where(x => x.Codigo == 1).FirstOrDefault();
            Repositorio.Attach(objCategoria);
            Repositorio.Remove(objCategoria);
            Repositorio.SaveChanges();

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
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
    }
}
