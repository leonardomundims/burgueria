using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    class Pedido {
        private List<ItemPedido> Ordem = new List<ItemPedido>();

        public void Adicionar(ItemPedido item) {
            Ordem.Add(item);
        }

        public void Imprimir() {
            Console.WriteLine("----------- PEDIDO ------------");
            Console.WriteLine("# - ITEM - QTD - VALOR UNITARIO");
            int i = 1;
            foreach(var item in Ordem) {
                Console.WriteLine($"{i} - {item.Descricao} - {item.Quantidade} - {item.ValorUnitario}");
                i++;
            }
        }

        public double Total() {
            double total = 0;

            foreach(var item in Ordem) {
                total += item.ValorUnitario * item.Quantidade;
            }

            return total;
        }

    }
}
