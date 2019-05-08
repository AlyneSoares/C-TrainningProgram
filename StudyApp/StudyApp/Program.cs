using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyApp
{
    namespace StudyApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                string message1 = "type a number - not zero";
                Console.WriteLine(message1);

                float n = float.Parse(Console.ReadLine());

                string resposta = "";
                for (int i = 2; resposta != "y"; i++)
                {
                    Console.WriteLine(n + " é maior que 1000? Y / N ? ");
                    resposta = Console.ReadLine();

                    if (n % i == 0)
                    {
                        n = n / i;                        
                    }
                    else
                    {
                        n = n * i;
                    }

                    Console.WriteLine(n);
                    string result = n % 2 == 0 ? "par" : "impar";

                    Console.WriteLine(result);
                }
                Console.WriteLine("Missão Cumprida");                                              
            }            
        }
    }
}