using Microsoft.AspNetCore.Mvc;
using Storage_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage_Project.Controllers
{
    public class ProdutosController : Controller
    {

        public static List<Produto> lsProdutos = new List<Produto>();
        public IActionResult Index()
        {
            Produto p1 = new Produto();
            p1.Codigo = 99;
            p1.Descricao = "Mesa Digital";
            p1.Valor = 950;

            lsProdutos.Add(p1);

            return View(lsProdutos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto objeto)
        {
            lsProdutos.Add(objeto);
            return RedirectToAction("Index");
        }
    }
}
