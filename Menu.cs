using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadoraSimples
{
    public class Menu
    {
        public int TipoCalculo()
        {
            Console.WriteLine("Tipo de Cálculo:");
            Console.WriteLine("\t1 - Adição");
            Console.WriteLine("\t2 - Subtração");
            Console.WriteLine("\t3 - Multiplicação");
            Console.WriteLine("\t4 - Divisão");
            Console.WriteLine("\t5 - Porcentagem");
            Console.WriteLine("\t6 - Potência");
            Console.WriteLine("\t7 - Raiz");
            Console.Write("Escolha o tipo de cálculo? ");

            int tipoCalculo = int.Parse(Console.ReadLine()!);

            return tipoCalculo;
        }
    }
}