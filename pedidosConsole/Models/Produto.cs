using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    public class Produto {
        public string Nome { get; set; }

        private double Price;

        public double Preco {
            get => Price;

            set {
                if(value > 0) {
                    Price = value;
                } 
            }
        }

        public string Exibir() {
            return $"Produto: {Nome}, Preço: {Preco}";
        }

    }
}
