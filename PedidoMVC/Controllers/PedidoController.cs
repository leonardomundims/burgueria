using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PedidoMVC.Models;


namespace PedidoMVC.Controllers {
    public class PedidoController : Controller {

        Pedido pedidoAtual = Dados.PedidoAtual;
        
        [HttpGet]
        public IActionResult Index() {
            if(pedidoAtual.Exibir().Count > 0) {
                pedidoAtual.Limpar();
            }
            ViewBag.Header = "Faça seu pedido";
            return View();
        }

        
        [HttpPost]
        public IActionResult Index(ItemPedido item) {
            string nome = item.Nome;
            int quantidade = item.Quantidade;
    
            string preco = item.Preco;
            switch(preco){
                case "p": preco = "10"; break;
                case "m": preco = "20"; break;
                case "g": preco = "30"; break;

            }
            

            var itemPedido = new ItemPedido(nome, preco, quantidade);
            pedidoAtual.Adicionar(itemPedido);
            
            var ordem = pedidoAtual.Exibir();
            return View(ordem);
        }


        public IActionResult PedidoFinal() {

            ViewBag.Total = pedidoAtual.Total().ToString("C2");
            var ordem = pedidoAtual.Exibir();
            return View(ordem);
        }

    }
}
