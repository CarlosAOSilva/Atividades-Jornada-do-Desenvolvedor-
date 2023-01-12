using Exercicio04.Entidades;
using System;
using System.Collections.Generic;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Atividade RUMO ###\n");
            Console.WriteLine("### Atividade 04 ###\n");

            //Criar uma lista chamada 'controles' e buscar as variáveis em Dados
            var controles = new List<Dados>();

            while (true)
            {
                // Coleta de Dados
                Console.WriteLine("Qual o produto?");
                var produtos = Console.ReadLine();

                Console.WriteLine("Qual o valor do produto?");
                Console.Write("R$ ");
                var valorProdutos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o valor de revenda do produto?");
                Console.Write("R$ ");
                var revendas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de produtos vendidos");
                var quantidades = Convert.ToInt32(Console.ReadLine());

                // Calculo
                var totalCompra = valorProdutos * quantidades;
                var totalVendas = revendas * quantidades;
                var lucros = totalVendas - totalCompra;

                //Coletar dados para a Lista 'controles'
                var controle = new Dados();
                controle.produto = (produtos);
                controle.valorProduto = (valorProdutos);
                controle.revenda = (revendas);
                controle.quantidade = (quantidades);
                controle.lucro = (lucros);
                controles.Add(controle);

                //Comando para Continuar ou Encerrar o processo
                Console.WriteLine("Deseja Cadastrar um Novo Produto? Aperte ENTER para Sim, ou N para Finalizar\n");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    break;

            }
            //Foreach vai executar uma função callback em todos os elementos da lista 'controles' adicionados durante o loop.
            foreach (var obj in controles)
            {
                // Mensagem
                Console.WriteLine("\nProduto: {0}", obj.produto);
                Console.WriteLine("Valor do Produto : R$ {0}", obj.valorProduto);
                Console.WriteLine("Valor de Revenda : R$ {0}", obj.revenda);
                Console.WriteLine("Quantidade Vendida : {0}", obj.quantidade);
                Console.WriteLine("Lucro Total : R$ {0}", obj.lucro);
            }

        }

    }
}
