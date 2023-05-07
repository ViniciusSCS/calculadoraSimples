using System.Globalization;

namespace calculadoraSimples
{
    public class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0;

            Console.WriteLine("Calculadora C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Operadores:");
            Console.WriteLine("\t1 - Adição");
            Console.WriteLine("\t2 - Subtração");
            Console.WriteLine("\t3 - Multiplicação");
            Console.WriteLine("\t4 - Divisão");
            Console.Write("Escolha o operador? ");

            int operador = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Calculadora calc = new Calculadora(num1, num2);

            switch (operador)
            {
                case 1:
                    resultado = calc.Adicao(num1, num2);
                    break;
                case 2:
                    resultado = calc.Subtracao(num1, num2);
                    break;
                case 3:
                    resultado = calc.Multiplicacao(num1, num2);
                    break;
                case 4:
                    resultado = calc.Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine($"Número inválido digite outro número");
                    break;
            }

            Console.WriteLine($"{calc}");

        }
    }
}