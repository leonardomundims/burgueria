using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidoMVC.Models;
using pedidosConsole.Models;

namespace PedidoMVC.Controllers {
    public class PedidoController : Controller {

        [HttpGet]
        public IActionResult Index() {
            
            return View();
        }

        Pedido dados = Dados.PedidoAtual;
        [HttpPost]
        public IActionResult Index(ItemPedido item) {
            Console.WriteLine(item);
            var itemPedido = new ItemPedido();
            itemPedido.Descricao = item.Descricao;
            itemPedido.ValorUnitario = item.ValorUnitario;
            itemPedido.Quantidade = item.Quantidade;

           
            dados.Adicionar(itemPedido);
            var ordem = dados.Exibir();

            return View(ordem);
        }


        public IActionResult PedidoFinal() {

            ViewBag.Total = dados.Total().ToString("C2");
            var ordem = dados.Exibir();
            return View(ordem);
        }

        public IActionResult Pedidos() {
            return View();
        }
    }
}
