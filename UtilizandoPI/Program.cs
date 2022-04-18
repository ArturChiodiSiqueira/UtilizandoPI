using System;

namespace UtilizandoPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;
 
            Console.Write("ENTRE COM O RAIO (r): ");
            raio = double.Parse(Console.ReadLine());

            if (raio < 0)
            {
                Console.WriteLine("\nINFORME UM RAIO POSITIVO!!");
            }
            else
            {
                double diametro = Calculadora.Diametro(raio);
                Console.WriteLine("\nO diametro é: " + diametro.ToString("F3"));

                double circunferencia = Calculadora.Circunferencia(raio);
                Console.WriteLine("A circunferência é: " + circunferencia.ToString("F3"));

                volume = Calculadora.Volume(raio);
                Console.WriteLine("O volume é: " + volume.ToString("F3"));
            }
            Console.WriteLine("\n\nFIM DO PROGRAMA!");
            Console.ReadKey();
        }
    }
}
