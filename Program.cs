using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe Converter converte temperaturas para Celsius ou Fahrenheit
            Converter celsius = new Converter();
            Console.WriteLine(celsius.toFahrenheit(50));

            Converter fahrenheit = new Converter();
            Console.WriteLine(fahrenheit.toCelsius(50));


            // classe Matematica realiza operações simples de adição e multiplicação
            Matematica calculo1 = new Matematica();
            Console.WriteLine(calculo1.Adicao(5, 10));

            Matematica calculo2 = new Matematica();
            Console.WriteLine(calculo2.Multiplicacao(5, 10));


            // classe ImparPar diz se o numero inserido é impar ou par
            ImparPar n1 = new ImparPar(7);
            Console.WriteLine(n1.resultado);
        }
    }
}