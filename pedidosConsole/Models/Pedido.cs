using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    public class Pedido {
        private List<ItemPedido> Ordem = new List<ItemPedido>();

        public void Adicionar(ItemPedido item) {
            Ordem.Add(item);
        }

        public List<ItemPedido> Exibir(){
            return Ordem;
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
                double.TryParse(item.ValorUnitario, out double valor);
                int quantidade = item.Quantidade;
                total += valor * quantidade;
            }

            return total;
        }

    }
}
