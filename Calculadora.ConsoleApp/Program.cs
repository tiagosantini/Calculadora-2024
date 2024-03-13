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
    // Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática

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

                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                    break;

                Console.WriteLine("Digite o primeiro número:");

                string primeiroNumeroString = "";

                primeiroNumeroString = Console.ReadLine();

                int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

                Console.WriteLine("Digite o segundo número:");

                string segundoNumeroString = Console.ReadLine();

                int segundoNumero = Convert.ToInt32(segundoNumeroString);

                int resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }


                Console.WriteLine("O resultado é: " + resultado);

                Console.ReadLine();
            }
        }
    }
}
