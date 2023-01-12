using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Atividade02Pares
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Atividade RUMO ###\n");
            Console.WriteLine("### Atividade 02 Números Positivos ###\n");

            var selecionados = new List<Entidades.Dados>();

            for (int cnt = 0; cnt < 3; cnt++)
            {
                char x = ' ';

                Console.WriteLine("Digite um número?");
                var numeros = Convert.ToInt32(Console.ReadLine());
                
                var selecinado = new Entidades.Dados();
                selecinado.numero = numeros;

                if (numeros == x)
                {
                    Console.WriteLine("Digite apenas números Inteiros");
                    continue;
                }

                if (numeros > 0)
                {
                    selecionados.Add(selecinado);
                }

            }

            foreach (var obj in selecionados)
            {
               Console.WriteLine("Número Positivo: ");
               Console.WriteLine(obj.numero);
            }

            Console.ReadKey();

        }
    }
}
    