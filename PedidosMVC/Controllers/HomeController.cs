using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosMVC.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }


        //pagina de pedidos
        public IActionResult Pedido() {
            return View();
        }

        public IActionResult Pedidos() {
            return View();
        }
    }
}
