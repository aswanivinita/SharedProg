using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36CountVowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            int countVowels = 0;
            int countConsonants = 0;
            int countSpace = 0;
            Console.WriteLine("Enter a string");
            string myString = Console.ReadLine();

            for(int i =0; i<myString.Length; i++)
            {
                if(myString[i] == 'a' || myString[i] == 'e' || myString[i] =='i' ||
                    myString[i] == 'o' || myString[i] =='u')

                {
                    countVowels++;
                    
                }

                else if (myString[i] == ' ')
                {
                    countSpace++;
                }
                else
                {
                    countConsonants++;
                }

            }
            Console.WriteLine("VOwels :" +countVowels);
            Console.WriteLine("Consonants:" +countConsonants);
        }
    }
}
