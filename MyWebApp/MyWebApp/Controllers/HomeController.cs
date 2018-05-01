using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.AcessoDados;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProdutoRepository _repository;

        public HomeController(IProdutoRepository repository)
        {

            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.ListarProdutos());
        }
        public string Obter() {

            return "Teste";
        }
    }
}