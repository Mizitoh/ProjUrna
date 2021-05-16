using Microsoft.AspNetCore.Mvc;
using ProjetoUrna.Models;
using ProjetoUrna.Services;
using SalesWebMvc.Services;
using ProjetoUrna.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUrna.Controllers
{
    public class PresidentesController : Controller
    {

        private readonly PresidenteService _presidenteService;
        private readonly PartidoService _partidoService;

        public PresidentesController(PresidenteService presidenteService, PartidoService partidoService)
        {
            _presidenteService = presidenteService;
            _partidoService = partidoService;
        }
        public IActionResult Index()
        {
            var list = _presidenteService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var Partidoes = _partidoService.FindAll();
            var viewModel = new PresidenteformViewModel { Partidoes = Partidoes};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Presidente presidente)
        {
            _presidenteService.Insert(presidente);
            return RedirectToAction(nameof(Index));
        }
    }
}
