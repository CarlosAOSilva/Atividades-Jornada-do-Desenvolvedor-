using Atividade03.Entidades;
using System;
using System.Collections.Generic;

namespace Atividade03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Atividades RUMO ###\n");
            Console.WriteLine("### Atividade 03 ###\n");

            var cadastros = new List<Dados>();

            for (int i = 0; i < 10; i++)

            {
                Console.Write("Informe um Nome: ");
                string nomes = Console.ReadLine();
                Console.Write("Informe a Idade: ");
                int idades = Convert.ToInt32(Console.ReadLine());

                var cadastro = new Dados();
                cadastro.nome = nomes;
                cadastro.idade = idades;
                cadastros.Add(cadastro);

            }

            var nomeMaiorIdade = "";
            var idadeMaior = 0;

            foreach (var cadastro in cadastros)
            {
                
                Console.WriteLine("Nome: {0}, Idade: {1}", cadastro.nome, cadastro.idade + " anos");
                Console.ReadKey();

                if (idadeMaior < cadastro.idade)
                {
                    idadeMaior = cadastro.idade;
                    nomeMaiorIdade = cadastro.nome;
                }
            }

            Console.WriteLine("\nO mais velho dos cadastrados é " + nomeMaiorIdade);

        }
    }
}
