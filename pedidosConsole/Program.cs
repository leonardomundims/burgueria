using pedidosConsole.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace pedidosConsole {
    class Program {

        static void Main(string[] args) {
            string decidir;

            Console.WriteLine("Gostaria de? 1-Fazer um pedido ou 2-Adicionar um produto");
            decidir = Console.ReadLine().;

            switch(decidir) {
                case "1": {
                    int i = 1;

                    //fazer pedido
                    do {

                        //string decisao;
                        var pedido = new Pedido();
                        Console.WriteLine("---- Faça o pedido -----");

                        //adicionar itens ao pedido
                        do {
                            var item = new ItemPedido();
                            //pegar a descrição do item[i]
                            Console.WriteLine("Escolha o item");
                            Console.WriteLine();
                            item.Descricao = Console.ReadLine();

                            //pegar o valor unitario do item[i]
                            Console.WriteLine("Digite o valor do item");
                            item.ValorUnitario = (Console.ReadLine()).Replace(".", ",");

                            //pegar a quantidade do item[i]
                            Console.WriteLine("Digite a quantidade do item");
                            int.TryParse(Console.ReadLine(), out int quantidade);
                            item.Quantidade = quantidade;

                            // adicionar o item ao pedido
                            pedido.Adicionar(item);

                            //exibir o pedido
                            pedido.Imprimir();

                            Console.WriteLine("Gostaria de adicionar um item ao pedido? s/n");
                            decidir = Console.ReadLine();


                        } while (decidir == "s");

                        var total = pedido.Total();
                        Console.WriteLine("--------------");
                        Console.WriteLine($"Total do pedido {i}: " + total.ToString("C2", CultureInfo.CurrentCulture));
                        i++;

                        Console.WriteLine("Gostaria de fazer um novo pedido? s/n ");
                        decidir = Console.ReadLine();

                    } while (decidir == "s");

                    };
                    break;


                case "2": {
                        do {
                            var produto = new Produto();
                            //nome do produto
                            Console.WriteLine("Digite o nome do Produto");
                            produto.Nome = Console.ReadLine();

                            //preço produto
                            Console.WriteLine("Digite o preço do Produto");
                            var info = (Console.ReadLine()).Replace(".", ","); //trocar . por , para evitar erro nos calculos .NET usa CultureInfo
                            double.TryParse(info, out double preco);
                            produto.Preco = preco;

                            //exibir o produto cadastrado
                            Console.WriteLine(produto.Exibir());


                            Console.WriteLine("Deseja cadastrar outro Produto? s/n");
                            decidir = Console.ReadLine();
                        } while (decidir == "s");
                    };
                    break;
            }
                
            }


            if(decidir == "1") {
               

                Console.WriteLine("Obrigado por utilizar o programa");
            }

            







        }
    }
}
