using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRumo
{
    public class Calculos
    {
        public void Ex1()
        {
            int x, y, soma;

            Console.WriteLine("Qual o valor de x?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o valor de y?");
            y = Convert.ToInt32(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("A soma dos dois numeros será: " + soma);
            Console.ReadKey();
            Console.Clear();

        }
        public void Ex2()
        {
            double X, Y, resultado1, resultado2, resultado3, resultado4;

            Console.WriteLine("Digite um valor: ");
            X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            Y = Convert.ToDouble(Console.ReadLine());

            resultado1 = X + Y;
            resultado2 = X - Y;
            resultado3 = X * Y;
            resultado4 = X / Y;

            Console.WriteLine("Os resultados são: adição = " + resultado1);
            Console.WriteLine("Os resultados são: subtração = " + resultado2);
            Console.WriteLine("Os resultados são: multiplicação = " + resultado3);
            Console.WriteLine("Os resultados são: divisão = " + resultado4);
            Console.ReadKey();
            Console.Clear();
        }
        public void Ex3()
        {
            decimal distancia, combustivel, consumoMedio;

            Console.WriteLine(" Qual a distância percorrida? ");
            distancia = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quantos litros o veiculo consumiu? ");
            combustivel = Convert.ToDecimal(Console.ReadLine());

            consumoMedio = distancia / combustivel;

            Console.WriteLine("O consumo medio do seu carro é de: " + consumoMedio + " km/l");
            Console.ReadKey();
            Console.Clear();

        }

        public void Ex6()
        {
            int a, b, c;

            Console.WriteLine("Qual o valor de A?");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o valor de B?");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A era igual " + a);
            Console.WriteLine("B era igual " + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("A é igual " + a);
            Console.WriteLine("B é igual " + b);
            Console.ReadKey();
            Console.Clear();

        }

        public void Ex9()
        {
            double valor, rendimento, valortotal, rendimento1;
            int tempo;

            Console.WriteLine("Quanto você vai depositar?");
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por quantos meses tempo? (Apenas Núemros)");
            tempo = Convert.ToInt32(Console.ReadLine());

            rendimento = Math.Pow(1 + (0.70 / 100), tempo);
            valortotal = rendimento * valor;
            rendimento1 = valortotal - valor;

            Console.WriteLine("O rendimento total do seu valor de R$ "
                 + valor + " foi de R$ "
                 + rendimento1 + " somando R$" + valortotal);

            Console.ReadKey();
            Console.Clear();
        }

        public Entidades.Dados Ex10()
        {
            var produtos = new Entidades.Dados();


            for (int cnt = 0; cnt < 5; cnt++)
            {

                Console.WriteLine("Informe o valor do " + (cnt + 1) + "ª produto");
                produtos.produtos1[cnt] = Convert.ToDecimal(Console.ReadLine());

                produtos.valorTotal += produtos.produtos1[cnt];

            }

            Console.WriteLine("Por quanto você quer dividir?");
            produtos.prestacoes = Convert.ToDecimal(Console.ReadLine());

            produtos.valorTotal2 = (produtos.valorTotal / produtos.prestacoes);

            return produtos;

        }

        public void Ex11()
        {
            double valortotal, produto, acrescimo;

            Console.WriteLine("Qual o valor do produto?");
            produto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual será o percentual de acrescimo do produto? (APRESENTE APENAS NUMEROS)");
            acrescimo = Convert.ToDouble(Console.ReadLine());

            valortotal = produto + (produto * (acrescimo / 100));

            Console.WriteLine("O produto custava R$ " + produto
                + " teve um aumento de "
                + acrescimo + "%, o valor passou a ser R$ "
                + valortotal);

            Console.ReadKey();
            Console.Clear();

        }
        public void Ex12()
        {
            double custoFabrica, custoCliente, valor, valor1, valor2;

            Console.WriteLine("Qual o valor do custo de fabrica do veiculo?");
            custoFabrica = Convert.ToDouble(Console.ReadLine());

            valor = custoFabrica * 0.45;
            valor1 = valor + custoFabrica;
            valor2 = valor1 * 0.28;
            custoCliente = valor2 + valor1;

            Console.WriteLine("O valor final do veículo será de R$ "
                + custoCliente + ", sendo o valor de custo de fabrica R$ "
                + custoFabrica);

            Console.ReadKey();
            Console.Clear();

        }
        public void Ex13()
        {

            int n;

            Console.WriteLine("Informe um valor até 20! ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 10)
                Console.WriteLine("Olá, Seja bem vindo!!!");
            else if (n < 10)
                Console.WriteLine("Eliminado!");

            Console.ReadKey();
            Console.Clear();

        }

        public void Ex14()
        {
            const int numeroQtd = 2;
            int[] numeros = new int[numeroQtd];
            int menor = 0, maior = 0;


            for (int i = 0; i < numeroQtd; i++)
            {
                Console.WriteLine((i + 1) + "ª numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];

                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];

                }
            }
            Console.WriteLine("O maior valor é: " + maior);
            Console.ReadKey();
            Console.Clear();
        }

        public void Ex15()
        {
            int n = 0;

            Console.WriteLine("Informe um valor: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n >= 100 & n <= 200)
            {
                Console.WriteLine(n + " está situado entre 100 e 200");
            }
            else
                Console.WriteLine(n + " não está situado entre 100 e 200");

            Console.ReadKey();
            Console.Clear();
        }
        public void Ex17()
        {
            int cont;
            int num;

            List<int> list = new List<int>();
            Random ranNum = new Random();
            List<int> validNumber = new List<int>();

            for (cont = 1; cont < 80; cont++)
            {
                num = ranNum.Next(0, 300);
                if (num >= 10 && num <= 150)
                {
                    validNumber.Add(num);
                }
                list.Add(num);
            }
            Console.WriteLine("Numeros Sorteados: {0}", string.Join(",", list));
            Console.WriteLine("");

            Console.WriteLine("Numeros entre 10 e 150: {0}", string.Join(",", validNumber));


            Console.ReadKey();
            Console.Clear();
        }
        public void Ex18()
        {
            int idade, maIdade, meIdade, maiIdade = 0, menIdade = 0, pessoa;

            List<int> list = new List<int>();
            Random ranNum = new Random();
            List<int> validNumber = new List<int>();

            for (pessoa = 1; pessoa < 75; pessoa++)
            {
                idade = ranNum.Next(0, 75);
                if (idade >= 18)
                {
                    maIdade = idade;
                    maiIdade = maiIdade + 1;
                    validNumber.Add(maIdade);
                    Console.WriteLine("Maior de Idade: {0}", string.Join(",", maIdade));
                }
                {
                    if (idade <= 18)
                    {
                        meIdade = idade;
                        menIdade = menIdade + 1;
                        validNumber.Add(meIdade);
                        Console.WriteLine("Menor de Idade: {0}", string.Join(",", meIdade));
                    }
                    list.Add(idade);
                }
            }
            Console.WriteLine("Há " + maiIdade + " pessoas maiores de idade e "
                + menIdade + " pessoas menores de idade");
            Console.ReadKey();
            Console.Clear();

        }

        public void Ex19()
        {
            string nomePessoa;
            int sexo, sexoM = 0, sexoF = 0;

            for (int cnt = 0; cnt < 5; cnt++)
            {

                Console.WriteLine("Olá, qual o seu nome?");
                nomePessoa = Console.ReadLine();

                Console.WriteLine("Informe seu sexo, (1) para masculino e (2) para feminino?");
                sexo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (sexo == 1)
                {
                    sexoM = sexoM + 1;

                    Console.WriteLine(nomePessoa + " , sexo Masculino");
                }
                else if (sexo == 2)
                {
                    Console.WriteLine(nomePessoa + ", sexo feminino");
                    sexoF = sexoF + 1;
                }
            }
            Console.WriteLine("Há " + sexoM + " do sexo masculino e "
                    + sexoF + " do sexo feminino");

            Console.ReadKey();
            Console.Clear();
        }

        public void Ex20()
        {

            var veiculos = new List<Entidades.Dados1>();

            while (true)
            {
                Console.WriteLine("Qual o ano do veículo?");
                var anoVeiculo = Console.ReadLine();

                Console.WriteLine("Qual o valor do veículo?");
                var valorVeiculo = Console.ReadLine();

                var veiculo = new Entidades.Dados1();

                veiculo.Ano = short.Parse(anoVeiculo);
                veiculo.Valor = decimal.Parse(valorVeiculo);
                veiculo.Desconto = CalcularValorVeiculoComDesconto(veiculo.Valor, veiculo.Ano);
                veiculos.Add(veiculo);

                Console.WriteLine("Para finalizar aperte N");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    break;
            }

            ContabilizarExibir(veiculos);
        }

        private decimal CalcularValorVeiculoComDesconto(decimal valorVeiculo, short anoVeiculo)
        {
            if (anoVeiculo < 2000)
                return valorVeiculo * 0.88M;
            else
                return valorVeiculo * 0.93M;
        }
        private void ContabilizarExibir(List<Entidades.Dados1> veiculos)
        {
            var totalCarros = veiculos.Count();
            var totalMenor2000 = 0;
            decimal totalDesconto = 0;
            decimal totalPagar = 0;
            foreach (var veiculo in veiculos)
            {
                if (veiculo.Ano < 2000)
                    totalMenor2000++;

                totalDesconto += veiculo.Valor - veiculo.Desconto;
                totalPagar += veiculo.Desconto;
            }

            ExibirResultado(totalCarros, totalMenor2000, totalDesconto, totalPagar);
        }
        private void ExibirResultado(int totalCarros, int totalMenor2000, decimal valorDesconto, decimal valorPagar)
        {
            Console.WriteLine("O comprador ganhou R$ " +
                valorDesconto +
                " de desconto, e vai ter que pagar apenas: R$ " + valorPagar);

            Console.WriteLine("Em um total de " +
                totalMenor2000 +
                " carros com ano inferior a 2000");
            Console.WriteLine("Em um total geral de " +
               totalCarros +
               " carros.");
            {
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void Ex21()

        {
            string nome, saúde;
            int sexo, idade, condição, Ccondição = 0, Scondição = 0;

            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine("Informe sua idade? (Numeros Apenas!!!)");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe seu sexo, (1) para masculino e (2) para feminino?");
                sexo = Convert.ToInt32(Console.ReadLine());

                if (sexo == 1)
                {
                    Console.WriteLine("Saúde?(BOA), (MEDIANA) ou (RUIM)");
                    saúde = Console.ReadLine();

                    Console.WriteLine("Está em condições de servir? (3) PARA NÃO e (4) PARA SIM");
                    condição = Convert.ToInt32(Console.ReadLine());

                    if (condição == 3)
                    {
                        Ccondição = Ccondição + 1;
                        Console.WriteLine(nome + ", sexo masculino, "
                          + idade + " anos, está com a sáude "
                          + saúde + ", após várias analisas, chegamos a conclusão que " +
                          " não está apto para servir");
                    }

                    else if (condição == 4)
                    {

                        Scondição = Scondição + 1;
                        Console.WriteLine(nome + ", sexo masculino, "
                            + idade + " anos, está com a sáude "
                            + saúde + ", após várias analisas, chegamos a conclusão que " +
                            " está apto para servir");
                    }
                }

                if (sexo == 2)
                {
                    Console.WriteLine("Saúde?(BOA), (MEDIANA)ou(RUIM)");
                    saúde = Console.ReadLine();

                    Console.WriteLine("Está em condições de servir? (3) PARA NÃO e (4) PARA SIM");
                    condição = Convert.ToInt32(Console.ReadLine());

                    if (condição == 4)

                    {
                        Ccondição = Ccondição + 1;
                        Console.WriteLine(nome + ", sexo feminino, "
                          + idade + " anos, está com a sáude "
                          + saúde + " ,após várias analisas, chegamos a conclusão que " +
                          " está apto para servir");
                    }

                    else if (condição == 3)

                        Scondição = Scondição + 1;

                    Console.WriteLine(nome + ", sexo feminino, "
                        + idade + " anos, está com a sáude "
                        + saúde + ", após várias analisas, chegamos a conclusão que " +
                        "não está apto para servir");
                }
            }
            Console.WriteLine("Há " + Ccondição + " com condições de servir e "
                              + Scondição + " sem condições de servir");
            Console.ReadKey();
            Console.Clear();
        }
        public void Ex22()
        {

            decimal Custo, Venda, CustoTotal = 0, VendaTotal = 0, Soma = 0, Soma1 = 0, Somav = 0, Somac = 0;

            for (int cnt = 0; cnt < 5; cnt++)
            {
                Console.WriteLine("Qual o valor do produto?");
                Custo = Convert.ToDecimal(Console.ReadLine());
                Soma += Custo;
                CustoTotal = CustoTotal + 1;

                Console.WriteLine("Qual o valor de venda?");
                Venda = Convert.ToDecimal(Console.ReadLine());
                Soma1 += Venda;
                VendaTotal = VendaTotal + 1;

                if (Custo > Venda)
                {
                    Console.WriteLine("Houve prejuízo");
                }

                else if (Custo < Venda)
                {
                    Console.WriteLine("Houve Lucro");
                }
                else if (Custo == Venda)
                {
                    Console.WriteLine("Não houve lucro e nem prejuízo!!!");
                }
                Console.WriteLine("Para finalizar aperte N");
                Console.Clear();
                if (Console.ReadKey().Key == ConsoleKey.N)
                    break;
            }

            Somav = Soma1 / VendaTotal;
            Somac = Soma / CustoTotal;

            Console.WriteLine("Media do preço de vendas foi R$" + Somav
                + " e a media de preço de custo foi de R$" + Somac);
            Console.ReadKey();
            Console.Clear();

        }
        public void Ex23()
        {
            int numero;

            Console.WriteLine("Informe um numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 80)
                Console.WriteLine(numero + " é maior que 80");

            else if (numero < 25)
                Console.WriteLine(numero + " é menor que 25");

            else if (numero == 40)
                Console.WriteLine(numero + " é igual a 40");
            else if (numero <= 80 & numero >= 25 & numero != 40)
                Console.WriteLine("Erro!!! Aperte ENTER");

            Console.ReadKey();
            Console.Clear();
        }
        public void Ex24()
        {
            int numero;

            Console.WriteLine("Informe um valor: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("Este numero é positivo");
            else if (numero < 0)
                Console.WriteLine("Este numero é negativo!!!");
            else if (numero == 0)
                Console.WriteLine("Este numero é igual a zero");

            Console.ReadKey();
            Console.Clear();
        }
        public void Ex25()
        {
            int num1, num2;

            Console.WriteLine("Informe um numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)

                Console.WriteLine("Os numeros fornecidos, são iguais");

            if (num1 != num2)
                Console.WriteLine("Os numeros fornecidos, são diferentes");

            if (num1 > num2)
                Console.WriteLine("O maior valor é: " + num1);
            else if (num1 < num2)
                Console.WriteLine("O maior valor é: " + num2);

            Console.ReadKey();
            Console.Clear();
        }


        public void Ex26()
        {
            const int numeroQtd = 5;
            int[] c = new int[numeroQtd];

            for (int i = 0; i < numeroQtd; i++)
            {
                Console.WriteLine((i + 1) + "ª numero de 1 até 5: ");
                c[i] = Convert.ToInt32(Console.ReadLine());
                {
                    if (c[i] > 5 && c[i] <= 0)
                        Console.WriteLine("NUMERO INVALIDO");
                    {
                        if (c[i] == 1)
                            Console.WriteLine("UM");
                        else if (c[i] == 2)
                            Console.WriteLine("DOIS");
                        else if (c[i] == 3)
                            Console.WriteLine("TRÊS");
                        else if (c[i] == 4)
                            Console.WriteLine("QUATRO");
                        else if (c[i] == 5)
                            Console.WriteLine("CINCO");
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();

        }
        public void Ex27()
        {
            var listaVeiculos = new List<Entidades.Dados2>();

            while (true)
            {
                var veiculo = FazerPerguntas();

                if (veiculo == null)
                    break;

                veiculo = RealizarCalculos(veiculo);
                listaVeiculos.Add(veiculo);
            }

            ExibirResultados(listaVeiculos);
        }
        private Entidades.Dados2 FazerPerguntas()
        {
            var veiculo = new Entidades.Dados2();

            Console.WriteLine("Qual o valor do veiculo?");
            Console.WriteLine("Ou digite 0 para cancelar!");
            veiculo.ValorVeiculo = Convert.ToDecimal(Console.ReadLine());

            if (veiculo.ValorVeiculo == 0)
                return null;

            Console.WriteLine("Qual o tipo combustivel do carro?(1) para Alcool, (2) para Gasolina, (3) para Diesel");
            veiculo.TipoCombustivel = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            return veiculo;
        }

        private Entidades.Dados2 RealizarCalculos(Entidades.Dados2 veiculo)
        {
            decimal porcentagemDesconto = 0M;

            switch (veiculo.TipoCombustivel)
            {
                case 1:
                    porcentagemDesconto = 0.25M;
                    break;
                case 2:
                    porcentagemDesconto = 0.21M;
                    break;
                case 3:
                    porcentagemDesconto = 0.14M;
                    break;
                default:
                    break;
            }

            veiculo.ValorDesconto = veiculo.ValorVeiculo * porcentagemDesconto;
            veiculo.ValorFinal = veiculo.ValorVeiculo - veiculo.ValorDesconto;

            return veiculo;
        }
        private void ExibirResultados(List<Entidades.Dados2> veiculos)
        {
            decimal totalPagar = 0M, totalDesconto = 0M;

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(" Valor Original do Veiculo: R$" + veiculo.ValorVeiculo +
                    " Valor Desconto: R$" + veiculo.ValorDesconto +
                    " Valor a Pagar: R$" + veiculo.ValorFinal);
                totalPagar += veiculo.ValorFinal;
                totalDesconto += veiculo.ValorDesconto;
            }

            Console.WriteLine("O valor total de desconto: R$" +
                totalDesconto +
                " e o total a pagar: R$"
                + totalPagar);

            Console.ReadKey();
            Console.Clear();
        }

        public void Ex28()
        {
            var dados = new List<Entidades.Funcionario>();

            while (true)
            {
                decimal salarioMinimo = 1212M;
                decimal novoSalario = 0M;


                Console.WriteLine("Qual o seu nome?");
                var nomes = Console.ReadLine();

                Console.WriteLine("Qual o seu salario?");
                var salarios = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("SALARIO MINIMO R$1212,00");

                if (salarios < (3 * salarioMinimo))
                {
                    novoSalario = salarios * 0.5M + salarios;
                    Console.WriteLine("Seu novo sálario será de R$ " + novoSalario);
                }
                else if (salarios >= (3 * salarioMinimo) & salarios <= (10 * salarioMinimo))
                {
                    novoSalario = salarios * 0.2M + salarios;
                    Console.WriteLine("Seu novo sálario será de R$ " + novoSalario);
                }
                else if (salarios >= (11 * salarioMinimo) & salarios <= (20 * salarioMinimo))
                {
                    novoSalario = salarios * 0.15M + salarios;
                    Console.WriteLine("Seu novo sálario será de R$ " + novoSalario);
                }
                else if (salarios >= (21 * salarioMinimo))
                {
                    novoSalario = salarios * 0.1M + salarios;
                    Console.WriteLine("Seu novo sálario será de R$ " + novoSalario);
                }

                var dado = new Entidades.Funcionario();

                dado.nome = (nomes);
                dado.salario = (salarios);
                dado.novosSalarios = (novoSalario);
                dados.Add(dado);

                Console.WriteLine("Para finalizar aperte N");

                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.Clear();
                    break;
                }

            }
            decimal totalSalario = 0M, folhaPagamento = 0M;

            foreach (var obj in dados)
            {
                totalSalario += obj.salario;
                folhaPagamento += obj.novosSalarios;

                Console.WriteLine("Nome: {0}", obj.nome);
                Console.WriteLine("Salario: R$ {0}", obj.salario);
                Console.WriteLine("Novo Salario:R$ {0}", obj.novosSalarios);

            }

            Console.WriteLine("Total do valor com reajuste: R$ " + folhaPagamento);

            Console.ReadKey();
            Console.Clear();


        }

        public void Ex29()

        {
            int mes;

            Console.WriteLine("Informe o nº do Mês");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes >= 13 && mes <= 0)
                Console.WriteLine("Mês Invalido!!!");
            else if (mes == 1)
                Console.WriteLine("Janeiro");
            else if (mes == 2)
                Console.WriteLine("Fevereiro");
            else if (mes == 3)
                Console.WriteLine("Março");
            else if (mes == 4)
                Console.WriteLine("Abril");
            else if (mes == 5)
                Console.WriteLine("Maio");
            else if (mes == 6)
                Console.WriteLine("Junho");
            else if (mes == 7)
                Console.WriteLine("Julho");
            else if (mes == 8)
                Console.WriteLine("Agosto");
            else if (mes == 9)
                Console.WriteLine("Setembro");
            else if (mes == 10)
                Console.WriteLine("Outubro");
            else if (mes == 11)
                Console.WriteLine("Novembro");
            else if (mes == 12)
                Console.WriteLine("Dezembro");

            Console.ReadKey();
            Console.Clear();

        }

        public void Ex30()
        {
            var dados = new List<Entidades.Dados3>();

            while (true)
            {
                Console.WriteLine("Qual o seu nome?");
                var nomes = Console.ReadLine();

                Console.WriteLine("Sexo? [M] para masculino e [F] para feminino!!!");
                var sexos = Console.ReadLine();

                Console.WriteLine("Quantos anos? Digite apenas algarismos");
                var idades = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o seu salario?");
                var salarios = Convert.ToDecimal(Console.ReadLine());

                var dado = new Entidades.Dados3();

                dado.nome = (nomes);
                dado.sexo = (sexos);
                dado.idade = (idades);
                dado.salario = (salarios);
                dados.Add(dado);

                Console.WriteLine("Para finalizar aperte N");

                if (Console.ReadKey().Key == ConsoleKey.N)
                    Console.Clear();
                break;

            }

            foreach (var obj in dados)
            {
                Console.WriteLine("Nome: {0}", obj.nome);
                Console.WriteLine("Idade: {0}", obj.idade);
                Console.WriteLine("Sexo: {0}", obj.sexo);
                Console.WriteLine("Salario: R$ {0}", obj.salario);

            }
            Console.ReadKey();
            Console.Clear();
        }

        public void Ex31()
        {

            int n = 0;
            List<int> crescente = new List<int>();

            while (n <= 2)
            {
                Console.WriteLine("Digite seu " + (n + 1) + "º número");
                crescente.Add(int.Parse(Console.ReadLine()));
                n++;
            }
            crescente.Sort();//para organizar

            Console.WriteLine();
            Console.WriteLine("Os numeros digitados são:");

            foreach (int numero in crescente)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void Ex32()
        {
            float valor = 0;

            Console.WriteLine("Informe um valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe um Simbolos Matematico: (+, -, * e  / )");
            char valor3 = char.Parse(Console.ReadLine());

            if (valor3 == '+')
            {
                valor = valor1 + valor2;
            }

            else if (valor3 == '-')
            {
                    valor = valor1 - valor2;
            }

            if (valor3 == '*')
            {
                valor = valor1 * valor2;
            }

            if (valor3 == '/')
            {
                if (valor2 == 0)
                {
                    //Environment.Exit(0);
                    Console.WriteLine("Divisão Inválida!!!");
                    Console.ReadKey();
                    
                }
                valor = valor1 / valor2; 
            }
     

            Console.WriteLine("Resultado: " + valor1 + " " + valor3 + " " + valor2 + " = " + valor);

            Console.ReadKey();
            Console.Clear();
        }

        public void Ex33()
        {

            int ladoA, ladoB, ladoC;

            Console.WriteLine("Informe um valor para A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um valor para B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um valor para C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if (ladoA == ladoB || ladoB == ladoC || ladoC == ladoA)
                Console.WriteLine("Triângulo Equilátero");

            else if (ladoA == ladoB || ladoB == ladoC || ladoC != ladoA)
                Console.WriteLine("Triângulo Isóceles");

            else if (ladoA != ladoB || ladoB != ladoC || ladoC != ladoA)
                Console.WriteLine("Triângulo Equilátero");

            Console.ReadKey();
            Console.Clear();
        }
        public void Ex34()
        {
            decimal horas, valor;
            int nivel;
            Console.WriteLine("Quantas horas você lecionou?");
            horas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual o seu Nivel?");
            nivel = Convert.ToInt32(Console.ReadLine());

            if (nivel == 1)
            {
                valor = horas * 12;
                Console.WriteLine("Você recebera este mês: R$ " + valor);
            }
            else if (nivel == 2)
            {
                valor = horas * 17;
                Console.WriteLine("Você recebera este mês: R$ " + valor);
            }
            else if (nivel == 3)
            {
                valor = horas * 25;
                Console.WriteLine("Você recebera este mês: R$ " + valor);
            }
            Console.ReadKey();
            Console.Clear();


        }
        public void Ex35()
        {
            int idade;

            Console.WriteLine("Qual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());


            if (idade >= 5 & idade <= 7)
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
                Console.WriteLine("IDADE FORA DA FAIXA ETÁRIA");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Ex36()
        {
            decimal valor;
            int N, luz;

            Console.WriteLine("Tipo de Cliente: (1) para Residêncial. (2) para Comercial e (3) para Indúdtrial");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quanto em KW/h, você consumiu?: ");
            luz = Convert.ToInt32(Console.ReadLine());

            if (N == 1)
            {
                valor = 0.6m * luz;
                Console.WriteLine("Sua conta este mês será de R$ " + valor);
            }
            else if (N == 2)
            {
                valor = 0.48m * luz;
                Console.WriteLine("Sua conta este mês será de R$ " + valor);
            }
            else if (N == 3)
            {
                valor = 1.29m * luz;
                Console.WriteLine("Sua conta este mês será de R$ " + valor);
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void Ex37()
        {
            var fichas = new List<Entidades.Dados4>();

            while (true)
            {
                Console.WriteLine("Qual o seu nome?");
                var Nome = Console.ReadLine();

                Console.WriteLine("Sexo? [1] para masculino e [2] para feminino!!!");
                var sexo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantos anos? Digite apenas algarismos");
                var idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o sua altura? Ex: 1,74 ");
                var altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Quanto você pesa? Ex: 45, Apenas Numeros");
                var peso = Convert.ToDouble(Console.ReadLine());

                var imc = (peso / (altura * altura));

                if (sexo == 1 & imc >= 40)
                {
                    Console.WriteLine("Homem com Obesidade Mórbida");
                }
                else if (sexo == 1 & imc >= 30 & imc <= 39)
                {
                    Console.WriteLine("Homem com Obesidade Moderada");
                }
                else if (sexo == 1 & imc >= 25 & imc <= 29)
                {
                    Console.WriteLine("Homem com Obesidade Leve");
                }
                else if (sexo == 1 & imc >= 20 & imc <= 25)
                {
                    Console.WriteLine("Homem com peso Normal");
                }
                else if (sexo == 1 & imc <= 19)
                {
                    Console.WriteLine("Homem abaixo do peso");
                }

                if (sexo == 2 & imc >= 38)
                {
                    Console.WriteLine("Mulher com Obesidade Mórbida");
                }
                else if (sexo == 2 & imc >= 29 & imc <= 37)
                {
                    Console.WriteLine("Mulher com Obesidade Moderada");
                }
                else if (sexo == 2 & imc >= 24 & imc <= 28)
                {
                    Console.WriteLine("Mulher com Obesidade Leve");
                }
                else if (sexo == 2 & imc >= 19 & imc <= 23)
                {
                    Console.WriteLine("Mulher com peso Normal");
                }
                else if (sexo == 2 & imc <= 19)
                {
                    Console.WriteLine("Mulher abaixo do peso");
                }

                var ficha = new Entidades.Dados4();

                ficha.Nome = (Nome);
                ficha.sexo = (sexo);
                ficha.idade = (idade);
                ficha.altura = (altura);
                ficha.peso = (peso);
                ficha.imc = (imc);
                fichas.Add(ficha);

                Console.WriteLine("Para finalizar aperte N");

                if (Console.ReadKey().Key == ConsoleKey.N)
                    Console.Clear();
                break;

            }
            foreach (var obj in fichas)
            {

                Console.WriteLine("Nome: {0}", obj.Nome);
                Console.WriteLine("Idade: {0}", obj.idade);
                Console.WriteLine("Altura: {0}", obj.altura);
                Console.WriteLine("Peso: {0}", obj.peso);
                Console.WriteLine("IMC: {0}", obj.imc);


            }
            Console.ReadKey();
            Console.Clear();

        }
        public void Ex38Ex39()
        {
            int nota1, nota2, nota3, media, matricula;
            string nome;

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua Matricula. (APENAS NÚMEROS)");
            matricula = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a nota do trabalho de laboratório: Até 10");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a nota da avaliação: Até 10");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a nota do exame final: Até 10");
            nota3 = Convert.ToInt32(Console.ReadLine());

            media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5));

            if (media >= 8.10)
                Console.WriteLine(nome + ", de matricula " + matricula + ",  obteve classificação A");
            else if (media >= 7.8 & media < 8.10)
                Console.WriteLine(nome + ", de matricula " + matricula + ",  obteve classificação B");
            else if (media >= 6.7 & media < 7.8)
                Console.WriteLine(nome + ", de matricula " + matricula + ",  obteve classificação C");
            else if (media >= 5.6 & media < 6.7)
                Console.WriteLine(nome + ", de matricula " + matricula + ",  obteve classificação D");
            else if (media < 5.6)
                Console.WriteLine(nome + ", de matricula " + matricula + ",  FOI REPROVADO!!!");

            Console.ReadKey();
            Console.Clear();

        }

        public void Ex40()
        {
            var fichas = new List<Entidades.Dados5>();

            while (true)
            {

                Console.WriteLine("Qual o seu nome?");
                var nomes = Console.ReadLine();

                Console.WriteLine("Qual a sua idade?");
                var idades = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o Grupo de Risco: (A) para Alto, (B) para Baixo e (M) para Medio");
                var riscos = Console.ReadLine();

                var ficha = new Entidades.Dados5();

                ficha.nome = (nomes);
                ficha.idade = (idades);
                ficha.risco = (riscos);
                fichas.Add(ficha);


                Console.WriteLine("Para finalizar aperte N");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    Console.Clear();
                break;

            }
            foreach (var obj in fichas)
            {
                Console.WriteLine("Nome: {0}", obj.nome);
                Console.WriteLine("Idade: {0}", obj.idade);
                Console.WriteLine("Risco de Sáude: {0}", obj.risco);

            }
            Console.ReadKey();
            Console.Clear();
        }


    }
}



















