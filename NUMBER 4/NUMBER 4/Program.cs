using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMBER_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                char[] Vowels = new char[5]
                {
                'a', 'e', 'i', 'o', 'u'
                };
                Console.Write("Enter an alphabet: ");
                char alphabet = Convert.ToChar(Console.ReadLine());

                int i = 0;
                if (alphabet == Vowels[i])
                {
                    Console.WriteLine("The alphabet is a vowel");
                }
                else if (alphabet != Vowels[i])
                {
                    Console.WriteLine("The alphabet is a consonant");
                }
                else
                {
                    Console.WriteLine("ERROR IN INPUT");
                }
       
            }
            catch
            {
                Console.WriteLine("Please check your input");
            }
            Console.ReadLine();
        }
    }
}
