using pedidosConsole.Models;
using System;
using System.Collections.Generic;

namespace pedidosConsole {
    class Program {
        static void Main(string[] args) {
            var item = new ItemPedido();

            Console.WriteLine("---- Pedido -----");
            Console.WriteLine("Gostaria de adicionar um item ao pedido? s/n");
            var decisao = Console.ReadLine();


            if(decisao == "s") {
                //pegar a descrição do item
                Console.WriteLine("Descreva o item");
                item.Descricao = Console.ReadLine();

                //pegar o valor unitario do item
                Console.WriteLine("Digite o valor do item");
                double.TryParse(Console.ReadLine(), out double valorUnitario);
                item.ValorUnitario = valorUnitario;
                
                //pegar a quantidade do item
                Console.WriteLine("Digite a quantidade do item");
                int.TryParse(Console.ReadLine(), out int quantidade);
                item.Quantidade = quantidade;

                item.Imprimir(item);
            } else {
                Environment.Exit(0);
            }

            
        }
    }
}
