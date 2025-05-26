using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05.Models;

namespace TP05.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

     public IActionResult Index()
        {
            return View();
        }

        // INTRODUCCIÓN + MAPA + BOTÓN TRAMPA
        public IActionResult Introduccion()
        {
            return View();
        }

        // PÁGINA TRAMPA CON CONTADOR
        public IActionResult Error()
        {
            return View();
        }

        // SALAS DEL ESCAPE (se completarán con lógica de validación después)
        public IActionResult Sala1() => View();
        public IActionResult Sala2() => View();
        public IActionResult Sala3() => View();
        public IActionResult Sala4() => View();

        // PISTAS POR SALA
        public IActionResult Pistas1() => View();
        public IActionResult Pistas2() => View();
        public IActionResult Pistas3() => View();
        public IActionResult Pistas4() => View();

        // BITÁCORA (si querés mostrar el progreso)
        public IActionResult Bitacora()
        {
            return View();
        }

        // EJEMPLO PARA USAR SESSION CON NOMBRE DE JUGADOR
        [HttpPost]
        public IActionResult GuardarNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                HttpContext.Session.SetString("Jugador", nombre);
                return RedirectToAction("Sala1");
            }

            return RedirectToAction("Index");
        }
}
