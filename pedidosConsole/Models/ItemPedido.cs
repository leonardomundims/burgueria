using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    public class ItemPedido {
        public string Descricao { get; set; }
        public string ValorUnitario { get; set; }
        public int Quantidade { get; set; }


        public void Imprimir(ItemPedido item) {
            Console.WriteLine($"Descrição: {item.Descricao} | Valor unitário: {item.ValorUnitario} " +
                $"| Quantidade: {item.Quantidade}");
        }
    }
}
