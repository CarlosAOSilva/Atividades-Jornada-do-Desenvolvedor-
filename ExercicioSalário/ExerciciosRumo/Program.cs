using System;

namespace ExerciciosRumo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Atividade RUMO ###\n");
            Console.WriteLine("Atividade Comissão\n");

            //Declaração de Variáveis

            string vendedor;
            decimal salario, vendas, comissao, valorFinal;

            // Coleta de Dados

            Console.WriteLine("Qual o nome do Funcionário?");
            vendedor = Console.ReadLine();

            Console.WriteLine("Qual o salário fixo deste Funcionário?");
            Console.Write("R$ ");
            salario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor total realizadas pelo vendedor este mês");
            Console.Write("R$ ");
            vendas = Convert.ToDecimal(Console.ReadLine());

            // Calculo

            comissao = vendas * (0.15M);
            valorFinal = salario + comissao;

            // Mensagem

            Console.WriteLine("O Funcionário " + vendedor + " tem um salário de R$ "
                + salario + " e este mês teve uma comissão de R$ "
                + comissao + ". Vai receber no final do mês R$ " + valorFinal);

            // Limpar e encerrar

            Console.ReadKey();
            Console.Clear();

        }
    }
}
