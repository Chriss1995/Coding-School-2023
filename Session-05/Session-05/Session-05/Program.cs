//1.Write a C# program that reverses a given string (your name)
using Session_05;
using System.ComponentModel;
using System.Security.Principal;

string Input = "Chrissanthi";
StringReversal c = new StringReversal();
string result = StringReversal.Reversion(Input);
Console.WriteLine(result);
Console.ReadLine();

//2. Write a C# program that asks the user for an integer (n) and
// gives them the possibility to choose between computing the sum
// and computing the product of 1,…,n.

Console.WriteLine("Give me a number.");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose between");
Console.WriteLine("true. Sum");
Console.WriteLine("false. Factoral");
bool s = Convert.ToBoolean(Console.ReadLine());
int res = 0;
if(s)
{
    Addition d = new Addition();
    res = Addition.Add(number);
}
else
{
    Factorial e = new Factorial();
    res = Factorial.Fact(number);
}
Console.WriteLine("The result is:" + res);
Console.ReadLine();

//3.Write a C# program that asks the user for an integer (n) and
//finds all the prime numbers from 1 to n.

Console.WriteLine("Give me a number.");
int num1 = Convert.ToInt32(Console.ReadLine());
PrimeNumbers g = new PrimeNumbers();
PrimeNumbers.PrintPrime(num1);
Console.ReadLine();

//4.Write a C# program to multiply all values from Array1 with all values
//from Array2 and display the results in a new Array.
//Array1: [2, 4, 9, 12]
//Array2: [1, 3, 7, 10]
int[] first = { 2, 4, 9, 12 };
int[] second = { 1, 3, 7, 10 };
for(int i=1; i < first.Length; i++)
{
    for (int j= 1; j <second.Length; j++ )
    {
        int[] result2 = first[i] * second[j];
        Console.WriteLine(result);
    }
}

