using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <=2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (userAge == 3 || userAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (userAge >= 5 && userAge <= 11)
            {
                Console.WriteLine("Elementary school");
            }
        }
    }
}
