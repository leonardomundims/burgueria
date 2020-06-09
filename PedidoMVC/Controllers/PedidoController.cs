using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidoMVC.Models;
using pedidosConsole.Models;

namespace PedidoMVC.Controllers {
    public class PedidoController : Controller {

        Pedido dados = Dados.PedidoAtual;
        [HttpGet]
        public IActionResult Index() {
            ViewBag.Header = "Faça seu pedido";
            return View();
        }

        
        [HttpPost]
        public IActionResult Index(ItemPedido item) {
            

            var itemPedido = new ItemPedido();
            itemPedido.Descricao = item.Descricao;
            itemPedido.ValorUnitario = (item.ValorUnitario).Replace(".", ",");
            itemPedido.Quantidade = item.Quantidade;

           
            dados.Adicionar(itemPedido);
            var ordem = dados.Exibir();

            ViewBag.Header = "Seu pedido";
            return View(ordem);
        }


        public IActionResult PedidoFinal() {
            
            ViewBag.Total = dados.Total().ToString("C2");
            var ordem = dados.Exibir();
            return View(ordem);
        }

    }
}
