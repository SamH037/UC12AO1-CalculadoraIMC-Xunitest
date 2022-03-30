using System;
using System.Globalization;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, resultado;
            do
            {

                Console.Write("Informe seu peso atual");
                peso = double.Parse(Console.ReadLine());


                Console.Write("Informe sua altura");
                altura = double.Parse(Console.ReadLine());

                resultado = (peso / (altura * altura));
                

                if ((resultado > 1) && (resultado < 18.5))
                {
                    Console.WriteLine($"Subpeso: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 18.5) && (resultado < 25))
                {
                    Console.WriteLine($"Peso Ideal: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 25) && (resultado < 30))
                {
                    Console.WriteLine($"Sobrepeso: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 30) && (resultado < 35))
                {
                    Console.WriteLine($"Obesidade 1: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if ((resultado > 35) && (resultado < 40))
                {
                    Console.WriteLine($"Obesidade 2: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");
                }
                else if (resultado > 40)
                {
                    Console.WriteLine($"Obesidade 3: { resultado.ToString("N2", new CultureInfo("pt-BR"))}");

                }
                else if (resultado < 1)
                {
                    Console.WriteLine($"Dados inválidos, favor enviar dados no formato correto (ex: Altura: 0.00 ; peso: 000 (sem as gramas)");
                }
                
            } while (resultado < 1);
            {
                Console.WriteLine($"Calculo realizado, confira");
            }


            Console.ReadKey();
        }

    }
}
