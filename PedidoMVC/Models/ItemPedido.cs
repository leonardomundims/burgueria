using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoMVC.Models {
    public class ItemPedido {

        public string Nome { get; set; }

        public string Preco {get; set;}

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
            var info = Preco.Replace(".", ",");
            double.TryParse(info, out double preco);
            return preco * Quantidade;
        }

        public ItemPedido(string nome, string preco, int quantidade){
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ItemPedido(){}

    }
}
