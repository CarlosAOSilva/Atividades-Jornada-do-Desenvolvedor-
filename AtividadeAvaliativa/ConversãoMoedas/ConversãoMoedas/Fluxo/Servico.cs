using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversaoMoedas.Entidades;

namespace ConversaoMoedas.Fluxo
{
    internal class Servico
    {
        public void Perguntar()
        {
            Console.WriteLine("### Atividade de Conversão de Moedas ###\n");

            bool e = true;
            while (e)
            {
                Console.Clear();
                Console.WriteLine(" ----- Para o quê você deseja Converter o Real? -----\n");
                Console.WriteLine(" ( 1 ) ---------- Dolar ---------- ");
                Console.WriteLine(" ( 2 ) ------------ Euro --------- ");
                Console.WriteLine(" ( 3 ) ----- Peso Argentinos ----- ");
                Console.WriteLine(" ( 4 ) ----- Bath Tailandês ------ ");
                Console.WriteLine(" ( 5 ) ---- Encerrar Processo ----\n");
                Console.Write("Digite uma Opção: ");
                var resposta = Console.ReadLine();
                Console.Clear();

                try
                {

                    switch (resposta)
                    {
                        case "1":
                            Dolar();
                            break;
                        case "2":
                            Euro();
                            break;
                        case "3":
                            PesoArgentinos();
                            break;
                        case "4":
                            BathTailandes();
                            break;
                        case "5":
                            e = false;
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
        public Moedas Dolar()
        {
            var moedas = new Moedas();
            Console.Write("Quanto em Real você pretende converter para Dolar? R$: ");
            moedas.real = Convert.ToDecimal(Console.ReadLine());
            if (moedas.real <= 0) throw new InvalidOperationException("O Valor infomado não pode ser Menor ou Igual a Zero");

            moedas.conversao = moedas.real / moedas.dolar;

            Console.Write("Você terá: US$ " + Math.Round(moedas.conversao, 2) + " em Doláres");
            Console.ReadKey();

            return new Moedas();
        }

        public Moedas Euro()
        {
            var moedas = new Moedas();

            Console.Write("Quanto em Real você pretende converter para Euros? R$: ");
            moedas.real = Convert.ToDecimal(Console.ReadLine());
            if (moedas.real <= 0) throw new InvalidOperationException("O Valor infomado não pode ser Menor ou Igual a Zero");

            moedas.conversao = moedas.real / moedas.euro;

            Console.Write("Você terá: " + Math.Round(moedas.conversao, 2) + " em Euros");
            Console.ReadKey();

            return new Moedas();
        }
        public Moedas PesoArgentinos()
        {
            var moedas = new Moedas();

            Console.Write("Quanto em Real você pretende converter para Pesos Argentinos? R$: ");
            moedas.real = Convert.ToDecimal(Console.ReadLine());
            if (moedas.real <= 0) throw new InvalidOperationException("O Valor infomado não pode ser Menor ou Igual a Zero");

            moedas.conversao = moedas.real / moedas.pesoArgentinos;

            Console.Write("Você terá: $ " + Math.Round(moedas.conversao, 2) + " em Pesos Argentinos");
            Console.ReadKey();

            return new Moedas();
        }
        public Moedas BathTailandes()
        {
            var moedas = new Moedas();

            Console.Write("Quanto em Real você pretende converter para Bath Tailandês? R$: ");
            moedas.real = Convert.ToDecimal(Console.ReadLine());
            if (moedas.real <= 0) throw new InvalidOperationException("O Valor infomado não pode ser Menor ou Igual a Zero");

            moedas.conversao = moedas.real / moedas.bathTailandes;

            Console.Write("Você terá: " + Math.Round(moedas.conversao, 2) + " em Bath Tailandês");
            Console.ReadKey();

            return new Moedas();
        }

    }
}
