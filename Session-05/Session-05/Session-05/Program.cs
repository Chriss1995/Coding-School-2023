//1.Write a C# program that reverses a given string (your name)
using Session_05;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Principal;

/*string Input = "Chrissanthi";
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
Console.ReadLine();*/

//3.Write a C# program that asks the user for an integer (n) and
//finds all the prime numbers from 1 to n.

Console.WriteLine("Give me a number.");
int num1 = Convert.ToInt32(Console.ReadLine());
PrimeNumbers g = new PrimeNumbers();
for (int i =1; i <= num1; i++)
{
    if (PrimeNumbers.IsPrime(i)) { Console.WriteLine(i + " "); }
}
Console.ReadLine();

//4.Write a C# program to multiply all values from Array1 with all values
//from Array2 and display the results in a new Array.
//Array1: [2, 4, 9, 12]
//Array2: [1, 3, 7, 10]
/*int[] array1 = { 2, 4, 9, 12 };
int[] array2 = { 1, 3, 7, 10 };
int[] newarray = new int[16];
int counter = 0;
for(int i=0; i < array1.Length; i++)
    {
       for (int j= 0; j <array2.Length; j++ )
            {
            newarray[counter] = array1[i] * array2[j];
            Console.WriteLine(newarray[counter]);
            counter = counter + 1;
            }
}
Console.ReadLine();

//Write a C# program to sort the given array of integers from the lowest to the
//highest number.
//• Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ]
int[] third = { 0, -2, 1, 20, -32, 50, -4, 17, 89, 100 };
int temp;
for(int k=0; k < third.Length-1; k++)
{
    for (int m = k + 1; m < third.Length; m++)
    {
        if (third[k] > third[m])
        {
            temp = third[k];
            third[k] = third[m];
            third[m] = temp;
        }
    }
}
foreach(int value in third)
{
    Console.WriteLine(value + " ");
}*/
