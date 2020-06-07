using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    class ItemPedido {
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public void Imprimir(ItemPedido item) {
            Console.WriteLine($"Descrição: {item.Descricao} | Valor unitário: {item.ValorUnitario} " +
                $"| Quantidade: {item.Quantidade}");
        }
    }
}
