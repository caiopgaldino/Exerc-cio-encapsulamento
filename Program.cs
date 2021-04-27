using System;
using System.Collections.Generic;
namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<Figura,string> figuras = new Dictionary<Figura, string>();
            int alternativa;
            int alt;
            double altura;
            double largura;
            double raio;
            double lado1;
            double lado2;
            double lado3;
            do
            {
                Console.WriteLine("Escolha o que fazer:");
                Console.WriteLine("1: Entre com valores e receba sua área e perímetro");
                Console.WriteLine("2: Escreva as informações das figuras que você já calculou");
                Console.WriteLine("Qualquer outro número: Sair do programa");
                alternativa=Convert.ToInt32(Console.ReadLine());
                if (alternativa == 1)
                {
                    Console.WriteLine("Qual tipo de figura você deseja calcular");
                    Console.WriteLine("1: Círculo");
                    Console.WriteLine("2: Retângulo");
                    Console.WriteLine("3: Triângulo");
                    alt= Convert.ToInt32(Console.ReadLine());
                    if(alt==1)
                    {
                        Console.WriteLine("Entre com o raio:");
                        raio = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Circulo(raio),"Esta figura é um círculo");
                    }
                    if( alt==2)
                    {
                        Console.WriteLine("Entre com altura e a largura, respectivamente:");
                        altura = Convert.ToDouble(Console.ReadLine());
                        largura = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Retangulo(altura, largura), "Esta figura é um retângulo");
                    }
                    if(alt==3)
                    {
                        Console.WriteLine("Entre com os 3 lados:");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        lado2 = Convert.ToDouble(Console.ReadLine());
                        lado3 = Convert.ToDouble(Console.ReadLine());
                        figuras.Add(new Triangulo(lado1,lado2,lado3), "Esta figura é um triângulo");
                    }

                    
                }
                if (alternativa == 2)
                {
                    foreach(KeyValuePair<Figura,string> fig in figuras)
                    {
                        Console.WriteLine("{0}", fig.Value);
                        Console.WriteLine("Área:\t\t{0:0.0}", fig.Key.Area);
                        Console.WriteLine("Perímetro\t{0:0.0}", fig.Key.Perimetro);
                    }
                   
                }

            } while (alternativa == 1 || alternativa == 2);
        }
    }
}
