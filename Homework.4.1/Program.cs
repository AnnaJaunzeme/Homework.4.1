using System;

namespace Homework._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;                   
            string operation;
            int answer;

            

            Console.Write("Please input the first number: ");
            Number1= Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Now enter your second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ok, now enter your operation ( x , / , +, -): ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                answer = Number1 * Number2;
                Console.WriteLine(Number1 + " x " + Number2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                answer = Number1 / Number2;
                Console.WriteLine(Number1 + " / " + Number2 + " = " + answer);
                Console.ReadLine();
            }
                        else if (operation == "+")
            {
                answer = Number1 + Number2;
                Console.WriteLine(Number1 + " + " + Number2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = Number1 - Number2;
                Console.WriteLine(Number1 + " - " + Number2 + " = " + answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that is not correct format!\n Please try again!");    
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
        
    

