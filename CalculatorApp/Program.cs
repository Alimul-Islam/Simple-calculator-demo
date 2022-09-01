using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator cal = new Calculator();

            Console.WriteLine(" Enter your Choice from 1 to 4");

            Console.WriteLine(" For Addition Type        : 1");
            Console.WriteLine(" For Subtraction Type     : 2");
            Console.WriteLine(" For Multiplication Type  : 3");
            Console.WriteLine(" For division Type        : 4");


            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:   
                    cal.Add();

                    break;

                case 2:  
                    cal.Sub();
                    break;
                case 3:
                    cal.Mul();
                    break;
                case 4:
                    cal.Div();
                    break;

                default:
                    Console.WriteLine(" You did not type any of the number");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }


            //cal.Add();
           // cal.Sub();
           // cal.Mul();
           // cal.Div();

        }
    }
}
    class Calculator {

    public void Add()
    {
        Console.WriteLine("*****This is Addition*****");

        Console.WriteLine("Enter your First Number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
      

        Console.WriteLine("Enter your sceond Number:");
        int sceondNumber = Convert.ToInt32(Console.ReadLine());
        
        int result = firstNumber + sceondNumber;
        Console.WriteLine("Your Result is: " + result);


    }

    public void Sub()
    {
        Console.WriteLine("*****This is Subtraction method*****");

        Console.WriteLine("Enter your First Number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter your sceond Number:");
        int sceondNumber = Convert.ToInt32(Console.ReadLine());

        int result = firstNumber - sceondNumber;
        Console.WriteLine("Your Result is: " + result);
    }

    public void Mul()
    {
        Console.WriteLine("*****This is Multiplication method*****");

        Console.WriteLine("This is add method");

        Console.WriteLine("Enter your First Number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter your sceond Number:");
        int sceondNumber = Convert.ToInt32(Console.ReadLine());

        int result = firstNumber * sceondNumber;
        Console.WriteLine("Your Result is: " + result);

    }
    public void Div()
    {
        Console.WriteLine("*****This is Division*****");

        Console.WriteLine("Enter your First Number:");
        float firstNumber = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter your sceond Number:");
        float sceondNumber = Convert.ToInt32(Console.ReadLine());

        float result = firstNumber / sceondNumber;
         
         Console.WriteLine("Your Result is: " + result);

    }
}
