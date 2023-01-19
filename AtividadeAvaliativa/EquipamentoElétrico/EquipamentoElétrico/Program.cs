using System.Reflection;

namespace EquipamentoEletrico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorkW, valorTotal, horasLigado, horasMes, consumo;
            int potencia, diasLigado;
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Qual o valor do Kilo Watt?: R$");
                    valorkW = Convert.ToDecimal(Console.ReadLine());
                    if (valorkW <= 0) throw new InvalidOperationException("Valor infomado inválido");

                    Console.Write("Qual a potência do Dispositivo? ");
                    potencia = Convert.ToInt32(Console.ReadLine());
                    if (potencia <= 0) throw new InvalidOperationException("O Valor infomado não pode ser Menor ou Igual a Zero");

                    Console.Write("Quantidade de horas que o dispositivo ficou ligado por dia? ");
                    horasLigado = Convert.ToInt32(Console.ReadLine());
                    if (horasLigado <= 0 || horasLigado > 24) throw new InvalidOperationException("Valor infomado Inválido. Um dia têm de uma à 24 horas ");

                    Console.Write("Quantidade de dias no mês que o dispositivo ficou ligado? ");
                    diasLigado = Convert.ToInt32(Console.ReadLine());
                    if (diasLigado <= 0 || diasLigado > 30) throw new InvalidOperationException("Valor infomado Inválido");

                    horasMes = horasLigado * diasLigado;
                    consumo = horasMes * potencia;
                    valorTotal = consumo * valorkW / 1000;

                    Console.WriteLine("O Consumo no final do Mês do disposivo foi de " + Math.Round(consumo, 2) + 
                        "W. E o valor a pagar por este de R$" + Math.Round(valorTotal, 2) + " reais");

                    Console.ReadKey();
                    break;
                }

                catch (InvalidOperationException kw)
                {
                    Console.Clear();
                    Console.WriteLine(kw.Message);
                    Console.WriteLine("Tente Novamente!");
                    Console.ReadKey();
                }

                catch (Exception)
                {
                    Console.WriteLine("Digite Valore Válidos");
                    Console.WriteLine("Pressione uma tecla para continuar!");
                    Console.ReadKey();
                }
            }
        }
    }
}




