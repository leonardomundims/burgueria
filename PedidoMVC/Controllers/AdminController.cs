using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidoMVC.Models;

namespace PedidoMVC.Controllers {
    
    public class AdminController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroProduto() {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroProduto(Produto produto) {
            
            var novoProduto = new Produto();
            novoProduto.Nome = produto.Nome;
            novoProduto.Preco = (produto.Preco).Replace(".", ",");

            return View(novoProduto);
        }





       
    }
}
