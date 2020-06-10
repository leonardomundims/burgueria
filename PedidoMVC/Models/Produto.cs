using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoMVC.Models {
    public class Produto {
        public string Nome { get; set; }

        private double Price;

        public string Preco {
            get => Price.ToString();

            set {
                double.TryParse(value, out double preco);
                if(preco > 0) {
                    Price = preco;
                } 
            }
        }

        public string Exibir() {
            return $"Produto: {Nome}, Preço: {Preco}";
        }

    }
}
