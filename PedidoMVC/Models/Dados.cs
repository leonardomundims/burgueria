using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidoMVC.Models {
    public static class Dados {
        public static Pedido PedidoAtual { get; set; }

        static Dados() {
            PedidoAtual = new Pedido();
        }
    }
}
