using System;
using System.Globalization;

namespace treinamentos
{
    class treinamento
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double n = double.Parse(Console.ReadLine());
            Soma(n);
            double Resultado = Soma(n);
            Console.WriteLine(Resultado);
        }


        static double Soma(double n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + Soma(n - 1);
            }
                

        }
    }   
}