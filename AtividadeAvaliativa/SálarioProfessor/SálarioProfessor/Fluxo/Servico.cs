using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioProfessor.Fluxo
{
    internal class Servico
    {
        public void Perguntar()
        {
            bool p = true;
            while (p)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo Sr(a) Professor(a)!!!");
                Console.WriteLine(" --- Qual o seu Nível? --- \n");
                Console.WriteLine(" ( 1 ) ----- Nivel 1 (Assistente) ---- ");
                Console.WriteLine(" ( 2 ) ----- Nível 2 (Adjunto) ------- ");
                Console.WriteLine(" ( 3 ) ----- Nível 3 (Associado) ----- ");
                Console.WriteLine(" ( 4 ) -- Encerrar Processo --\n");
                Console.Write("Digite uma Opção: ");
                var resposta = Console.ReadLine();
                Console.Clear();

                try
                {
                    switch (resposta)
                    {
                        case "1":
                            Nivel1();
                            break;
                        case "2":
                            Nivel2();
                            break;
                        case "3":
                            Nivel3();
                            break;
                        case "4":
                            p = false;
                            break;
                        default:
                            Console.WriteLine("Selecione uma Opção Válida!!!");
                            Console.ReadKey();
                            continue;
                    }

                }
                catch (InvalidOperationException)
                {
                    Console.Clear();
                    Console.WriteLine("Informação Inválida. Tente Novamente");
                    Console.WriteLine("Pressione uma tecla para continuar!");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Informação Inválida. Tente Novamente");
                    Console.WriteLine("Pressione uma tecla para continuar!");
                    Console.ReadKey();
                }

            }
        }
            public Entidades.Dados Nivel1()
        {
            var calculo = new Entidades.Dados();
            Console.Write("Quantas horas você lecionou? ");
            Console.WriteLine("Obs: 3h e 35 minutos = 3,35 / 5h e meia = 5,5.");
            calculo.horastrabalhas = Convert.ToDecimal(Console.ReadLine());
            if (calculo.horastrabalhas <= 0 || calculo.horastrabalhas > 24) throw new InvalidOperationException("Valor infomado Inválido");


            calculo.valorTotal = calculo.horastrabalhas * calculo.nivel1;

            Console.WriteLine("Você receberá no final do dia: R$ " + Math.Round(calculo.valorTotal, 2)  
                + " por ter trabalhados por " + calculo.horastrabalhas + "h");

            Console.ReadKey();
            return calculo;
        }

        public Entidades.Dados Nivel2()
        {
            var calculo = new Entidades.Dados();
            Console.Write("Quantas horas você lecionou? ");
            Console.WriteLine("Obs: 3h e 35 minutos = 3,35 / 5h e meia = 5,5.");
            calculo.horastrabalhas = Convert.ToDecimal(Console.ReadLine());
            if (calculo.horastrabalhas <= 0 || calculo.horastrabalhas > 24) throw new InvalidOperationException("Valor infomado Inválido");

            calculo.valorTotal = calculo.horastrabalhas * calculo.nivel2;

            Console.WriteLine("Você receberá no final do dia: R$ " + Math.Round(calculo.valorTotal, 2) 
                + " por ter trabalhados por " + calculo.horastrabalhas + "h");

            Console.ReadKey();
            return calculo;
        }
        public Entidades.Dados Nivel3()
        {
            var calculo = new Entidades.Dados();
            Console.Write("Quantas horas você lecionou? ");
            Console.WriteLine("Obs: 3h e 35 minutos = 3,35 / 5h e meia = 5,5.");
            calculo.horastrabalhas = Convert.ToDecimal(Console.ReadLine());
            if (calculo.horastrabalhas <= 0 || calculo.horastrabalhas > 24) throw new InvalidOperationException("Valor infomado Inválido");

            calculo.valorTotal = calculo.horastrabalhas * calculo.nivel3;

            Console.WriteLine("Você receberá no final do dia: R$ " + Math.Round(calculo.valorTotal, 2) 
                + " por ter trabalhados por " + calculo.horastrabalhas + "h");

            Console.ReadKey();
            return calculo;
        }
    }
}
    







