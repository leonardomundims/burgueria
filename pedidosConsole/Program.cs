using pedidosConsole.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace pedidosConsole {
    class Program {

        static void Main(string[] args) {
            string decidir;
            int i = 1;

            Console.WriteLine("Gostaria de fazer um pedido? s/n");
            decidir = Console.ReadLine();

            while(decidir == "s") {
                var pedido = new Pedido();
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
                    pedido.Adicionar(item);

                    //exibir o pedido
                    pedido.Imprimir();

                    Console.WriteLine("Gostaria de adicionar um item ao pedido? s/n");
                    decisao = Console.ReadLine();


                } while (decisao == "s");

                var total = pedido.Total();
                Console.WriteLine("--------------");
                Console.WriteLine($"Total do pedido {i}: " + total.ToString("C2", CultureInfo.CurrentCulture));
                i++;

                Console.WriteLine("Gostaria de fazer um novo pedido? s/n ");
                decidir = Console.ReadLine();

            }


            Console.WriteLine("Obrigado por utilizar o programa");
 
        }
    }
}
