using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadoraSimples
{
    public class Calculadora
    {

        public double Resultado { get; private set; }

        public double Num1 { get; private set; }

        public double Num2 { get; private set; }

        public Calculadora(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Adicao(double num1, double num2)
        {
            Resultado = num1 + num2;
            return Resultado;
        }

        public double Subtracao(double num1, double num2)
        {
            Resultado = num1 - num2;
            return Resultado;
        }

        public double Multiplicacao(double num1, double num2)
        {
            Resultado = num1 * num2;
            return Resultado;
        }

        public double Divisao(double num1, double num2)
        {
            Resultado = num1 / num2;
            return Resultado;
        }

        public double Porcentagem(double num1, double num2)
        {
            Resultado = ((num2 * 100) / num1) - 100;
            return Resultado;
        }

        public double Potencia(double num1, double num2)
        {
            Resultado = Math.Pow(num1, num2);
            return Resultado;
        }

        public override string ToString()
        {
            return $"Seu resultado é: {Resultado.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}