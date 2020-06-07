using pedidosConsole.Models;
using System;
using System.Collections.Generic;

namespace pedidosConsole {
    class Program {

        static void Main(string[] args) {
            var pedido = new List<ItemPedido>();
            string decisao;


            Console.WriteLine("---- Faça o pedido -----");
            


            do {
                var item = new ItemPedido();
                //pegar a descrição do item[i]
                Console.WriteLine("Descreva o item");
                item.Descricao = Console.ReadLine();

                //pegar o valor unitario do item[i]
                Console.WriteLine("Digite o valor do item");
                double.TryParse(Console.ReadLine(), out double valorUnitario);
                item.ValorUnitario = valorUnitario;

                //pegar a quantidade do item[i]
                Console.WriteLine("Digite a quantidade do item");
                int.TryParse(Console.ReadLine(), out int quantidade);
                item.Quantidade = quantidade;

                // adicionar o item ao pedido
                pedido.Add(item);

                //exibir o pedido
                Console.WriteLine("------- PEDIDO -------");
                Console.WriteLine("# - ITEM - VALOR UNITARIO - QTD");
                int i = 1;
                foreach (var elemento in pedido) {
                    
                    Console.WriteLine($"{i} - {elemento.Descricao} - {elemento.ValorUnitario} - {elemento.Quantidade}");
                    Console.WriteLine("-------------------");
                    i++;
                }
                
                Console.WriteLine("Gostaria de adicionar um item ao pedido? s/n");
                decisao = Console.ReadLine();


            } while (decisao == "s");

            
        }
    }
}
