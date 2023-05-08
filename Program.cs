using System.Globalization;

namespace calculadoraSimples
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora C#\r");
            Console.WriteLine("------------------------\n");

            Menu tc = new Menu();

            int tipoCalculo = tc.TipoCalculo();

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Calculadora calc = new Calculadora(num1, num2);

            Calcular(num1, num2, tipoCalculo, calc);

            Console.WriteLine($"{calc}");
        }

        static double Calcular(
            double num1,
            double num2,
            int tipoCalculo,
            Calculadora calc
        )
        {
            double resultado = 0;
            switch (tipoCalculo)
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
                case 5:
                    resultado = calc.Porcentagem(num1, num2);
                    break;
                case 6:
                    resultado = calc.Potencia(num1, num2);
                    break;
                case 7:
                    resultado = calc.Raiz(num1, num2);
                    break;
                default:
                    Console.WriteLine($"Número inválido digite outro número");
                    break;
            }

            return resultado;
        }
    }
}