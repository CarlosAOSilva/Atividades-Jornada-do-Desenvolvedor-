using System;

namespace AtividadeMediaNotas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Atividade RUMO ###\n");
            Console.WriteLine("### Atividade 01 Notas ###\n");

            var aproveitamento = new Entidades.Dados();

            Console.WriteLine("Há quantos alunos na turma?");
            aproveitamento.quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor da Prova?");
            aproveitamento.valorProva = Convert.ToInt32(Console.ReadLine());

            for (int cnt = 0; cnt < aproveitamento.quantidadeAlunos; cnt++)
            {
                Console.WriteLine("Nota do " + (cnt + 1) + "º Aluno");
                aproveitamento.nota[cnt] = Convert.ToDecimal(Console.ReadLine());

                if (aproveitamento.nota[cnt] < 0 || aproveitamento.nota[cnt] > aproveitamento.valorProva)
                {
                    Console.WriteLine("\nNota inválida! Digite uma nota entre 0 e " + aproveitamento.valorProva
                        + ". Por favor repita o processo com notas válidas");
                    break;
                }

                aproveitamento.soma += aproveitamento.nota[cnt];

            }

            if (aproveitamento.soma == 0)
            {
                Console.WriteLine("A turma de " + aproveitamento.quantidadeAlunos
               + " estudantes, zeraram a prova!!! ");
            }

            else
            {
                aproveitamento.media = (aproveitamento.soma / aproveitamento.quantidadeAlunos);
                Console.WriteLine("Media da turma de " + aproveitamento.quantidadeAlunos
                    + " alunos, foi de " + aproveitamento.media + "pts");
            }


        }
    }
}

