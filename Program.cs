using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*WELCOME TO CALCULATOR*");
            Console.WriteLine("Press 1 for add");
            Console.WriteLine("Press 2 for sub");
            Console.WriteLine("Press 3 for mul");
            Console.WriteLine("Press 4 for div");
            String press;
            press = Console.ReadLine();
            int a = 1;
            do
            {

                switch (press)
                {
                    case "1":
                        Console.WriteLine("Get the numbers for Adding: ");
                        add();
                        break;
                    case "2":
                        Console.WriteLine("Get the numbers for Subtraction: ");
                        sub();
                        break;

                    case "3":
                        Console.WriteLine("Get the numbers for multiplication: ");
                        mul();
                        break;
                    case "4":
                        Console.WriteLine("Get the numbers for division: ");
                        div();
                        break;
                }
                Console.Write("Do you want to continue means press 1 and for discontinue press 0 : ");
                int perform = Convert.ToInt32(Console.ReadLine());
                if(perform == 0)
                {
                    a++;
                }

            } while (a==1);

         }
        static void add()
        {
            Console.WriteLine("Enter a values: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b values: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Adding result is: " + c);
        }
        static void sub()
        {
            Console.WriteLine("Enter a values: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b values: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("subtraction result is: " + c);

        }
        static void mul()
        {
            Console.WriteLine("Enter a values: ");
            long a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b values: ");
            long b = Convert.ToInt32(Console.ReadLine());
            long c = a * b;
            Console.WriteLine("multiplication result is: " + c);

        }
        static void div()
        {
            Console.WriteLine("Enter a values: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b values: ");
            double b = Convert.ToInt32(Console.ReadLine());
            double c = a / b;
            Console.WriteLine("division result is: " + c);

        }
    }
}
