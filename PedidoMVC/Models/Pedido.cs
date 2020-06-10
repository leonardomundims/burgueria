using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoMVC.Models {
    public class Pedido {
        private List<ItemPedido> Ordem = new List<ItemPedido>();

        public void Adicionar(ItemPedido item) {
            Ordem.Add(item);
        }

        public void Limpar() {
            if(Ordem.Count > 0) {
                Ordem.Clear();
            }
        }

        public List<ItemPedido> Exibir(){
            return Ordem;
        }

        public double Total() {
            double total = 0;

            foreach(var item in Ordem) {
                total += item.SubTotal();
            }

            return total;
        }

    }
}
