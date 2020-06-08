using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pedidosConsole.Models;

namespace PedidoMVC.Controllers {
    public class PedidoController : Controller {

        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ItemPedido item) {
            var itemPedido = new ItemPedido();
            itemPedido.Descricao = item.Descricao;
            itemPedido.ValorUnitario = item.ValorUnitario;
            itemPedido.Quantidade = item.Quantidade;

            var pedido = new Pedido();
            pedido.Adicionar(itemPedido);
            var ordem = pedido.Exibir();
            return View(ordem);
        }


        [HttpPost]
        public IActionResult PedidoFinal(Pedido pedido) {
            return View(pedido);
        }

        public IActionResult Pedidos() {
            return View();
        }
    }
}
