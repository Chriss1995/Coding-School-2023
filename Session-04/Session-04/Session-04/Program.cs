// See https://aka.ms/new-console-template for more information

using Session_04;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

internal class ProgramOne
{

    private static void Main(string[] args)
    {

        // 1.Write a C# program to print Hello and your name in the same line
        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());

        Console.ReadLine();

        //2.Write a C# program to print the sum of two numbers and the division
        //of those two numbers
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine(num1);
        int sum = num1 + num2;
        Console.WriteLine(sum);
        int div = num1 / num2;
        Console.WriteLine(div);
        Console.ReadLine();

        //3.Write a C# program to print the result of the specified operations
        int result1 = -1 + 5 * 6;
        Console.WriteLine(result1);
        int result2 = 38 + 5 % 7;
        Console.WriteLine(result2);
        int result3= 14 + ((-3 * 6) /7);
        Console.WriteLine(result3);
        double result4 = 2 + (13 / 6) * 6 + Math.Sqrt(7);
        Console.WriteLine(result4);
        double result5 = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
        Console.WriteLine(result5);
        Console.ReadLine();

        //4.Write a C# program that assigns an age (number) (for example 20) and
        //a gender (string)(for example female) and displays something
        //like: "You are female and look younger than 20
        int age = 20;
        string gender = "female";
        Console.WriteLine("You are " + gender + " and look younger than " + age);
        Console.ReadLine();

        //5.Write a C# program that takes an integer representing
        //seconds (for example 45678) and converts it to :

        int seconds = 45678;
        //Minutes
        int minutes = seconds / 60;
        Console.WriteLine(minutes);
        //Hours
        int hours = minutes / 60;
        Console.WriteLine(hours);
        // Days
        int days = hours / 24;
        Console.WriteLine(days);
        //Years
        int years = days / 365;
        Console.WriteLine(years);
        Console.ReadLine();

        //6.Rewrite Program #5 using .Net Libraries

        TimeSpan t = TimeSpan.FromSeconds(45678);
        string answer = string.Format(
              CultureInfo.CurrentCulture,
              "{0} years, {1} days, {2} hours, {3} minutes",
              t.Days / 365,
              (t.Days - (t.Days / 365) * 365) - ((t.Days - (t.Days / 365) * 365) / 30) * 30,
              t.Hours,
              t.Minutes);
        Console.WriteLine("Answer 6: " + answer);

        
        //7.Write a C# program to convert from celsius degrees
        //to Kelvin and Fahrenheit.

        double celsius = 10.5;
        Console.WriteLine("Celsius degrees are:" + celsius);
        double kelvin = celsius + 273;
        Console.WriteLine("Kelvin degrees are:" + kelvin);
        double fahrenheit = celsius * 18 / 10 + 32;
        Console.WriteLine("Fahrenheit degrees are:" + fahrenheit);
        Console.ReadLine();
    }
}