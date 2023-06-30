using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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
            /* Console.Write("enter your name: ");
             string name = Console.ReadLine();
             Console.Write("enter your age: ");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter your score: ");
             double score= Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Hello " + name + " you are " + age + " years old.\n" +
                 " You scored "+score+" in your exams.");*/
            //conditional statements
            /*& //if statement
             int a = 30;
             int b = 70;
             int c = 100;
             if (a > b)
             {
                 // Console.WriteLine($"{a} is greater that {b} ");
             }
             //if else
             if (a > b)
             {
                 Console.WriteLine($"{a} is the greates number");
             }
             else
             {
                 Console.WriteLine($"{b} is the greatest number");
             }
             //if else if else
             if (a > b && a > c)
             {
                 Console.WriteLine($"{a} is greatest");
             }
             else if (a < b && b > c)
             {
                 Console.WriteLine($"{b} is the largest");
             }
             else
             {
                 Console.WriteLine($"{c} is the largest");
              };*/
            //Loops
            //while loop
            int count = 0;
             while (count < 10)
            {
                Console.WriteLine(count);
                count++;
            }
            Console.WriteLine("do while loop");
            //do while loop
             count = 1;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count < 7);
            //for loop
            Console.WriteLine("for loop");
            for (count = 0; count < 10; count++)
            {
                Console.WriteLine(count);
            }


            Console.ReadLine();
        }
    }
}
