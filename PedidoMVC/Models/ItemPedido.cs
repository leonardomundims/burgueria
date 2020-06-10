using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoMVC.Models {
    public class ItemPedido {

        public Produto Produto { get; set; }

        private int Quantity;

        public int Quantidade {
            get => Quantity;

            set {
                if(value > 0) {
                    Quantity = value;
                }
            }
        }

        public double SubTotal() {
            double.TryParse(Produto.Preco, out double preco);
            return preco * Quantidade;
        }

    }
}
