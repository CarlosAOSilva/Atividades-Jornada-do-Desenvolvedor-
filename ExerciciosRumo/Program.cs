using System;

namespace ExerciciosRumo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var soma1 = new Calculos();
            soma1.Ex1();

            var resultados = new Calculos();
            resultados.Ex2();

            var consumo = new Calculos();
            consumo.Ex3();

            var troca = new Calculos();
            troca.Ex6();

            var dinheiro = new Calculos();
            dinheiro.Ex9();

            var loja = new Calculos();
            var produtos = loja.Ex10();

            Console.WriteLine("O valor total de sua compra é de R$ " 
                + produtos.valorTotal + ", sendo o valor de cada prestação R$ " 
                + produtos.valorTotal2);
            Console.ReadKey();
            Console.Clear();

            var produto = new Calculos();
            produto.Ex11();

            var Cliente = new Calculos();
            Cliente.Ex12();

            var mensagem = new Calculos();
            mensagem.Ex13();

            var entre = new Calculos();
            entre.Ex14();

            var entre1 = new Calculos();
            entre1.Ex15();

            var entre2 = new Calculos();
            entre2.Ex17();

            var ex18 = new Calculos();
            ex18.Ex18();

            var ex19 = new Calculos();
            ex19.Ex19();

            var carro = new Calculos();
            carro.Ex20();

            var ex21 = new Calculos();
            ex21.Ex21();

            var ex22 = new Calculos();
            ex22.Ex22();

            var ex23 = new Calculos();
            ex23.Ex23();

            var ex24 = new Calculos();  
            ex24.Ex24();

            var ex25 = new Calculos();
            ex25.Ex25();

            var ex26 = new Calculos();
            ex26.Ex26();
            
            var vendas = new Calculos();
            vendas.Ex27();

            var ex28 = new Calculos();
            ex28.Ex28();

            var ex29 = new Calculos();
            ex29.Ex29();

            var ex30 = new Calculos();
            ex30.Ex30();

            var ex31 = new Calculos();
            ex31.Ex31();

            var ex32 = new Calculos();
            ex32.Ex32();

            var ex33 = new Calculos();
            ex33.Ex33();

            var ex34 = new Calculos();
            ex34.Ex34();

            var ex35 = new Calculos();
            ex35.Ex35();

            var ex36 = new Calculos();
            ex36.Ex36();

            var ex37 = new Calculos();
            ex37.Ex37();

            var ex38 = new Calculos();
            ex38.Ex38Ex39();

            var ex40= new Calculos();
            ex40.Ex40();
        }
    }
}
