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

    // Variáveis
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024\n");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                // || = comparação não obrigatória (só um precisa ser verdadeiro) 
                if (operacao == "S" || operacao == "s")
                    break;

                // && = comparação obrigatória
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();

                    continue;
                }

                Console.WriteLine("Digite o primeiro número:");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                double primeiroNumero = Convert.ToDouble(primeiroNumeroString);

                Console.WriteLine("Digite o segundo número:");

                string segundoNumeroString = Console.ReadLine();

                double segundoNumero = Convert.ToDouble(segundoNumeroString);

                double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    // checar se o segundo número é 0

                    while (segundoNumero == 0)
                    {
                        // caso for 0, pedir para o usuário digitar de novo
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente!");

                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número novamente: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }

                    // caso não, divir
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();
            }
        }
    }
}
