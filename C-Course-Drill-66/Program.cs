using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCourse66
{
    class Program
{
    static void Main(string[] args)
    {

        //Exercise 1
        long input1;
        long result1;

        Console.WriteLine("Enter a number:");
        input1 = Convert.ToInt64(Console.ReadLine());

        result1 = input1 * 50;
        Console.WriteLine("Your number times 50 is : " + result1);

        //Exercise 2
        long input2;
        long result2;

        Console.WriteLine("Enter another number:");
        input2 = Convert.ToInt64(Console.ReadLine());

        result2 = input2 + 25;
        Console.WriteLine("Your number plus 25 is : " + result2);

        //Exercise 3
        double input3;
        double result3;

        Console.WriteLine("Enter another number:");
        input3 = Convert.ToDouble(Console.ReadLine());

        result3 = input3 / 12.5;
        Console.WriteLine("Your number divided by 12.5 is : " + result3);

        //Exercise 4
        int input4;

        Console.WriteLine("Enter another number:");
        input4 = Convert.ToInt32(Console.ReadLine());

        bool result4 = 50 < input4;
        Console.WriteLine("Your number is greater than 50 : " + result4);

        //Exercise 5
        int input5;
        int result5;
        Console.WriteLine("Enter another number:");
        input5 = Convert.ToInt32(Console.ReadLine());

        result5 = input5 % 7;
        Console.WriteLine("Your number divided by 7 has a remainder of : " + result5);


        Console.ReadLine();

    }
}
}
