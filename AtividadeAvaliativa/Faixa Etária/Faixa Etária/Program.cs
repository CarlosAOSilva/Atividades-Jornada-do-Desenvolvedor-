namespace Faixa_Etaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int idade;

                    Console.Write("Qual a sua idade? ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    if (idade < 0 || idade > 120)
                        throw new InvalidOperationException();

                    else if (idade >= 5 & idade <= 7)
                    {
                        Console.WriteLine("Você vai pertencer a equipe INFANTIL A");
                    }

                    else if (idade >= 8 & idade <= 10)
                    {
                        Console.WriteLine("Você vai pertencer a equipe INFANTIL B");
                    }

                    else if (idade >= 11 & idade <= 13)
                    {
                        Console.WriteLine("Você vai pertencer a equipe JUVENIL A");
                    }
                    else if (idade >= 14 & idade <= 17)
                    {
                        Console.WriteLine("Você vai pertencer a equipe JUVENIL B");
                    }

                    else if (idade >= 18 & idade <= 25)
                    {
                        Console.WriteLine("Você vai pertencer a equipe SÊNIOR ");
                    }
                    else if (idade <= 4 || idade >= 26)
                    {
                        Console.WriteLine("Infelizmente você não possui a idade necessária para Participar!!!");
                        Console.WriteLine("A Idade tem que estar entre 5 e 25 anos!!!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                catch(InvalidOperationException)
                {
                    Console.WriteLine("Não é uma Idade Válida");
                    Console.WriteLine("Pressione uma tecla para continuar!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro!! Digite Apenas Números Inteiros");
                    Console.WriteLine("Pressione uma tecla para continuar!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}