using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    class Pedido {


        public static double Total(List<ItemPedido> pedido) {
            double total = 0;

            foreach(var item in pedido) {
                total += item.ValorUnitario * item.Quantidade;
            }

            return total;
        }



    }
}
