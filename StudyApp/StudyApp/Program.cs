using System;
using System.Text.RegularExpressions;

namespace StudyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string resposta = "";
            int number = 0;
            
            Console.WriteLine("type a number - not zero");

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Try again");
                }
            }

            for (int i = 2; resposta != "y"; i++)
            {
                Console.WriteLine("{0} é maior que 1000? Y / N ? ", number);
                resposta = Console.ReadLine();

                if (number % i == 0)
                {
                    number /= i;                        
                }
                else
                {
                    number *= i;
                }

                Console.WriteLine(number);

                string result = number % 2 == 0 ? number + " é par" : number + " é impar";
                Console.WriteLine(result);
            }
            Console.WriteLine("Missão Cumprida");                                              
        }            
    }
}