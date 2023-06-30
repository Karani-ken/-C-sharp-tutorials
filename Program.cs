using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intoduction_to_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables declaration, datatypes and initialization
            /* int a = 1;
             int b = 2;
             char sign = '#';
             string name = "kenneth";

             double radius = 10.3;
             bool isMale = true;
             Console.WriteLine(a);
             Console.WriteLine(b);
             Console.WriteLine(sign);
             Console.WriteLine(name);
             Console.WriteLine(radius);
             Console.WriteLine(isMale);*/
            //getting user input
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your score: ");
            double score= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello " + name + " you are " + age + " years old.\n" +
                " You scored "+score+" in your exams.");

            Console.ReadLine();
        }
    }
}
