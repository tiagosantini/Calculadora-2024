using System.Runtime.ExceptionServices;

namespace Calculadora.ConsoleApp
{
    // Iniciantes

    // Requisito 01 
    // Nossa calculadora deve ter a possibilidade de somar dois números

    // Requisito 02 
    // Nossa calculadora deve ter a possibilidade de fazer várias operações de soma

    // Requisito 03 
    // Nossa calculadora deve ter a possibilidade de fazer várias operações de soma e de subtração

    // Requisito 04 
    // Nossa calculadora deve ter a possibilidade de fazer as quatro operações básicas da matemática

    // Com experiência

    // Requisito 05 
    // Nossa calculadora deve realizar as operações com "0"

    // Requisito 06
    // Nossa calculadora deve validar a opções do menu 

    // Requisito 07
    // Nossa calculadora deve realizar as operações com números com duas casas decimais

    // Requisito 08
    // Dado um número, nossa calculadora deve ser capaz de gerar a tabuada do mesmo até o 10

    // Variáveis
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = MostrarMenu();
                
                if (opcao == "S" || opcao == "s")
                    break;

                if (OpcaoInvalida(opcao))
                {
                    ExibirMensagemErro();
                    continue;
                }

                else if (opcao == "5")
                    GerarTabuada();
                
                else
                    RealizarCalculo(opcao);
            }
        }

        static string MostrarMenu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara 2024\n");

            Console.WriteLine("Digite 1 para Adicionar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir");
            Console.WriteLine("Digite 5 para Gerar a Tabuada de um Número");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        static bool OpcaoInvalida(string opcao)
        {
            bool opcaoInvalida =
                opcao != "1" &&
                opcao != "2" &&
                opcao != "3" &&
                opcao != "4" &&
                opcao != "5" &&
                opcao != "S" &&
                opcao != "s";

            return opcaoInvalida;
        }

        static void ExibirMensagemErro()
        {
            Console.WriteLine("Operação inválida, tente novamente...");
            Console.ReadLine();
        }

        static void RealizarCalculo(string opcao)
        {
            Console.WriteLine("Digite o primeiro número:");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;
            switch (opcao) {
                case "1":
                    resultado = primeiroNumero + segundoNumero;
                    break;

                case "2":
                    resultado = primeiroNumero - segundoNumero;
                    break;

                case "3":
                    resultado = primeiroNumero * segundoNumero;
                    break;

                case "4":
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente!");

                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número novamente: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    break;
            }

            ExibirResultado(resultado);
        }

        static void ExibirResultado(double resultado)
        {
            Console.WriteLine("O resultado da operação é: " + resultado);
            Console.ReadLine();
        }

        static void GerarTabuada()
        {
            Console.Write("Digite o número para gerar a tabuada: ");

            int tabuada = Convert.ToInt32(Console.ReadLine());          

            for (int i = 1; i <= 10; i++)
            {
                int resto = i % 2;

                if (resto == 0)
                    Console.BackgroundColor = ConsoleColor.Red;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                int resultadoMultiplicacao = tabuada * i;

                Console.WriteLine(tabuada + " x " + i + " = " + resultadoMultiplicacao);
            }

            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
