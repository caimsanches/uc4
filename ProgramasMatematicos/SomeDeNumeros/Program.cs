using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Double n1 = 0;
            Double n2 = 0;
            Double total = 0;
            string pergunta = "";

            Console.WriteLine("Programa que soma dois números. ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Digite o primeiro número que deseja somar: ");
            pergunta = Console.ReadLine();
            n1 = Convert.ToDouble(pergunta);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Digite o segundo número que deseja somar: ");
            pergunta = Console.ReadLine();
            n2 = Convert.ToDouble(pergunta);
            Console.WriteLine("-----------------------------------");
            total = n1 + n2;
            Console.WriteLine($"O total de {n1} + {n2} é : {total}");
            */


            Double n1 = 0;
            Double n2 = 0;
            Double total = 0;
            

            Console.WriteLine("Programa que multiplica dois números. ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Digite o primeiro número que deseja multiplicar: ");
            n1 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Digite o segundo número que deseja multiplicar: ");
        
            n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            total = n1 * n2;
            Console.WriteLine($"O total de {n1} x {n2} é : {total}");


            Console.ReadKey();
            
        }
    }
}
